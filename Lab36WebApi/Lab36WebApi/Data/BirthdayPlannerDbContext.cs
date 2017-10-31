using Lab36WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab36WebApi.Data
{
    public class BirthdayPlannerDbContext : DbContext
    {
        public BirthdayPlannerDbContext(DbContextOptions<BirthdayPlannerDbContext> options) : base(options)
        {

        }
        public DbSet<BirthdayPlanner> BirthdayPlanner { get; set; }

    }
}
