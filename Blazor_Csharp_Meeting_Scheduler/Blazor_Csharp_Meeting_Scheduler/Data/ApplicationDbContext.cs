using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Blazor_Csharp_Meeting_Scheduler.Models;

namespace Blazor_Csharp_Meeting_Scheduler.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // configure the Employee entity
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);
                entity.Property(e => e.EmployeeName).IsRequired();
                entity.Property(e => e.DepartmentName).IsRequired();
                entity.Property(e => e.EmployeeEmail).IsRequired();
                entity.Property(e => e.EmployeePhone).IsRequired();
                entity.Property(e => e.IsManager).IsRequired();

                entity.HasOne(e => e.Department)
                    .WithMany(d => d.Employees)
                    .HasForeignKey(e => e.DepartmentName)
                    .HasPrincipalKey(d => d.DepartmentName);
            });

            // configure the Department entity
            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(d => d.DepartmentId);
                entity.Property(d => d.DepartmentName).IsRequired().HasMaxLength(100);
            });

            // configure the Meeting entity
            modelBuilder.Entity<Meeting>(entity =>
            {
                entity.HasKey(m => m.MeetingId);
                entity.Property(m => m.MeetingTitle).IsRequired().HasMaxLength(200);
                entity.Property(m => m.DepartmentName).IsRequired().HasMaxLength(100);
                entity.Property(m => m.EmployeeName).IsRequired().HasMaxLength(100);
                entity.Property(m => m.EmployeeEmail).IsRequired().HasMaxLength(100);
                entity.Property(m => m.EmployeePhone).IsRequired().HasMaxLength(20);
                entity.Property(m => m.ManagerName).IsRequired().HasMaxLength(100);
                entity.Property(m => m.MeetingDateTime).IsRequired();
            });
        }
    }
    
}
