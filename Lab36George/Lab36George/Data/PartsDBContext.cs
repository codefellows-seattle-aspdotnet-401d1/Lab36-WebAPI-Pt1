using Lab36George.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab36George.Data
{
    public class PartsDBContext : DbContext
    {
        public PartsDBContext(DbContextOptions<PartsDBContext> options) : base(options)
        {

        }

        public DbSet<Parts> Parts { get; set; }
    }

    
}
