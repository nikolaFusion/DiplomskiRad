using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    public partial class changedA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TravelCompanies",
                keyColumn: "TravelCompanyID",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSYbSLMzprI55Yo49K4whp-bihwZHOEQ3WZqQ&usqp=CAU");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TravelCompanies",
                keyColumn: "TravelCompanyID",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://www.breakingtravelnews.com/images/sized/images/uploads/association/American_Express_Global_Business_travel-410x250.png");
        }
    }
}
