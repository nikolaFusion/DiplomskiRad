using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    public partial class InsertSeedOfTravelSide : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TravelCompanies",
                columns: new[] { "TravelCompanyID", "Name" },
                values: new object[,]
                {
                    { 1, "Air Serbia" },
                    { 2, "Qatar Airways" },
                    { 3, "Singapore Airlines" },
                    { 4, "Emirates" },
                    { 5, "Japan Airlines" },
                    { 6, "Air France" },
                    { 7, "Etihad" }
                });

            migrationBuilder.InsertData(
                table: "TravelPlaces",
                columns: new[] { "TravelPlaceID", "Country", "Name" },
                values: new object[,]
                {
                    { 1, "Serbia", "Kopaonik - Skiing" },
                    { 2, "France", "Paris - Museum" },
                    { 3, "Iceland", "Iceland - Country of ice and fire" },
                    { 4, "Canada", "Canada - Nature" },
                    { 5, "Norway", "Norway - aurora borealis" },
                    { 6, "India", "India Jungles" },
                    { 7, "Australia", "Australia Jungles" },
                    { 8, "Australia", "Central Ausralia" },
                    { 9, "South Africa", "Cape of good hope" },
                    { 10, "Morocco", "Rabat-Cultures of ancient times" },
                    { 11, "Brazil", "Rio De Janeiro statue" },
                    { 12, "Egypt", "Cairo piramides" },
                    { 13, "China", "Beijing culture" },
                    { 14, "Thailand", "Beauty of Bankok" },
                    { 15, "South Africa", "Safari South Africa" },
                    { 16, "Botswana", "Safari Botswana" },
                    { 17, "France", "Cote d'Azur" },
                    { 18, "Spain", "Corida Spain" },
                    { 19, "China", "Terakota warriors" },
                    { 20, "Australia", "Australia coalas" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TravelCompanies",
                keyColumn: "TravelCompanyID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TravelCompanies",
                keyColumn: "TravelCompanyID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TravelCompanies",
                keyColumn: "TravelCompanyID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TravelCompanies",
                keyColumn: "TravelCompanyID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TravelCompanies",
                keyColumn: "TravelCompanyID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TravelCompanies",
                keyColumn: "TravelCompanyID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TravelCompanies",
                keyColumn: "TravelCompanyID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 20);
        }
    }
}
