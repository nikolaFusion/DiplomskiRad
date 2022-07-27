using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    public partial class ChangedSeedTravelCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TravelCompanies",
                keyColumn: "TravelCompanyID",
                keyValue: 1,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "https://i.pinimg.com/originals/36/60/eb/3660eb409de95cf3b7845fbd529672d5.jpg", "Expedia Group" });

            migrationBuilder.UpdateData(
                table: "TravelCompanies",
                keyColumn: "TravelCompanyID",
                keyValue: 2,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "https://www.breakingtravelnews.com/images/sized/images/uploads/association/American_Express_Global_Business_travel-410x250.png", "American Express Global Business Travel" });

            migrationBuilder.UpdateData(
                table: "TravelCompanies",
                keyColumn: "TravelCompanyID",
                keyValue: 3,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "https://www.logolynx.com/images/logolynx/45/45e2d21832a6c5bd9b8535500eb6f988.jpeg", "BCD Travel" });

            migrationBuilder.UpdateData(
                table: "TravelCompanies",
                keyColumn: "TravelCompanyID",
                keyValue: 4,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRGFY6ACLcnZRRQHxCfeAoarnhQ2WFYNGIjYwj1--ROVHv8KSC3rh0BBn7LJM4mzy8gT_w&usqp=CAU", "CWT" });

            migrationBuilder.UpdateData(
                table: "TravelCompanies",
                keyColumn: "TravelCompanyID",
                keyValue: 5,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/c/c9/Flight_Centre_Canada_Logo.png", "Flight Centre Travel Group" });

            migrationBuilder.UpdateData(
                table: "TravelCompanies",
                keyColumn: "TravelCompanyID",
                keyValue: 6,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRpPcnJXpBYR9oWJNGY8Y61X4dMaHZbuPZ8ab8GOeTTjCDsXX9afgWFFrhSzqm9707ati8&usqp=CAU", "Travel Leaders Group" });

            migrationBuilder.UpdateData(
                table: "TravelCompanies",
                keyColumn: "TravelCompanyID",
                keyValue: 7,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "https://cdn.travelpulse.com/images/bd2ed357-9adc-bb59-4f8f-1e08b5932b51/0b77cb8d-aa17-4bd4-b861-bebe0b369269/500x309.jpg", "American Express" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TravelCompanies",
                keyColumn: "TravelCompanyID",
                keyValue: 1,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "https://www.farehawker.com/img/image/airserbia_logo.png", "Air Serbia" });

            migrationBuilder.UpdateData(
                table: "TravelCompanies",
                keyColumn: "TravelCompanyID",
                keyValue: 2,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "https://qph.cf2.quoracdn.net/main-qimg-7e85dceee92d64a4a9a33781adbceeee-lq", "Qatar Airways" });

            migrationBuilder.UpdateData(
                table: "TravelCompanies",
                keyColumn: "TravelCompanyID",
                keyValue: 3,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ9WCuSLWs-8UiZHBGdBWvUcJ76zqa6MhOJow&usqp=CAU", "Singapore Airlines" });

            migrationBuilder.UpdateData(
                table: "TravelCompanies",
                keyColumn: "TravelCompanyID",
                keyValue: 4,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQq0-Svd9L7pwb5n7P9v5QkrzjFyUZ8Gs2yJg&usqp=CAU", "Emirates" });

            migrationBuilder.UpdateData(
                table: "TravelCompanies",
                keyColumn: "TravelCompanyID",
                keyValue: 5,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "https://www.beijing-airport.com/images/airlines17/jal-japan-airlines.png", "Japan Airlines" });

            migrationBuilder.UpdateData(
                table: "TravelCompanies",
                keyColumn: "TravelCompanyID",
                keyValue: 6,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "https://logos-world.net/wp-content/uploads/2020/03/Air-France-Logo-1976-1990.jpg", "Air France" });

            migrationBuilder.UpdateData(
                table: "TravelCompanies",
                keyColumn: "TravelCompanyID",
                keyValue: 7,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "https://logosvector.net/wp-content/uploads/2015/08/etihad-airways-logo.png", "Etihad" });
        }
    }
}
