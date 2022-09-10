using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    public partial class DeletedSafariBotswanaArr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumn: "ArrangementID",
                keyValue: 21,
                column: "TravelPlaceID",
                value: 15);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumn: "ArrangementID",
                keyValue: 21,
                column: "TravelPlaceID",
                value: 16);
        }
    }
}
