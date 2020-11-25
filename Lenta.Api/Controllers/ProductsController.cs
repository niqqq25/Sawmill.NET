using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Lenta.Api.Entities;
using Lenta.Api.Helpers;
using Lenta.Api.Models;
using Lenta.Shared.Filters;
using Lenta.Shared.Models.Product;
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
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext dbContext;
        private readonly IMapper mapper;

        public ProductsController(AppDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> GetProducts([FromQuery] string? query, [FromQuery] int page = 1)
        {
            int pageSize = 5;
            try
            {
                IQueryable<Product> products = dbContext.Products.Where(product => product.Type != ProductType.Custom);

                if (!string.IsNullOrEmpty(query))
                {
                    products = products.Where(product => product.Name.Contains(query));
                }

                int totalRecords = await products.CountAsync();
                PaginationFilter pageFilter = new PaginationFilter(page, pageSize);
                string url = UriHelper.GetEncodedUrl(HttpContext.Request);

                List<Product> productsList = await products.Skip((page - 1) * pageFilter.PageSize).Take(pageFilter.PageSize).ToListAsync();
                List<ProductDto> productDtos = mapper.Map<List<ProductDto>>(productsList);

                var response = PaginationHelper.CreatePagedResponse(productDtos, pageFilter, totalRecords, url);

                return Ok(response);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetProduct(int id)
        {
            try
            {
                Product product = await dbContext.Products.FindAsync(id);

                if (product == null || product.Type == ProductType.Custom)
                {
                    return NotFound();
                }

                return Ok(new Response<ProductDto>(mapper.Map<ProductDto>(product)));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        public async Task<ActionResult> CreateProduct(ProductForCreationDto product)
        {
            try
            {
                Product productEntity = mapper.Map<Product>(product);
                productEntity.Type = ProductType.Default;

                dbContext.Products.Add(productEntity);
                await dbContext.SaveChangesAsync();

                ProductDto productToReturn = mapper.Map<ProductDto>(productEntity);

                return CreatedAtAction(nameof(GetProduct), new { id = productToReturn.Id }, productToReturn);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> UpdateProduct(int id, ProductForUpdateDto product)
        {
            try
            {
                Product result = await dbContext.Products.FindAsync(id);
                if (result == null)
                {
                    return NotFound($"Product with Id: {id} not found");
                }

                Product productEntity = mapper.Map<Product>(product);
                productEntity.Id = id;
                productEntity.Type = result.Type;

                dbContext.Entry(result).State = EntityState.Detached;
                dbContext.Products.Update(productEntity);
                await dbContext.SaveChangesAsync();

                return Ok(new Response<ProductDto>(mapper.Map<ProductDto>(productEntity)));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteProduct(int id)
        {
            try
            {
                var product = await dbContext.Products.FindAsync(id);
                if (product == null)
                {
                    return NotFound($"Product with Id: {id} not found");
                }

                dbContext.Products.Remove(product);
                await dbContext.SaveChangesAsync();

                return Ok(new Response<ProductDto>(mapper.Map<ProductDto>(product)));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
