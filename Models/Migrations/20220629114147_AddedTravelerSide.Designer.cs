﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models.Context;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Models.Migrations
{
    [DbContext(typeof(EntityContext))]
    [Migration("20220629114147_AddedTravelerSide")]
    partial class AddedTravelerSide
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("ArrangementID", "TravelCompanyID", "TravelPlaceID");

                    b.HasIndex("TravelCompanyID");

                    b.HasIndex("TravelPlaceID");

                    b.ToTable("Arrangements");
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("TravelPlaceID");

                    b.ToTable("TravelPlaces");
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

            modelBuilder.Entity("Models.UserArrangement", b =>
                {
                    b.Property<int>("UserArrangementID")
                        .HasColumnType("integer");

                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.Property<int>("ArrangementID")
                        .HasColumnType("integer");

                    b.Property<int>("ArrangementID1")
                        .HasColumnType("integer");

                    b.Property<int>("ArrangementTravelCompanyID")
                        .HasColumnType("integer");

                    b.Property<int>("ArrangementTravelPlaceID")
                        .HasColumnType("integer");

                    b.HasKey("UserArrangementID", "UserID", "ArrangementID");

                    b.HasIndex("UserID");

                    b.HasIndex("ArrangementID1", "ArrangementTravelCompanyID", "ArrangementTravelPlaceID");

                    b.ToTable("UserArrangements");
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

            modelBuilder.Entity("Models.UserArrangement", b =>
                {
                    b.HasOne("Models.User", "User")
                        .WithMany("UserArrangements")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Arrangement", "Arrangement")
                        .WithMany("UserArrangements")
                        .HasForeignKey("ArrangementID1", "ArrangementTravelCompanyID", "ArrangementTravelPlaceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Arrangement");

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

            modelBuilder.Entity("Models.Arrangement", b =>
                {
                    b.Navigation("UserArrangements");
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
