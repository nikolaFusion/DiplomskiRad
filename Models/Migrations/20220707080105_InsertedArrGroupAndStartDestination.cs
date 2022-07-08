using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Models.Migrations
{
    public partial class InsertedArrGroupAndStartDestination : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserArrangements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Arrangements",
                table: "Arrangements");

            migrationBuilder.AlterColumn<int>(
                name: "ArrangementID",
                table: "Arrangements",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "StartPlaceID",
                table: "Arrangements",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Arrangements",
                table: "Arrangements",
                column: "ArrangementID");

            migrationBuilder.CreateTable(
                name: "ArrangementGroup",
                columns: table => new
                {
                    ArrangementGroupID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ArrangementsIDs = table.Column<List<int>>(type: "integer[]", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    ArrangementID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArrangementGroup", x => x.ArrangementGroupID);
                    table.ForeignKey(
                        name: "FK_ArrangementGroup_Arrangements_ArrangementID",
                        column: x => x.ArrangementID,
                        principalTable: "Arrangements",
                        principalColumn: "ArrangementID");
                });

            migrationBuilder.CreateTable(
                name: "UserArrangementsGroup",
                columns: table => new
                {
                    UserArrangementGroupID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ArrangementGroupID = table.Column<int>(type: "integer", nullable: false),
                    UserID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserArrangementsGroup", x => x.UserArrangementGroupID);
                    table.ForeignKey(
                        name: "FK_UserArrangementsGroup_ArrangementGroup_ArrangementGroupID",
                        column: x => x.ArrangementGroupID,
                        principalTable: "ArrangementGroup",
                        principalColumn: "ArrangementGroupID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserArrangementsGroup_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumn: "ArrangementID",
                keyValue: 1,
                column: "StartPlaceID",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumn: "ArrangementID",
                keyValue: 2,
                column: "StartPlaceID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumn: "ArrangementID",
                keyValue: 3,
                column: "StartPlaceID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumn: "ArrangementID",
                keyValue: 4,
                column: "StartPlaceID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumn: "ArrangementID",
                keyValue: 5,
                column: "StartPlaceID",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumn: "ArrangementID",
                keyValue: 6,
                column: "StartPlaceID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumn: "ArrangementID",
                keyValue: 7,
                column: "StartPlaceID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumn: "ArrangementID",
                keyValue: 8,
                column: "StartPlaceID",
                value: 5);

            migrationBuilder.CreateIndex(
                name: "IX_ArrangementGroup_ArrangementID",
                table: "ArrangementGroup",
                column: "ArrangementID");

            migrationBuilder.CreateIndex(
                name: "IX_UserArrangementsGroup_ArrangementGroupID",
                table: "UserArrangementsGroup",
                column: "ArrangementGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_UserArrangementsGroup_UserID",
                table: "UserArrangementsGroup",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserArrangementsGroup");

            migrationBuilder.DropTable(
                name: "ArrangementGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Arrangements",
                table: "Arrangements");

            migrationBuilder.DropColumn(
                name: "StartPlaceID",
                table: "Arrangements");

            migrationBuilder.AlterColumn<int>(
                name: "ArrangementID",
                table: "Arrangements",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Arrangements",
                table: "Arrangements",
                columns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" });

            migrationBuilder.CreateTable(
                name: "UserArrangements",
                columns: table => new
                {
                    UserArrangementID = table.Column<int>(type: "integer", nullable: false),
                    UserID = table.Column<int>(type: "integer", nullable: false),
                    ArrangementID = table.Column<int>(type: "integer", nullable: false),
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
                name: "IX_UserArrangements_ArrangementID1_ArrangementTravelCompanyID_~",
                table: "UserArrangements",
                columns: new[] { "ArrangementID1", "ArrangementTravelCompanyID", "ArrangementTravelPlaceID" });

            migrationBuilder.CreateIndex(
                name: "IX_UserArrangements_UserID",
                table: "UserArrangements",
                column: "UserID");
        }
    }
}
