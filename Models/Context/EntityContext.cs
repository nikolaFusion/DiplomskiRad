
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

            modelBuilder.Entity<TravelPlace>().HasData(new TravelPlace { TravelPlaceID = 1, Name = "Kopaonik - Skiing", Country = "Serbia",ImageUrl= "https://www.infokop.net/mambots/content/multithumb/images/b.800.600.0.1.stories.vesti.2019.zima.ski-opening-2018.jpg", Description=""},
                                                       new TravelPlace { TravelPlaceID = 2, Name = "Paris - Museum", Country = "France", ImageUrl = "https://www.ceeh.es/wp-content/uploads/2021/06/b.jpg", Description = "" },
                                                       new TravelPlace { TravelPlaceID = 3, Name = "Iceland - Country of ice and fire", Country = "Iceland", ImageUrl = "https://www.telegraph.co.uk/content/dam/Travel/Destinations/Europe/Iceland/Reykjavik/reykjavik-guide-lead-image-48-hours-xlarge.jpg?imwidth=640", Description = "" },
                                                       new TravelPlace { TravelPlaceID = 4, Name = "Canada - Nature", Country = "Canada", ImageUrl = "https://cdn.ceoworld.biz/wp-content/uploads/2022/04/Benefits-of-Holding-a-Canadia-Passport.jpg", Description = "" },
                                                       new TravelPlace { TravelPlaceID = 5, Name = "Norway - aurora borealis", Country = "Norway", ImageUrl = "https://cdn.kimkim.com/files/a/content_articles/featured_photos/9e76018b4dbc115cd4f8a51f0a49a9948a28cb74/big-2d3b3fc973f25a6a9252308e46b35546.jpg", Description = "" },
                                                       new TravelPlace { TravelPlaceID = 6, Name = "India Jungles", Country = "India", ImageUrl = "https://i.pinimg.com/736x/c2/b8/85/c2b88548dd9f646948c27caa3131ea6e.jpg", Description = "" },
                                                       new TravelPlace { TravelPlaceID = 7, Name = "Australia Jungles", Country = "Australia", ImageUrl = "https://travel.mqcdn.com/mapquest/travel/wp-content/uploads/2020/06/GettyImages-676934538-e1592461667985-835x480.jpg", Description = "" },
                                                       new TravelPlace { TravelPlaceID = 8, Name = "Central Ausralia", Country = "Australia", ImageUrl = "https://www.traveller.com.au/content/dam/images/1/0/7/5/k/n/image.related.articleLeadwide.620x349.zsbg7.png/1425452937659.jpg", Description = "" },
                                                       new TravelPlace { TravelPlaceID = 9, Name = "Cape of good hope", Country = "South Africa", ImageUrl = "https://media.cntraveler.com/photos/5b742b0cde8e29470d34f562/16:9/w_2560,c_limit/Cape-of-Good-Hope_GettyImages-962634118.jpg", Description = "" },
                                                       new TravelPlace { TravelPlaceID = 10, Name = "Rabat-Cultures of ancient times", Country = "Morocco", ImageUrl = "https://eeradicalization.com/wp-content/uploads/2020/03/ccimage-shutterstock_1075717346.jpg", Description = "" },
                                                       new TravelPlace { TravelPlaceID = 11, Name = "Rio De Janeiro statue", Country = "Brazil", ImageUrl = "http://thehumanist.com/wp-content/uploads/2015/03/statue.jpg", Description = "" },
                                                       new TravelPlace { TravelPlaceID = 12, Name = "Cairo piramides", Country = "Egypt", ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSLN31eVZKvcBDST2b-ehzDBBqI2X38aN_bRQTIRnY_dOVw7_ycyKLxTCBLywFRnJ4VzTs&usqp=CAU", Description = "" },
                                                       new TravelPlace { TravelPlaceID = 13, Name = "Beijing culture", Country = "China", ImageUrl = "http://chinaflowers.net/blog/wp-content/uploads/2011/11/beijing_1.jpg", Description = "" },
                                                       new TravelPlace { TravelPlaceID = 14, Name = "Beauty of Bankok", Country = "Thailand", ImageUrl = "https://www.planetware.com/wpimages/2019/08/thailand-in-pictures-most-beautiful-places-bangkok-riverfront.jpg", Description = "" },
                                                       new TravelPlace { TravelPlaceID = 15, Name = "Safari South Africa", Country = "South Africa", ImageUrl = "https://ssl.tzoo-img.com/images/blog/2019/2/8/ssimg_210.jpg?width=412&spr=3", Description = "" },
                                                       new TravelPlace { TravelPlaceID = 16, Name = "Safari Botswana", Country = "Botswana", ImageUrl = "https://www.andbeyond.com/wp-content/uploads/sites/5/Herd-of-Elephants-walking-while-guests-cross-channel-on-a-Safari-Game-Drive-in-Botswana.jpg", Description = "" },
                                                       new TravelPlace { TravelPlaceID = 17, Name = "Cote d'Azur", Country = "France", ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSEaXji0VkVk3EnKP7UPrS6ZY-FEQOk9W_5Le4VrSEK07Sy9BJB2-v4u1L9Xsq3blTDnUo&usqp=CAU", Description = "" },
                                                       new TravelPlace { TravelPlaceID = 18, Name = "Corida Spain", Country = "Spain", ImageUrl = "https://m.psecn.photoshelter.com/img-get/I0000KM3Tgz.EL9c/s/900/600/bullfighting-corrida-spain-40.jpg", Description = "" },
                                                       new TravelPlace { TravelPlaceID = 19, Name = "Terakota warriors", Country = "China", ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRg9Bh1GEsvpvMoAKQZMtxLI8v16ormJMHb8z6usd-oj0PPXq5BLCZkKq2qT_YTavgNfd4&usqp=CAU", Description = "" },
                                                       new TravelPlace { TravelPlaceID = 20, Name = "Australia coalas", Country = "Australia", ImageUrl = "https://media.istockphoto.com/photos/little-girl-hugs-koala-picture-id626145812?k=20&m=626145812&s=612x612&w=0&h=X11Nn3LhtqlVj_fU0YvnWY_NrcrKF--P34k_nZNHzZA=", Description = "" },
                                                       new TravelPlace { TravelPlaceID = 21, Name = "Belgrade", Country = "Serbia", ImageUrl = "https://images.squarespace-cdn.com/content/v1/59dab4fd8fd4d21d6a6219b3/1508457059277-DQ6HIDC9VDJCVAY7NR4A/belgrade-serbia.jpg?format=2500w", Description = "" });


            modelBuilder.Entity<Arrangement>().HasData(new Arrangement { ArrangementID = 1, TravelCompanyID = 2, TravelPlaceID = 4, DateStart = new DateTime(2022, 9, 19, 12, 0, 0), DateEnd = new DateTime(2022, 9, 21, 12, 0, 0), Price = 123.22, SeatsInArrangement = 10, OnlyAirplaneTicket = false },
                                                       new Arrangement { ArrangementID = 2, TravelCompanyID = 4, TravelPlaceID = 3, DateStart = new DateTime(2022, 9, 21, 17, 0, 0), DateEnd = new DateTime(2022, 9, 24, 12, 0, 0), Price = 117.99, SeatsInArrangement = 10, OnlyAirplaneTicket = false },
                                                       new Arrangement { ArrangementID = 3, TravelCompanyID = 7, TravelPlaceID = 5, DateStart = new DateTime(2022, 9, 24, 17, 0, 0), DateEnd = new DateTime(2022, 9, 27, 12, 0, 0), Price = 126.12, SeatsInArrangement = 10, OnlyAirplaneTicket = false },
                                                       new Arrangement { ArrangementID = 4, TravelCompanyID = 1, TravelPlaceID = 21, DateStart = new DateTime(2022, 9, 27, 12, 0, 0), DateEnd = null, Price = 72.32, SeatsInArrangement = 10, OnlyAirplaneTicket = true }) ;
        }
    }
}
