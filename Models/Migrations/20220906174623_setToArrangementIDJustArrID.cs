using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Models.Migrations
{
    public partial class setToArrangementIDJustArrID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArrangementArrangementGroup_Arrangements_ArrangementsArrang~",
                table: "ArrangementArrangementGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Arrangements",
                table: "Arrangements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArrangementArrangementGroup",
                table: "ArrangementArrangementGroup");

            migrationBuilder.DropIndex(
                name: "IX_ArrangementArrangementGroup_ArrangementsArrangementID_Arran~",
                table: "ArrangementArrangementGroup");

            migrationBuilder.DropColumn(
                name: "ArrangementsTravelCompanyID",
                table: "ArrangementArrangementGroup");

            migrationBuilder.DropColumn(
                name: "ArrangementsTravelPlaceID",
                table: "ArrangementArrangementGroup");

            migrationBuilder.AlterColumn<int>(
                name: "ArrangementID",
                table: "Arrangements",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Arrangements",
                table: "Arrangements",
                column: "ArrangementID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArrangementArrangementGroup",
                table: "ArrangementArrangementGroup",
                columns: new[] { "ArrangementsArrangementID", "ArrangementsGroupArrangementGroupID" });

            migrationBuilder.CreateIndex(
                name: "IX_ArrangementArrangementGroup_ArrangementsGroupArrangementGro~",
                table: "ArrangementArrangementGroup",
                column: "ArrangementsGroupArrangementGroupID");

            migrationBuilder.AddForeignKey(
                name: "FK_ArrangementArrangementGroup_Arrangements_ArrangementsArrang~",
                table: "ArrangementArrangementGroup",
                column: "ArrangementsArrangementID",
                principalTable: "Arrangements",
                principalColumn: "ArrangementID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArrangementArrangementGroup_Arrangements_ArrangementsArrang~",
                table: "ArrangementArrangementGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Arrangements",
                table: "Arrangements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArrangementArrangementGroup",
                table: "ArrangementArrangementGroup");

            migrationBuilder.DropIndex(
                name: "IX_ArrangementArrangementGroup_ArrangementsGroupArrangementGro~",
                table: "ArrangementArrangementGroup");

            migrationBuilder.AlterColumn<int>(
                name: "ArrangementID",
                table: "Arrangements",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "ArrangementsTravelCompanyID",
                table: "ArrangementArrangementGroup",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ArrangementsTravelPlaceID",
                table: "ArrangementArrangementGroup",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Arrangements",
                table: "Arrangements",
                columns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArrangementArrangementGroup",
                table: "ArrangementArrangementGroup",
                columns: new[] { "ArrangementsGroupArrangementGroupID", "ArrangementsArrangementID", "ArrangementsTravelCompanyID", "ArrangementsTravelPlaceID" });

            migrationBuilder.CreateIndex(
                name: "IX_ArrangementArrangementGroup_ArrangementsArrangementID_Arran~",
                table: "ArrangementArrangementGroup",
                columns: new[] { "ArrangementsArrangementID", "ArrangementsTravelCompanyID", "ArrangementsTravelPlaceID" });

            migrationBuilder.AddForeignKey(
                name: "FK_ArrangementArrangementGroup_Arrangements_ArrangementsArrang~",
                table: "ArrangementArrangementGroup",
                columns: new[] { "ArrangementsArrangementID", "ArrangementsTravelCompanyID", "ArrangementsTravelPlaceID" },
                principalTable: "Arrangements",
                principalColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
