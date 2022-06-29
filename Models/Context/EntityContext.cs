
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
        public DbSet<Arrangement> Arrangements { get; set; }
        public DbSet<TravelPlace> TravelPlaces { get; set; }
        public DbSet<TravelCompany> TravelCompanies { get; set; }
        public DbSet<UserArrangement> UserArrangements { get; set; }

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

            modelBuilder.Entity<TravelCompany>()
                .HasKey(x => x.TravelCompanyID);

            modelBuilder.Entity<TravelPlace>()
                .HasKey(x => x.TravelPlaceID);

            modelBuilder.Entity<Arrangement>()
                .HasKey(x =>new { x.ArrangementID,x.TravelCompanyID,x.TravelPlaceID });

            modelBuilder.Entity<TravelCompany>()
             .HasMany(x => x.Arrangements)
             .WithOne(x => x.TravelCompany);

            modelBuilder.Entity<TravelPlace>()
             .HasMany(x => x.Arrangements)
             .WithOne(x => x.TravelPlace);

            modelBuilder.Entity<UserArrangement>()
                .HasKey(x => new { x.UserArrangementID, x.UserID, x.ArrangementID });

            modelBuilder.Entity<Arrangement>()
            .HasMany(x => x.UserArrangements)
            .WithOne(x => x.Arrangement);

            modelBuilder.Entity<User>()
             .HasMany(x => x.UserArrangements)
             .WithOne(x => x.User);

        }

        public static void InsertDataInTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User { UserID = 1, FirstName = "Nikola", LastName = "Golubovic", Age = 23, Username="nikola", Password="nikola" },
                                                new User { UserID = 2, FirstName = "Nenad", LastName = "Golubovic", Age = 23, Username="nenad", Password="nenad" });

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

            modelBuilder.Entity<TravelCompany>().HasData(new TravelCompany { TravelCompanyID = 1, Name= "Air Serbia" },
                                                         new TravelCompany { TravelCompanyID = 2, Name = "Qatar Airways" },
                                                         new TravelCompany { TravelCompanyID = 3, Name = "Singapore Airlines" },
                                                         new TravelCompany { TravelCompanyID = 4, Name = "Emirates" },
                                                         new TravelCompany { TravelCompanyID = 5, Name = "Japan Airlines" },
                                                         new TravelCompany { TravelCompanyID = 6, Name = "Air France" },
                                                         new TravelCompany { TravelCompanyID = 7, Name=  "Etihad"});

            modelBuilder.Entity<TravelPlace>().HasData(new TravelPlace { TravelPlaceID = 1, Name = "Kopaonik - Skiing", Country = "Serbia" },
                                                       new TravelPlace { TravelPlaceID = 2, Name = "Paris - Museum", Country = "France" },
                                                       new TravelPlace { TravelPlaceID = 3, Name = "Iceland - Country of ice and fire", Country = "Iceland" },
                                                       new TravelPlace { TravelPlaceID = 4, Name = "Canada - Nature", Country = "Canada" },
                                                       new TravelPlace { TravelPlaceID = 5, Name = "Norway - aurora borealis", Country = "Norway" },
                                                       new TravelPlace { TravelPlaceID = 6, Name = "India Jungles", Country = "India" },
                                                       new TravelPlace { TravelPlaceID = 7, Name = "Australia Jungles", Country = "Australia" },
                                                       new TravelPlace { TravelPlaceID = 8, Name = "Central Ausralia", Country = "Australia" },
                                                       new TravelPlace { TravelPlaceID = 9, Name = "Cape of good hope", Country = "South Africa" },
                                                       new TravelPlace { TravelPlaceID = 10, Name = "Rabat-Cultures of ancient times", Country = "Morocco" },
                                                       new TravelPlace { TravelPlaceID = 11, Name = "Rio De Janeiro statue", Country = "Brazil" },
                                                       new TravelPlace { TravelPlaceID = 12, Name = "Cairo piramides", Country = "Egypt" },
                                                       new TravelPlace { TravelPlaceID = 13, Name = "Beijing culture", Country = "China" },
                                                       new TravelPlace { TravelPlaceID = 14, Name = "Beauty of Bankok", Country = "Thailand" },
                                                       new TravelPlace { TravelPlaceID = 15, Name = "Safari South Africa", Country = "South Africa" },
                                                       new TravelPlace { TravelPlaceID = 16, Name = "Safari Botswana", Country = "Botswana" },
                                                       new TravelPlace { TravelPlaceID = 17, Name = "Cote d'Azur", Country = "France" },
                                                       new TravelPlace { TravelPlaceID = 18, Name = "Corida Spain", Country = "Spain" },
                                                       new TravelPlace { TravelPlaceID = 19, Name = "Terakota warriors", Country = "China" },
                                                       new TravelPlace { TravelPlaceID = 20, Name = "Australia coalas", Country = "Australia" });

        }

    }
}
