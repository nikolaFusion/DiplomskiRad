using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    public partial class ConntectedArrGroupWithArr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArrangementArrangementGroup",
                columns: table => new
                {
                    ArrangementsGroupArrangementGroupID = table.Column<int>(type: "integer", nullable: false),
                    ArrangementsArrangementID = table.Column<int>(type: "integer", nullable: false),
                    ArrangementsTravelCompanyID = table.Column<int>(type: "integer", nullable: false),
                    ArrangementsTravelPlaceID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArrangementArrangementGroup", x => new { x.ArrangementsGroupArrangementGroupID, x.ArrangementsArrangementID, x.ArrangementsTravelCompanyID, x.ArrangementsTravelPlaceID });
                    table.ForeignKey(
                        name: "FK_ArrangementArrangementGroup_ArrangementGroups_ArrangementsG~",
                        column: x => x.ArrangementsGroupArrangementGroupID,
                        principalTable: "ArrangementGroups",
                        principalColumn: "ArrangementGroupID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArrangementArrangementGroup_Arrangements_ArrangementsArrang~",
                        columns: x => new { x.ArrangementsArrangementID, x.ArrangementsTravelCompanyID, x.ArrangementsTravelPlaceID },
                        principalTable: "Arrangements",
                        principalColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArrangementArrangementGroup_ArrangementsArrangementID_Arran~",
                table: "ArrangementArrangementGroup",
                columns: new[] { "ArrangementsArrangementID", "ArrangementsTravelCompanyID", "ArrangementsTravelPlaceID" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArrangementArrangementGroup");
        }
    }
}
