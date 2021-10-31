using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HRSystemCoreAPI.DatabaseEntity;

namespace HRSystemCoreAPI.Data
{
    public class HRSystemCoreAPIContext : DbContext
    {
        public HRSystemCoreAPIContext (DbContextOptions<HRSystemCoreAPIContext> options)
            : base(options)
        {
        }

        public DbSet<HRSystemCoreAPI.DatabaseEntity.Region> Region { get; set; }

        public DbSet<HRSystemCoreAPI.DatabaseEntity.Company> Company { get; set; }

        public DbSet<HRSystemCoreAPI.DatabaseEntity.Department> Department { get; set; }

        public DbSet<HRSystemCoreAPI.DatabaseEntity.Status> Status { get; set; }

        public DbSet<HRSystemCoreAPI.DatabaseEntity.Person> Person { get; set; }
    }
}
