using Lab36WebApi.Data;
using Lab36WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab36WebApi.Controllers
{
    [Route("api/[controller")]
    public class TasksController : ControllerBase
    {
        private readonly BirthdayPlannerDbContext _context;

        public TasksController(BirthdayPlannerDbContext context)
        {
            _context = context;
        }

        [HttpGet("ID")]
        public IActionResult Get(int id)
        {
            var result = _context.BirthdayPlanner.FirstOrDefault(c => c.ID == id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] BirthdayPlanner plan)
        {
            _context.Add(plan);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = plan.ID }, plan);
        }

    }
}
