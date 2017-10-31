using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week8Project.Data;
using Week8Project.Models;

namespace Week8Project.Controllers
{
    [Route("api/[controller]")]
    public class PokemonController : ControllerBase
    {
        //Set up dependancy injection for the context
        private readonly PokemonDbContext _context;

        //Construct the controller with the injected context
        public PokemonController(PokemonDbContext context)
        {
            _context = context;
        }

        //Get Pokemon from the db
        [HttpGet("{id:int?}")]
        //Require int to target pokemon to get
        public IActionResult Get(int id)
        {
            //find the pokemon by its's ID
            var result = _context.Pokemon.FirstOrDefault(p => p.ID == id);
            //return a status 200 and the requested pokemon
            return Ok(result);
        }

        //Post a new Pokemon to the db
        //Extract the pokemon to add from the req body
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Pokemon newPMon)
        {
            //Add the new pokemon to the db
            await _context.AddAsync(newPMon);
            //Save the change to the db
            await _context.SaveChangesAsync();
            //return creation success status and the pokemon plus its location
            return CreatedAtAction("Get", new { id = newPMon.ID, newPMon });
        }

        //Put
        //Coming soon to an application near you!

        //Delete
        //See "Put" msg.
    }
}
