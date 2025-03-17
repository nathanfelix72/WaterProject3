using Microsoft.EntityFrameworkCore;
using WaterProject3.Data;

namespace WaterProject3.Data
{
    public class WaterDbContext : DbContext
    {
        public WaterDbContext(DbContextOptions<WaterDbContext> options) : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
    }
}
