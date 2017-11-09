using DragonsAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragonsAPI.Data
{
    public class DragonDbContext : DbContext
    {
        public DragonDbContext(DbContextOptions<DragonDbContext> options) : base(options)
        {

        }

        public DbSet<Dragon> Dragons { get; set; }
    }
}
