using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    public partial class AddedMoreArrangenmatns2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 13, 2, 21 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 14, 4, 21 });

            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 15, 1, 21 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Arrangements",
                columns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID", "DateEnd", "DateStart", "OnlyAirplaneTicket", "Price", "SeatsInArrangement" },
                values: new object[,]
                {
                    { 13, 2, 21, null, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), false, 45.460000000000001, 10 },
                    { 14, 4, 21, null, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), false, 48.780000000000001, 10 },
                    { 15, 1, 21, null, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), false, 87.450000000000003, 10 }
                });
        }
    }
}
