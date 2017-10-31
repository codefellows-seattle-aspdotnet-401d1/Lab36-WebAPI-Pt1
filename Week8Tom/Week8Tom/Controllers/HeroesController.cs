using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week8Tom.Controllers
{
    [Route("api/[controller]")]
    public class HeroesController : ControllerBase
    {
        //GET
        [HttpGet("{id:int?}")]
        public string Get(string id = "not found")
        {
            return $"I got this {id}";

        }
        //POST

        //PUT

        //DELETE
    }
}
