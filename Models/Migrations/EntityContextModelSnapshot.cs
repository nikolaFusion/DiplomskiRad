﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models.Context;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Models.Migrations
{
    [DbContext(typeof(EntityContext))]
    partial class EntityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Models.Arrangement", b =>
                {
                    b.Property<int>("ArrangementID")
                        .HasColumnType("integer");

                    b.Property<int>("TravelCompanyID")
                        .HasColumnType("integer");

                    b.Property<int>("TravelPlaceID")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("DateEnd")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateStart")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("OnlyAirplaneTicket")
                        .HasColumnType("boolean");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<int>("SeatsInArrangement")
                        .HasColumnType("integer");

                    b.Property<int>("StartPlaceID")
                        .HasColumnType("integer");

                    b.HasKey("ArrangementID", "TravelCompanyID", "TravelPlaceID");

                    b.HasIndex("TravelCompanyID");

                    b.HasIndex("TravelPlaceID");

                    b.ToTable("Arrangements");

                    b.HasData(
                        new
                        {
                            ArrangementID = 1,
                            TravelCompanyID = 2,
                            TravelPlaceID = 4,
                            DateEnd = new DateTime(2022, 9, 21, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            DateStart = new DateTime(2022, 9, 19, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            OnlyAirplaneTicket = false,
                            Price = 123.22,
                            SeatsInArrangement = 10,
                            StartPlaceID = 0
                        },
                        new
                        {
                            ArrangementID = 2,
                            TravelCompanyID = 4,
                            TravelPlaceID = 3,
                            DateEnd = new DateTime(2022, 9, 24, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            DateStart = new DateTime(2022, 9, 21, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            OnlyAirplaneTicket = false,
                            Price = 117.98999999999999,
                            SeatsInArrangement = 10,
                            StartPlaceID = 0
                        },
                        new
                        {
                            ArrangementID = 3,
                            TravelCompanyID = 7,
                            TravelPlaceID = 5,
                            DateEnd = new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            DateStart = new DateTime(2022, 9, 24, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            OnlyAirplaneTicket = false,
                            Price = 126.12,
                            SeatsInArrangement = 10,
                            StartPlaceID = 0
                        },
                        new
                        {
                            ArrangementID = 4,
                            TravelCompanyID = 1,
                            TravelPlaceID = 21,
                            DateStart = new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            OnlyAirplaneTicket = true,
                            Price = 72.319999999999993,
                            SeatsInArrangement = 10,
                            StartPlaceID = 0
                        },
                        new
                        {
                            ArrangementID = 5,
                            TravelCompanyID = 2,
                            TravelPlaceID = 4,
                            DateEnd = new DateTime(2022, 9, 21, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            DateStart = new DateTime(2022, 9, 19, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            OnlyAirplaneTicket = false,
                            Price = 223.22,
                            SeatsInArrangement = 10,
                            StartPlaceID = 0
                        },
                        new
                        {
                            ArrangementID = 6,
                            TravelCompanyID = 4,
                            TravelPlaceID = 3,
                            DateEnd = new DateTime(2022, 9, 24, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            DateStart = new DateTime(2022, 9, 21, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            OnlyAirplaneTicket = false,
                            Price = 217.99000000000001,
                            SeatsInArrangement = 10,
                            StartPlaceID = 0
                        },
                        new
                        {
                            ArrangementID = 7,
                            TravelCompanyID = 7,
                            TravelPlaceID = 5,
                            DateEnd = new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            DateStart = new DateTime(2022, 9, 24, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            OnlyAirplaneTicket = false,
                            Price = 226.12,
                            SeatsInArrangement = 10,
                            StartPlaceID = 0
                        },
                        new
                        {
                            ArrangementID = 8,
                            TravelCompanyID = 1,
                            TravelPlaceID = 21,
                            DateStart = new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            OnlyAirplaneTicket = true,
                            Price = 272.31999999999999,
                            SeatsInArrangement = 10,
                            StartPlaceID = 0
                        });
                });

            modelBuilder.Entity("Models.ArrangementGroup", b =>
                {
                    b.Property<int>("ArrangementGroupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ArrangementGroupID"));

                    b.Property<List<int>>("ArrangementsIDs")
                        .IsRequired()
                        .HasColumnType("integer[]");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.HasKey("ArrangementGroupID");

                    b.ToTable("ArrangementGroups");
                });

            modelBuilder.Entity("Models.Permission", b =>
                {
                    b.Property<int>("PermissionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PermissionID"));

                    b.Property<string>("NamePermission")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PermissionID");

                    b.ToTable("Permissions");

                    b.HasData(
                        new
                        {
                            PermissionID = 1,
                            NamePermission = "Delete user"
                        },
                        new
                        {
                            PermissionID = 2,
                            NamePermission = "Insert user"
                        },
                        new
                        {
                            PermissionID = 3,
                            NamePermission = "Access basic data"
                        },
                        new
                        {
                            PermissionID = 4,
                            NamePermission = "Access advences data"
                        });
                });

            modelBuilder.Entity("Models.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RoleID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("RoleID");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleID = 1,
                            Name = "Administrator"
                        },
                        new
                        {
                            RoleID = 2,
                            Name = "User"
                        });
                });

            modelBuilder.Entity("Models.RolePermission", b =>
                {
                    b.Property<int>("RoleID")
                        .HasColumnType("integer");

                    b.Property<int>("PermissionID")
                        .HasColumnType("integer");

                    b.HasKey("RoleID", "PermissionID");

                    b.HasIndex("PermissionID");

                    b.ToTable("RolePermissions");

                    b.HasData(
                        new
                        {
                            RoleID = 1,
                            PermissionID = 1
                        },
                        new
                        {
                            RoleID = 1,
                            PermissionID = 2
                        },
                        new
                        {
                            RoleID = 1,
                            PermissionID = 3
                        },
                        new
                        {
                            RoleID = 1,
                            PermissionID = 4
                        },
                        new
                        {
                            RoleID = 2,
                            PermissionID = 3
                        });
                });

            modelBuilder.Entity("Models.TravelCompany", b =>
                {
                    b.Property<int>("TravelCompanyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TravelCompanyID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("TravelCompanyID");

                    b.ToTable("TravelCompanies");

                    b.HasData(
                        new
                        {
                            TravelCompanyID = 1,
                            Name = "Air Serbia"
                        },
                        new
                        {
                            TravelCompanyID = 2,
                            Name = "Qatar Airways"
                        },
                        new
                        {
                            TravelCompanyID = 3,
                            Name = "Singapore Airlines"
                        },
                        new
                        {
                            TravelCompanyID = 4,
                            Name = "Emirates"
                        },
                        new
                        {
                            TravelCompanyID = 5,
                            Name = "Japan Airlines"
                        },
                        new
                        {
                            TravelCompanyID = 6,
                            Name = "Air France"
                        },
                        new
                        {
                            TravelCompanyID = 7,
                            Name = "Etihad"
                        });
                });

            modelBuilder.Entity("Models.TravelPlace", b =>
                {
                    b.Property<int>("TravelPlaceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TravelPlaceID"));

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("TravelPlaceID");

                    b.ToTable("TravelPlaces");

                    b.HasData(
                        new
                        {
                            TravelPlaceID = 1,
                            Country = "Serbia",
                            Description = "",
                            ImageUrl = "https://www.infokop.net/mambots/content/multithumb/images/b.800.600.0.1.stories.vesti.2019.zima.ski-opening-2018.jpg",
                            Name = "Kopaonik - Skiing"
                        },
                        new
                        {
                            TravelPlaceID = 2,
                            Country = "France",
                            Description = "",
                            ImageUrl = "https://www.ceeh.es/wp-content/uploads/2021/06/b.jpg",
                            Name = "Paris - Museum"
                        },
                        new
                        {
                            TravelPlaceID = 3,
                            Country = "Iceland",
                            Description = "",
                            ImageUrl = "https://www.telegraph.co.uk/content/dam/Travel/Destinations/Europe/Iceland/Reykjavik/reykjavik-guide-lead-image-48-hours-xlarge.jpg?imwidth=640",
                            Name = "Iceland - Country of ice and fire"
                        },
                        new
                        {
                            TravelPlaceID = 4,
                            Country = "Canada",
                            Description = "",
                            ImageUrl = "https://cdn.ceoworld.biz/wp-content/uploads/2022/04/Benefits-of-Holding-a-Canadia-Passport.jpg",
                            Name = "Canada - Nature"
                        },
                        new
                        {
                            TravelPlaceID = 5,
                            Country = "Norway",
                            Description = "",
                            ImageUrl = "https://cdn.kimkim.com/files/a/content_articles/featured_photos/9e76018b4dbc115cd4f8a51f0a49a9948a28cb74/big-2d3b3fc973f25a6a9252308e46b35546.jpg",
                            Name = "Norway - aurora borealis"
                        },
                        new
                        {
                            TravelPlaceID = 6,
                            Country = "India",
                            Description = "",
                            ImageUrl = "https://i.pinimg.com/736x/c2/b8/85/c2b88548dd9f646948c27caa3131ea6e.jpg",
                            Name = "India Jungles"
                        },
                        new
                        {
                            TravelPlaceID = 7,
                            Country = "Australia",
                            Description = "",
                            ImageUrl = "https://travel.mqcdn.com/mapquest/travel/wp-content/uploads/2020/06/GettyImages-676934538-e1592461667985-835x480.jpg",
                            Name = "Australia Jungles"
                        },
                        new
                        {
                            TravelPlaceID = 8,
                            Country = "Australia",
                            Description = "",
                            ImageUrl = "https://www.traveller.com.au/content/dam/images/1/0/7/5/k/n/image.related.articleLeadwide.620x349.zsbg7.png/1425452937659.jpg",
                            Name = "Central Ausralia"
                        },
                        new
                        {
                            TravelPlaceID = 9,
                            Country = "South Africa",
                            Description = "",
                            ImageUrl = "https://media.cntraveler.com/photos/5b742b0cde8e29470d34f562/16:9/w_2560,c_limit/Cape-of-Good-Hope_GettyImages-962634118.jpg",
                            Name = "Cape of good hope"
                        },
                        new
                        {
                            TravelPlaceID = 10,
                            Country = "Morocco",
                            Description = "",
                            ImageUrl = "https://eeradicalization.com/wp-content/uploads/2020/03/ccimage-shutterstock_1075717346.jpg",
                            Name = "Rabat-Cultures of ancient times"
                        },
                        new
                        {
                            TravelPlaceID = 11,
                            Country = "Brazil",
                            Description = "",
                            ImageUrl = "http://thehumanist.com/wp-content/uploads/2015/03/statue.jpg",
                            Name = "Rio De Janeiro statue"
                        },
                        new
                        {
                            TravelPlaceID = 12,
                            Country = "Egypt",
                            Description = "",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSLN31eVZKvcBDST2b-ehzDBBqI2X38aN_bRQTIRnY_dOVw7_ycyKLxTCBLywFRnJ4VzTs&usqp=CAU",
                            Name = "Cairo piramides"
                        },
                        new
                        {
                            TravelPlaceID = 13,
                            Country = "China",
                            Description = "",
                            ImageUrl = "http://chinaflowers.net/blog/wp-content/uploads/2011/11/beijing_1.jpg",
                            Name = "Beijing culture"
                        },
                        new
                        {
                            TravelPlaceID = 14,
                            Country = "Thailand",
                            Description = "",
                            ImageUrl = "https://www.planetware.com/wpimages/2019/08/thailand-in-pictures-most-beautiful-places-bangkok-riverfront.jpg",
                            Name = "Beauty of Bankok"
                        },
                        new
                        {
                            TravelPlaceID = 15,
                            Country = "South Africa",
                            Description = "",
                            ImageUrl = "https://ssl.tzoo-img.com/images/blog/2019/2/8/ssimg_210.jpg?width=412&spr=3",
                            Name = "Safari South Africa"
                        },
                        new
                        {
                            TravelPlaceID = 16,
                            Country = "Botswana",
                            Description = "",
                            ImageUrl = "https://www.andbeyond.com/wp-content/uploads/sites/5/Herd-of-Elephants-walking-while-guests-cross-channel-on-a-Safari-Game-Drive-in-Botswana.jpg",
                            Name = "Safari Botswana"
                        },
                        new
                        {
                            TravelPlaceID = 17,
                            Country = "France",
                            Description = "",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSEaXji0VkVk3EnKP7UPrS6ZY-FEQOk9W_5Le4VrSEK07Sy9BJB2-v4u1L9Xsq3blTDnUo&usqp=CAU",
                            Name = "Cote d'Azur"
                        },
                        new
                        {
                            TravelPlaceID = 18,
                            Country = "Spain",
                            Description = "",
                            ImageUrl = "https://m.psecn.photoshelter.com/img-get/I0000KM3Tgz.EL9c/s/900/600/bullfighting-corrida-spain-40.jpg",
                            Name = "Corida Spain"
                        },
                        new
                        {
                            TravelPlaceID = 19,
                            Country = "China",
                            Description = "",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRg9Bh1GEsvpvMoAKQZMtxLI8v16ormJMHb8z6usd-oj0PPXq5BLCZkKq2qT_YTavgNfd4&usqp=CAU",
                            Name = "Terakota warriors"
                        },
                        new
                        {
                            TravelPlaceID = 20,
                            Country = "Australia",
                            Description = "",
                            ImageUrl = "https://media.istockphoto.com/photos/little-girl-hugs-koala-picture-id626145812?k=20&m=626145812&s=612x612&w=0&h=X11Nn3LhtqlVj_fU0YvnWY_NrcrKF--P34k_nZNHzZA=",
                            Name = "Australia coalas"
                        },
                        new
                        {
                            TravelPlaceID = 21,
                            Country = "Serbia",
                            Description = "",
                            ImageUrl = "https://images.squarespace-cdn.com/content/v1/59dab4fd8fd4d21d6a6219b3/1508457059277-DQ6HIDC9VDJCVAY7NR4A/belgrade-serbia.jpg?format=2500w",
                            Name = "Belgrade"
                        });
                });

            modelBuilder.Entity("Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserID"));

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            Age = 23,
                            FirstName = "Nikola",
                            LastName = "Golubovic",
                            Password = "nikola",
                            Username = "nikola"
                        },
                        new
                        {
                            UserID = 2,
                            Age = 23,
                            FirstName = "Nenad",
                            LastName = "Golubovic",
                            Password = "nenad",
                            Username = "nenad"
                        });
                });

            modelBuilder.Entity("Models.UserArrangementGroup", b =>
                {
                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.Property<int>("ArrangementGroupID")
                        .HasColumnType("integer");

                    b.HasKey("UserID", "ArrangementGroupID");

                    b.ToTable("UserArrangementGroups");
                });

            modelBuilder.Entity("Models.UserRole", b =>
                {
                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.Property<int>("RoleID")
                        .HasColumnType("integer");

                    b.HasKey("UserID", "RoleID");

                    b.HasIndex("RoleID");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            RoleID = 1
                        },
                        new
                        {
                            UserID = 2,
                            RoleID = 1
                        });
                });

            modelBuilder.Entity("Models.Arrangement", b =>
                {
                    b.HasOne("Models.TravelCompany", "TravelCompany")
                        .WithMany("Arrangements")
                        .HasForeignKey("TravelCompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.TravelPlace", "TravelPlace")
                        .WithMany("Arrangements")
                        .HasForeignKey("TravelPlaceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TravelCompany");

                    b.Navigation("TravelPlace");
                });

            modelBuilder.Entity("Models.RolePermission", b =>
                {
                    b.HasOne("Models.Permission", "Permission")
                        .WithMany("RolePermissions")
                        .HasForeignKey("PermissionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Role", "Role")
                        .WithMany("RolePermissions")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Models.UserArrangementGroup", b =>
                {
                    b.HasOne("Models.User", "User")
                        .WithMany("UserArrangements")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Models.UserRole", b =>
                {
                    b.HasOne("Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Models.Permission", b =>
                {
                    b.Navigation("RolePermissions");
                });

            modelBuilder.Entity("Models.Role", b =>
                {
                    b.Navigation("RolePermissions");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Models.TravelCompany", b =>
                {
                    b.Navigation("Arrangements");
                });

            modelBuilder.Entity("Models.TravelPlace", b =>
                {
                    b.Navigation("Arrangements");
                });

            modelBuilder.Entity("Models.User", b =>
                {
                    b.Navigation("UserArrangements");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
