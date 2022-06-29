using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Models.Migrations
{
    public partial class AddedTravelerSide : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TravelCompanies",
                columns: table => new
                {
                    TravelCompanyID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelCompanies", x => x.TravelCompanyID);
                });

            migrationBuilder.CreateTable(
                name: "TravelPlaces",
                columns: table => new
                {
                    TravelPlaceID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelPlaces", x => x.TravelPlaceID);
                });

            migrationBuilder.CreateTable(
                name: "Arrangements",
                columns: table => new
                {
                    ArrangementID = table.Column<int>(type: "integer", nullable: false),
                    TravelCompanyID = table.Column<int>(type: "integer", nullable: false),
                    TravelPlaceID = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arrangements", x => new { x.ArrangementID, x.TravelCompanyID, x.TravelPlaceID });
                    table.ForeignKey(
                        name: "FK_Arrangements_TravelCompanies_TravelCompanyID",
                        column: x => x.TravelCompanyID,
                        principalTable: "TravelCompanies",
                        principalColumn: "TravelCompanyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Arrangements_TravelPlaces_TravelPlaceID",
                        column: x => x.TravelPlaceID,
                        principalTable: "TravelPlaces",
                        principalColumn: "TravelPlaceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserArrangements",
                columns: table => new
                {
                    UserArrangementID = table.Column<int>(type: "integer", nullable: false),
                    ArrangementID = table.Column<int>(type: "integer", nullable: false),
                    UserID = table.Column<int>(type: "integer", nullable: false),
                    ArrangementID1 = table.Column<int>(type: "integer", nullable: false),
                    ArrangementTravelCompanyID = table.Column<int>(type: "integer", nullable: false),
                    ArrangementTravelPlaceID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserArrangements", x => new { x.UserArrangementID, x.UserID, x.ArrangementID });
                    table.ForeignKey(
                        name: "FK_UserArrangements_Arrangements_ArrangementID1_ArrangementTra~",
                        columns: x => new { x.ArrangementID1, x.ArrangementTravelCompanyID, x.ArrangementTravelPlaceID },
                        principalTable: "Arrangements",
                        principalColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserArrangements_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arrangements_TravelCompanyID",
                table: "Arrangements",
                column: "TravelCompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Arrangements_TravelPlaceID",
                table: "Arrangements",
                column: "TravelPlaceID");

            migrationBuilder.CreateIndex(
                name: "IX_UserArrangements_ArrangementID1_ArrangementTravelCompanyID_~",
                table: "UserArrangements",
                columns: new[] { "ArrangementID1", "ArrangementTravelCompanyID", "ArrangementTravelPlaceID" });

            migrationBuilder.CreateIndex(
                name: "IX_UserArrangements_UserID",
                table: "UserArrangements",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserArrangements");

            migrationBuilder.DropTable(
                name: "Arrangements");

            migrationBuilder.DropTable(
                name: "TravelCompanies");

            migrationBuilder.DropTable(
                name: "TravelPlaces");
        }
    }
}
