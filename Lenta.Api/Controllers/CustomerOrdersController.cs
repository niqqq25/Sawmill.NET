using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Lenta.Api.Entities;
using Lenta.Api.Helpers;
using Lenta.Api.Models;
using Lenta.Shared.Filters;
using Lenta.Shared.Models.CustomerOrder;
using Lenta.Shared.Types;
using Lenta.Shared.Wrappers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lenta.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerOrdersController : ControllerBase
    {
        private readonly AppDbContext dbContext;
        private readonly IMapper mapper;

        public CustomerOrdersController(AppDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> GetOrders([FromQuery] int? status, [FromQuery] string dateAsc, [FromQuery] int page = 1)
        {
            int pageSize = 5;
            try
            {
                IQueryable<CustomerOrder> orders = dbContext.CustomerOrders;

                if (status != null && Enum.IsDefined(typeof(CustomerOrderStatus), status))
                {
                    orders = orders.Where(order => order.Status == (CustomerOrderStatus)status);
                }

                bool.TryParse(dateAsc, out bool isDateAsc);
                if (!isDateAsc)
                {
                    orders = orders.OrderByDescending(o => o.OrderDate);
                }

                //int totalRecords = 5;
                int totalRecords = await orders.CountAsync();
                PaginationFilter pageFilter = new PaginationFilter(page, pageSize);
                string url = UriHelper.GetEncodedUrl(HttpContext.Request);

                List<CustomerOrder> ordersList = await orders.Skip((page - 1) * pageFilter.PageSize).Take(pageFilter.PageSize).ToListAsync();
                List<CustomerOrderDto> orderDtos = mapper.Map<List<CustomerOrderDto>>(ordersList);
                var response = PaginationHelper.CreatePagedResponse(orderDtos, pageFilter, totalRecords, url);

                return Ok(response);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetOrder(int id)
        {
            try
            {
                CustomerOrder order = await dbContext.CustomerOrders.Where(co => co.Id == id)
                    .Include(co => co.Customer)
                    .Include(co => co.OrderItems)
                    .ThenInclude(oi => oi.Product)
                    .FirstOrDefaultAsync();

                if (order == null)
                {
                    return NotFound($"Order with Id: {id} not found");
                }

                return Ok(new Response<CustomerOrderFullDto>(mapper.Map<CustomerOrderFullDto>(order)));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        public async Task<ActionResult> CreateOrder(CustomerOrderForCreationDto order)
        {
            try
            {
                CustomerOrder orderEntity = mapper.Map<CustomerOrder>(order);

                foreach (CustomerOrderItem orderItem in orderEntity.OrderItems)
                {
                    if (!(orderItem.ProductId == 0 ^ orderItem.Product == null))
                    {
                        return BadRequest("Must provide existing or new product");
                    }

                    if (orderItem.ProductId != 0)
                    {
                        Product product = await dbContext.Products.FindAsync(orderItem.ProductId);
                        if (product == null)
                        {
                            return NotFound("Provided product doesn't exists");
                        }
                    }
                    else
                    {
                        ManufacturingOrder manufacturingOrder = new ManufacturingOrder()
                        {
                            Quantity = orderItem.Quantity,
                        };
                        orderItem.Product.ManufacturingOrders.Add(manufacturingOrder);
                        orderItem.Product.Type = ProductType.Custom;
                    }
                }

                bool isOrderProduced = !orderEntity.OrderItems.Exists(orderItem => orderItem.Product != null);
                orderEntity.Status = isOrderProduced ? CustomerOrderStatus.Ruošiama : CustomerOrderStatus.Gaminama;

                await dbContext.AddAsync(orderEntity);
                await dbContext.SaveChangesAsync();

                CustomerOrderFullDto orderToReturn = mapper.Map<CustomerOrderFullDto>(orderEntity);

                return CreatedAtAction(nameof(GetOrder), new { id = orderToReturn.Id }, orderToReturn);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> UpdateOrder(int id, CustomerOrderForUpdateDto updates)
        {
            try
            {
                if (!Enum.IsDefined(typeof(CustomerOrderStatus), updates.Status))
                {
                    return BadRequest("Status doesn't exist");
                }

                CustomerOrder order = await dbContext.CustomerOrders.Where(co => co.Id == id)
                    .Include(co => co.Customer)
                    .Include(co => co.OrderItems)
                    .ThenInclude(oi => oi.Product)
                    .FirstOrDefaultAsync();

                if (order == null)
                {
                    return NotFound($"Order with Id: {id} not found");
                }

                order.Status = updates.Status;
                dbContext.CustomerOrders.Update(order);

                await dbContext.SaveChangesAsync();

                return Ok(new Response<CustomerOrderFullDto>(mapper.Map<CustomerOrderFullDto>(order)));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
