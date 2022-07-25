using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session07.DataModel
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PermissionRole> PermissionRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=.;initial catalog=140102ef2;integrated security=True;multipleactiveresultsets=True;application name=Session06");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PermissionRole>()
                .HasKey(bc => new { bc.RoleId, bc.PermissionId });

            modelBuilder.Entity<PermissionRole>()
                .HasOne(bc => bc.Role)
                .WithMany(b => b.PermissionRoles)
                .HasForeignKey(bc => bc.RoleId);

            modelBuilder.Entity<PermissionRole>()
                .HasOne(bc => bc.Permission)
                .WithMany(c => c.PermissionRoles)
                .HasForeignKey(bc => bc.PermissionId);
        }
    }
}
