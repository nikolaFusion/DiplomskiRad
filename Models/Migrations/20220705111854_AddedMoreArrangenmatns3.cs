using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    public partial class AddedMoreArrangenmatns3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 9, 2, 4 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 10, 4, 3 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 11, 7, 5 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 12, 1, 21 });

            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 5, 2, 4 },
                column: "Price",
                value: 223.22);

            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 6, 4, 3 },
                column: "Price",
                value: 217.99000000000001);

            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 7, 7, 5 },
                column: "Price",
                value: 226.12);

            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 8, 1, 21 },
                column: "Price",
                value: 272.31999999999999);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 5, 2, 4 },
                column: "Price",
                value: 123.22);

            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 6, 4, 3 },
                column: "Price",
                value: 117.98999999999999);

            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 7, 7, 5 },
                column: "Price",
                value: 126.12);

            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 8, 1, 21 },
                column: "Price",
                value: 72.319999999999993);

            migrationBuilder.InsertData(
                table: "Arrangements",
                columns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID", "DateEnd", "DateStart", "OnlyAirplaneTicket", "Price", "SeatsInArrangement" },
                values: new object[,]
                {
                    { 9, 2, 4, new DateTime(2022, 9, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), false, 123.22, 10 },
                    { 10, 4, 3, new DateTime(2022, 9, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 117.98999999999999, 10 },
                    { 11, 7, 5, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 126.12, 10 },
                    { 12, 1, 21, null, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), true, 72.319999999999993, 10 }
                });
        }
    }
}
