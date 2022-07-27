using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    public partial class InsertedMoreArrangementsInSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 2, 4, 3 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 3, 7, 5 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 4, 1, 21 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 5, 2, 4 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 6, 4, 3 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 7, 7, 5 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 8, 1, 21 });

            migrationBuilder.InsertData(
                table: "Arrangements",
                columns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID", "DateEnd", "DateStart", "OnlyAirplaneTicket", "Price", "SeatsInArrangement", "StartPlaceID" },
                values: new object[,]
                {
                    { 2, 5, 3, new DateTime(2022, 9, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 117.98999999999999, 10, 0 },
                    { 3, 1, 5, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 126.12, 10, 0 },
                    { 4, 6, 21, null, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), true, 72.319999999999993, 10, 0 },
                    { 5, 3, 4, new DateTime(2022, 9, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), false, 223.22, 10, 0 },
                    { 6, 2, 3, new DateTime(2022, 9, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 217.99000000000001, 10, 0 },
                    { 7, 4, 5, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 226.12, 10, 0 },
                    { 8, 3, 21, null, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), true, 272.31999999999999, 10, 0 },
                    { 9, 1, 1, new DateTime(2022, 9, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), false, 1212.1199999999999, 10, 0 },
                    { 10, 2, 2, new DateTime(2022, 9, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 142.50999999999999, 10, 0 },
                    { 11, 3, 6, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 436.31999999999999, 10, 0 },
                    { 12, 4, 7, null, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), true, 45.719999999999999, 10, 0 },
                    { 13, 5, 8, new DateTime(2022, 9, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), false, 834.34000000000003, 10, 0 },
                    { 14, 6, 9, new DateTime(2022, 9, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 125.34, 10, 0 },
                    { 15, 7, 10, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 345.23000000000002, 10, 0 },
                    { 16, 6, 11, null, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), true, 373.33999999999997, 10, 0 },
                    { 17, 5, 12, new DateTime(2022, 9, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), false, 612.24000000000001, 10, 0 },
                    { 18, 4, 13, new DateTime(2022, 9, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 247.99000000000001, 10, 0 },
                    { 19, 3, 14, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 326.12, 10, 0 },
                    { 20, 2, 15, null, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), true, 261.31999999999999, 10, 0 },
                    { 21, 1, 16, new DateTime(2022, 9, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), false, 223.22, 10, 0 },
                    { 22, 2, 17, new DateTime(2022, 9, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 617.99000000000001, 10, 0 },
                    { 23, 3, 18, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 526.12, 10, 0 },
                    { 24, 4, 19, null, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), true, 213.31999999999999, 10, 0 },
                    { 25, 5, 20, new DateTime(2022, 9, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), false, 523.22000000000003, 10, 0 },
                    { 26, 6, 21, new DateTime(2022, 9, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 227.99000000000001, 10, 0 },
                    { 27, 7, 15, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 426.12, 10, 0 },
                    { 28, 1, 14, null, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), true, 672.32000000000005, 10, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 2, 5, 3 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 3, 1, 5 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 4, 6, 21 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 5, 3, 4 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 6, 2, 3 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 7, 4, 5 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 8, 3, 21 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 9, 1, 1 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 10, 2, 2 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 11, 3, 6 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 12, 4, 7 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 13, 5, 8 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 14, 6, 9 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 15, 7, 10 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 16, 6, 11 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 17, 5, 12 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 18, 4, 13 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 19, 3, 14 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 20, 2, 15 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 21, 1, 16 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 22, 2, 17 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 23, 3, 18 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 24, 4, 19 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 25, 5, 20 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 26, 6, 21 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 27, 7, 15 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 28, 1, 14 });

            migrationBuilder.InsertData(
                table: "Arrangements",
                columns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID", "DateEnd", "DateStart", "OnlyAirplaneTicket", "Price", "SeatsInArrangement", "StartPlaceID" },
                values: new object[,]
                {
                    { 2, 4, 3, new DateTime(2022, 9, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 117.98999999999999, 10, 0 },
                    { 3, 7, 5, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 126.12, 10, 0 },
                    { 4, 1, 21, null, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), true, 72.319999999999993, 10, 0 },
                    { 5, 2, 4, new DateTime(2022, 9, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), false, 223.22, 10, 0 },
                    { 6, 4, 3, new DateTime(2022, 9, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 217.99000000000001, 10, 0 },
                    { 7, 7, 5, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 226.12, 10, 0 },
                    { 8, 1, 21, null, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), true, 272.31999999999999, 10, 0 }
                });
        }
    }
}
