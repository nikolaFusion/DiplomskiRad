
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Models.Context
{
    public class EntityContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }

        public EntityContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ConfigureRelationships(modelBuilder);

            InsertDataInTable(modelBuilder);
        }

        public static void ConfigureRelationships(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>()
                .HasKey(x => x.RoleID);

            modelBuilder.Entity<Role>()
             .HasMany(x => x.UserRoles)
             .WithOne(x => x.Role);

            modelBuilder.Entity<Role>()
             .HasMany(x => x.RolePermissions)
             .WithOne(x => x.Role);


            modelBuilder.Entity<User>()
                .HasKey(x => x.UserID);

            modelBuilder.Entity<User>()
                .HasMany(x => x.UserRoles)
                .WithOne(x => x.User);


            modelBuilder.Entity<Permission>()
                .HasKey(x => x.PermissionID);

            modelBuilder.Entity<Permission>()
             .HasMany(x => x.RolePermissions)
             .WithOne(x => x.Permission);


            modelBuilder.Entity<RolePermission>()
                .HasKey(x => new { x.RoleID, x.PermissionID });

            modelBuilder.Entity<UserRole>()
                .HasKey(x => new { x.UserID, x.RoleID });

        }

        public static void InsertDataInTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User { UserID = 1, FirstName = "Nikola", LastName = "Golubovic", Age = 23, Education = Education.Facultaty, Username="nikola", Password="nikola" },
                                                new User { UserID = 2, FirstName = "Nenad", LastName = "Golubovic", Age = 23, Education = Education.Facultaty, Username="nenad", Password="nenad" });

            modelBuilder.Entity<Role>().HasData(new Role { RoleID = 1, Name = "Administrator" },
                                                new Role { RoleID = 2, Name = "User" });

            modelBuilder.Entity<Permission>().HasData(new Permission { PermissionID = 1, NamePermission = "Delete user" },
                                                      new Permission { PermissionID = 2, NamePermission = "Insert user" },
                                                      new Permission { PermissionID = 3, NamePermission = "Access basic data" },
                                                      new Permission { PermissionID = 4, NamePermission = "Access advences data" });

            modelBuilder.Entity<RolePermission>().HasData(new RolePermission { PermissionID = 1, RoleID = 1 },
                                                          new RolePermission { PermissionID = 2, RoleID = 1 },
                                                          new RolePermission { PermissionID = 3, RoleID = 1 },
                                                          new RolePermission { PermissionID = 4, RoleID = 1 },
                                                          new RolePermission { PermissionID = 3, RoleID = 2 });

            modelBuilder.Entity<UserRole>().HasData(new UserRole { UserID = 1, RoleID = 1 },
                                                    new UserRole { UserID = 2, RoleID = 1 });


        }

    }
}
