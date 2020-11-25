using AutoMapper;
using Lenta.Api.Entities;
using Lenta.Api.Helpers;
using Lenta.Api.Models;
using Lenta.Shared.Filters;
using Lenta.Shared.Models.ManufacturingProcess;
using Lenta.Shared.Types;
using Lenta.Shared.Wrappers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lenta.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessesController : ControllerBase
    {
        private readonly AppDbContext dbContext;
        private readonly IMapper mapper;

        public ProcessesController(AppDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> GetProcesses([FromQuery] string? query, [FromQuery] int page = 1)
        {
            int pageSize = 5;
            try
            {
                IQueryable<ManufacturingProcess> processes = dbContext.ManufacturingProcesses;

                if (!string.IsNullOrEmpty(query))
                {
                    processes = processes.Where(product => product.Name.Contains(query));
                }

                int totalRecords = await processes.CountAsync();
                PaginationFilter pageFilter = new PaginationFilter(page, pageSize);
                string url = UriHelper.GetEncodedUrl(HttpContext.Request);

                List<ManufacturingProcess> processesList = await processes.Skip((page - 1) * pageFilter.PageSize).Take(pageFilter.PageSize).ToListAsync();
                List<ManufacturingProcessDto> processDtos = mapper.Map<List<ManufacturingProcessDto>>(processesList);

                var response = PaginationHelper.CreatePagedResponse(processDtos, pageFilter, totalRecords, url);

                return Ok(response);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetProcess(int id)
        {
            try
            {
                ManufacturingProcess process = await dbContext.ManufacturingProcesses.FindAsync(id);

                if (process == null)
                {
                    return NotFound();
                }

                return Ok(new Response<ManufacturingProcessDto>(mapper.Map<ManufacturingProcessDto>(process)));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        public async Task<ActionResult> CreateProcess(ManufacturingProcessForCreationDto process)
        {
            try
            {
                ManufacturingProcess processEntity = mapper.Map<ManufacturingProcess>(process);
                dbContext.ManufacturingProcesses.Add(processEntity);
                await dbContext.SaveChangesAsync();

                ManufacturingProcessDto processToReturn = mapper.Map<ManufacturingProcessDto>(processEntity);

                return CreatedAtAction(nameof(GetProcess), new { id = processToReturn.Id }, processToReturn);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> UpdateProcess(int id, ManufacturingProcessForUpdateDto process)
        {
            if (!Enum.IsDefined(typeof(ManufacturingProcessStatus), process.Status))
            {
                return BadRequest("Status doesn't exist");
            }

            try
            {
                ManufacturingProcess result = await dbContext.ManufacturingProcesses.Where(mp => mp.Id == id).FirstOrDefaultAsync();
                if (result == null)
                {
                    return NotFound($"Process with Id: {id} not found");
                }

                ManufacturingProcess processEntity = mapper.Map<ManufacturingProcess>(process);
                processEntity.Id = id;

                dbContext.Entry(result).State = EntityState.Detached;
                dbContext.ManufacturingProcesses.Update(processEntity);
                await dbContext.SaveChangesAsync();

                return Ok(new Response<ManufacturingProcessDto>(mapper.Map<ManufacturingProcessDto>(processEntity)));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteProcess(int id)
        {
            try
            {
                var process = await dbContext.ManufacturingProcesses.FindAsync(id);
                if (process == null)
                {
                    return NotFound($"Process with Id: {id} not found");
                }

                dbContext.ManufacturingProcesses.Remove(process);
                await dbContext.SaveChangesAsync();

                return Ok(new Response<ManufacturingProcessDto>(mapper.Map<ManufacturingProcessDto>(process)));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
