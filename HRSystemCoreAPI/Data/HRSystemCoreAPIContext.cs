using HRSystemCoreAPI.DatabaseEntity;
using Microsoft.EntityFrameworkCore;

namespace HRSystemCoreAPI.Data
{
    public class HRSystemCoreAPIContext : DbContext
    {
        public HRSystemCoreAPIContext (DbContextOptions<HRSystemCoreAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Region> Region { get; set; }

        public DbSet<Company> Company { get; set; }

        public DbSet<Department> Department { get; set; }

        public DbSet<Status> Status { get; set; }

        public DbSet<Person> Person { get; set; }
    }
}
