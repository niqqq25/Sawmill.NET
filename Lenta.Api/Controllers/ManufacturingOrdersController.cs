using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Lenta.Api.Entities;
using Lenta.Api.Helpers;
using Lenta.Api.Models;
using Lenta.Shared.Filters;
using Lenta.Shared.Models.ManufacturingOrder;
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
    public class ManufacturingOrdersController : ControllerBase
    {
        private readonly AppDbContext dbContext;
        private readonly IMapper mapper;

        public ManufacturingOrdersController(AppDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> GetOrders([FromQuery] string? query, [FromQuery] int? status, [FromQuery] string dateAsc, [FromQuery] int page = 1)
        {
            int pageSize = 2;
            try
            {
                IQueryable<ManufacturingOrder> orders = dbContext.ManufacturingOrders.Include(oi => oi.Product);

                if (!string.IsNullOrEmpty(query))
                {
                    orders = orders.Where(order => order.Product.Name.Contains(query));
                }

                if (status != null && Enum.IsDefined(typeof(ManufacturingOrderStatus), status))
                {
                    orders = orders.Where(order => order.Status == (ManufacturingOrderStatus)status);
                }

                bool.TryParse(dateAsc, out bool isDateAsc);
                if (!isDateAsc)
                {
                    orders = orders.OrderByDescending(o => o.OrderDate);
                }

                int totalRecords = await orders.CountAsync();
                PaginationFilter pageFilter = new PaginationFilter(page, pageSize);
                string url = UriHelper.GetEncodedUrl(HttpContext.Request);

                List<ManufacturingOrder> ordersList = await orders.Skip((page - 1) * pageFilter.PageSize).Take(pageFilter.PageSize).ToListAsync();
                List<ManufacturingOrderDto> orderDtos = mapper.Map<List<ManufacturingOrderDto>>(ordersList);
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
                ManufacturingOrder order = await dbContext.ManufacturingOrders.Where(co => co.Id == id)
                    .Include(mo => mo.Product)
                    .FirstOrDefaultAsync();

                if (order == null)
                {
                    return NotFound($"Order with Id: {id} not found");
                }

                return Ok(new Response<ManufacturingOrderFullDto>(mapper.Map<ManufacturingOrderFullDto>(order)));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        public async Task<ActionResult> CreateOrder(ManufacturingOrderForCreationDto order)
        {
            try
            {
                ManufacturingOrder orderEntity = mapper.Map<ManufacturingOrder>(order);

                Product product = await dbContext.Products.FindAsync(orderEntity.ProductId);
                if (product == null)
                {
                    return NotFound("Provided product doesn't exists");
                }

                dbContext.ManufacturingOrders.Add(orderEntity);
                await dbContext.SaveChangesAsync();

                ManufacturingOrder orderToReturn = dbContext.ManufacturingOrders.Where(o => o.Id == orderEntity.Id).Include(oi => oi.Product).FirstOrDefault();
                ManufacturingOrderDto orderDto = mapper.Map<ManufacturingOrderDto>(orderToReturn);

                return CreatedAtAction(nameof(GetOrder), new { id = orderDto.Id }, orderDto);

            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> UpdateOrder(int id, ManufacturingOrderForUpdateDto updates)
        {
            try
            {
                if (!Enum.IsDefined(typeof(ManufacturingOrderStatus), updates.Status))
                {
                    return BadRequest("Status doesn't exist");
                }

                ManufacturingOrder order = await dbContext.ManufacturingOrders.Where(co => co.Id == id)
                    .Include(oi => oi.Product)
                    .FirstOrDefaultAsync();

                if (order == null)
                {
                    return NotFound($"Order with Id: {id} not found");
                }

                order.Status = updates.Status;
                dbContext.ManufacturingOrders.Update(order);

                await dbContext.SaveChangesAsync();

                return Ok(new Response<ManufacturingOrderFullDto>(mapper.Map<ManufacturingOrderFullDto>(order)));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
