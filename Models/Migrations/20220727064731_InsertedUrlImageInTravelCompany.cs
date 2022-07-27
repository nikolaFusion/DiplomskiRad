using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    public partial class InsertedUrlImageInTravelCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "TravelCompanies",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "TravelCompanies",
                keyColumn: "TravelCompanyID",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.farehawker.com/img/image/airserbia_logo.png");

            migrationBuilder.UpdateData(
                table: "TravelCompanies",
                keyColumn: "TravelCompanyID",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://qph.cf2.quoracdn.net/main-qimg-7e85dceee92d64a4a9a33781adbceeee-lq");

            migrationBuilder.UpdateData(
                table: "TravelCompanies",
                keyColumn: "TravelCompanyID",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ9WCuSLWs-8UiZHBGdBWvUcJ76zqa6MhOJow&usqp=CAU");

            migrationBuilder.UpdateData(
                table: "TravelCompanies",
                keyColumn: "TravelCompanyID",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQq0-Svd9L7pwb5n7P9v5QkrzjFyUZ8Gs2yJg&usqp=CAU");

            migrationBuilder.UpdateData(
                table: "TravelCompanies",
                keyColumn: "TravelCompanyID",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://www.beijing-airport.com/images/airlines17/jal-japan-airlines.png");

            migrationBuilder.UpdateData(
                table: "TravelCompanies",
                keyColumn: "TravelCompanyID",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://logos-world.net/wp-content/uploads/2020/03/Air-France-Logo-1976-1990.jpg");

            migrationBuilder.UpdateData(
                table: "TravelCompanies",
                keyColumn: "TravelCompanyID",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://logosvector.net/wp-content/uploads/2015/08/etihad-airways-logo.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "TravelCompanies");
        }
    }
}
