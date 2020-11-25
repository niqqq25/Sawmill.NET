using System.Linq;
using System.Threading.Tasks;
using Lenta.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.Extensions;
using Lenta.Api.Helpers;
using Lenta.Api.Entities;
using AutoMapper;
using System.Collections.Generic;
using Lenta.Shared.Models.Resource;
using Lenta.Shared.Filters;
using Lenta.Shared.Wrappers;

namespace Lenta.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourcesController : ControllerBase
    {
        private readonly AppDbContext dbContext;
        private readonly IMapper mapper;

        public ResourcesController(AppDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> GetResources([FromQuery] string? query, [FromQuery] int page = 1)
        {
            int pageSize = 5;
            try
            {
                IQueryable<Resource> resources = dbContext.Resources;

                if (!string.IsNullOrEmpty(query))
                {
                    resources = resources.Where(resource => resource.Name.Contains(query));
                }

                int totalRecords = await resources.CountAsync();
                PaginationFilter pageFilter = new PaginationFilter(page, pageSize);
                string url = UriHelper.GetEncodedUrl(HttpContext.Request);

                List<Resource> resourcesList = await resources.Skip((page - 1) * pageFilter.PageSize).Take(pageFilter.PageSize).ToListAsync();
                List<ResourceDto> resourceDtos = mapper.Map<List<ResourceDto>>(resourcesList);


                var response = PaginationHelper.CreatePagedResponse(resourceDtos, pageFilter, totalRecords, url);

                return Ok(response);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetResource(int id)
        {
            try
            {
                Resource resource = await dbContext.Resources.FindAsync(id);

                if (resource == null)
                {
                    return NotFound($"Resource with Id: {id} not found");
                }

                return Ok(new Response<ResourceDto>(mapper.Map<ResourceDto>(resource)));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        public async Task<ActionResult> CreateResource(ResourceForCreationDto resource)
        {
            try
            {
                Resource resourceEntity = mapper.Map<Resource>(resource);
                dbContext.Resources.Add(resourceEntity);
                await dbContext.SaveChangesAsync();

                ResourceDto resourceToReturn = mapper.Map<ResourceDto>(resourceEntity);

                return CreatedAtAction(nameof(GetResource), new { id = resourceToReturn.Id }, resourceToReturn);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> UpdateResource(int id, ResourceForUpdateDto resource)
        {
            try
            {
                Resource result = await dbContext.Resources.FindAsync(id);
                if (result == null)
                {
                    return NotFound($"Resource with Id: {id} not found");
                }

                Resource resourceEntity = mapper.Map<Resource>(resource);
                resourceEntity.Id = id;

                dbContext.Entry(result).State = EntityState.Detached;
                dbContext.Resources.Update(mapper.Map<Resource>(resourceEntity));

                await dbContext.SaveChangesAsync();

                return Ok(new Response<ResourceDto>(mapper.Map<ResourceDto>(resourceEntity)));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteResource(int id)
        {
            try
            {
                var resource = await dbContext.Resources.FindAsync(id);
                if (resource == null)
                {
                    return NotFound($"Resource with Id: {id} not found");
                }

                dbContext.Resources.Remove(resource);
                await dbContext.SaveChangesAsync();

                return Ok();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
