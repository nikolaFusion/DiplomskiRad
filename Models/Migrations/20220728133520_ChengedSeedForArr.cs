using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    public partial class ChengedSeedForArr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 29, 6, 17 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 30, 7, 17 });

            migrationBuilder.InsertData(
                table: "Arrangements",
                columns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID", "DateEnd", "DateStart", "OnlyAirplaneTicket", "Price", "SeatsInArrangement", "StartPlaceID" },
                values: new object[,]
                {
                    { 33, 6, 17, new DateTime(2022, 9, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), false, 243.22, 10, 0 },
                    { 34, 7, 17, new DateTime(2022, 9, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 327.99000000000001, 10, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 33, 6, 17 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 34, 7, 17 });

            migrationBuilder.InsertData(
                table: "Arrangements",
                columns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID", "DateEnd", "DateStart", "OnlyAirplaneTicket", "Price", "SeatsInArrangement", "StartPlaceID" },
                values: new object[,]
                {
                    { 29, 6, 17, new DateTime(2022, 9, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), false, 243.22, 10, 0 },
                    { 30, 7, 17, new DateTime(2022, 9, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 327.99000000000001, 10, 0 }
                });
        }
    }
}
