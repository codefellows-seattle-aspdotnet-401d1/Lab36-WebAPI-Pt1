﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week8Tom.Data;
using Week8Tom.Models;

namespace Week8Tom.Controllers
{
    [Route("api/[controller]")]
    public class HeroesController : ControllerBase
    {
        private readonly HeroStatsDbContext _context;

        public HeroesController(HeroStatsDbContext context)
        {
            _context = context;
        }

        //GET
        [HttpGet("{id:int?}")]
        public IActionResult Get(int id)
        {
            var result = _context.HeroStats.FirstOrDefault(h =>  h.Id == id);

            return Ok(result);

        }

        //POST
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]HeroStats stat)
        {
            _context.Add(stat);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = stat.Id }, stat);
        }

        //PUT

        //DELETE
    }
}
