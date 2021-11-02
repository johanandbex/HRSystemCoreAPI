using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HRSystemCoreAPI.DatabaseEntity
{
    public partial class hr_testContext : DbContext
    {
        public hr_testContext()
        {
        }

        public hr_testContext(DbContextOptions<hr_testContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
       /* 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=tcp:johanssqlserver.database.windows.net,1433;Initial Catalog=hr_test;User Id=johanandbex@johanssqlserver;Password=Bex32ball!");
            }
        }
        */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.CompanyId)
                    .IsClustered(false);

                entity.ToTable("Company");

                entity.HasIndex(e => e.CompanyId, "ClusteredIndex-20211027-072613")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
                /*
                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Company_Region");
                */
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DepartmentId)
                    .IsClustered(false);

                entity.ToTable("Department");

                entity.HasIndex(e => e.DepartmentId, "ClusteredIndex-20211027-073534")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
                /*
                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Department_Company");
                */
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.PersonId)
                    .IsClustered(false);

                entity.ToTable("Person");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
                /*
                entity.HasOne(d => d.Company)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_Person_Company");
                
                entity.HasOne(d => d.Department)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Person_Department");

                
                entity.HasOne(d => d.Status)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Person_Status");
                */
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.HasKey(e => e.RegionId)
                    .IsClustered(false);

                entity.ToTable("Region");

                entity.HasIndex(e => e.RegionId, "ClusteredIndex-20211027-072531")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.RegionName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("Status");

                entity.Property(e => e.Status1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Status");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
