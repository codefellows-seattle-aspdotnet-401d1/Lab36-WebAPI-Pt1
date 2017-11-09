using DragonsAPI.Data;
using DragonsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragonsAPI.Controllers
{
    // Inherit from ControllerBase to keep code light by not including functionality not needed in an API format
    [Route("api/[controller]")]
    public class DragonsController : ControllerBase
    {
        private readonly DragonDbContext _context;

        public DragonsController(DragonDbContext context)
        {
            _context = context;
        }

        // GET action
        [HttpGet("{id:int?}")]
        public IActionResult Get(int id)
        {
            var result = _context.Dragons.FirstOrDefault(d => d.Id == id);
            return Ok(result);
        }

        // POST action
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Dragon item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = item.Id }, item);
        }
    }
}
