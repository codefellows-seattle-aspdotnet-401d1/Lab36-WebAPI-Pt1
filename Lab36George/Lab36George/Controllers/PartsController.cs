using Lab36George.Data;
using Lab36George.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab36George.Controllers
{
    // attributing routing changes the default route and adds /api to the url required to get here
    // route token that allows us to change the name of the controller without breaking things ([controller])
    [Route("api/[controller]")]
    public class PartsController : ControllerBase
    {
        // dependency injection
        private readonly PartsDBContext _context;
        public PartsController(PartsDBContext context)
        {
            _context = context;
        }

        // Get one
        // Model binding to grab an integer from the URL
        [HttpGet("{id:int?}")]
        // id constraint to make sure we're only accepting an int
        public IActionResult Get(int id)
        {
            // grabs the first record from the database with a matching id to the one entered
            var result = _context.Parts.FirstOrDefault(p => p.PartID == id);
            return Ok(result);
        }
        
        // Get all
        [HttpGet]
        public IEnumerable<Parts> Get()
        {
            // just grabs all the items in the database (I couldn't resist after class today)
            return _context.Parts;
        }

        // Post
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Parts part)
        {
            // add part to database
            _context.Add(part);
            // wait for the response from the database saying the add was successful
            await _context.SaveChangesAsync();
            // return information about the addtion we just did
            return CreatedAtAction("Get", new { id = part.PartID }, part);
        }

        // Put
        //[HttpPut]

        // Delete
        [HttpDelete("(id:int)")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = _context.Parts.FirstOrDefault(d => d.PartID == id);
            if (result != null)
            {
                _context.Parts.Remove(result);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return BadRequest();
        }




    }
}
