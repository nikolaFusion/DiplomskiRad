using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    public partial class InsertedMoreArrangementsInSeed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Arrangements",
                columns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID", "DateEnd", "DateStart", "OnlyAirplaneTicket", "Price", "SeatsInArrangement", "StartPlaceID" },
                values: new object[,]
                {
                    { 29, 1, 17, new DateTime(2022, 9, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), false, 213.22, 10, 0 },
                    { 29, 6, 17, new DateTime(2022, 9, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), false, 243.22, 10, 0 },
                    { 30, 3, 17, new DateTime(2022, 9, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 237.99000000000001, 10, 0 },
                    { 30, 7, 17, new DateTime(2022, 9, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 327.99000000000001, 10, 0 },
                    { 31, 4, 17, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 426.12, 10, 0 },
                    { 32, 5, 17, null, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), true, 312.20999999999998, 10, 0 }
                });

            migrationBuilder.UpdateData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 17,
                column: "ImageUrl",
                value: "https://static.tildacdn.com/tild6333-3963-4232-b139-343838313334/ote-d-azur-cruise-tr.jpeg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 29, 1, 17 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 29, 6, 17 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 30, 3, 17 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 30, 7, 17 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 31, 4, 17 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 32, 5, 17 });

            migrationBuilder.UpdateData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 17,
                column: "ImageUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSEaXji0VkVk3EnKP7UPrS6ZY-FEQOk9W_5Le4VrSEK07Sy9BJB2-v4u1L9Xsq3blTDnUo&usqp=CAU");
        }
    }
}
