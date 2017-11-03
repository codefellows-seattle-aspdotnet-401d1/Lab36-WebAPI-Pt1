using Lab36George.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab36George.Data
{
    public class PartsDBContext : DbContext
    {
        // inherits db context into this particular context
        public PartsDBContext(DbContextOptions<PartsDBContext> options) : base(options)
        {

        }
        // reference to our model where the fields are contained
        public DbSet<Parts> Parts { get; set; }
    }

    
}
