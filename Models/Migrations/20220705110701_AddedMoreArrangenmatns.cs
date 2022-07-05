using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    public partial class AddedMoreArrangenmatns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateStart",
                table: "Arrangements",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateEnd",
                table: "Arrangements",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Arrangements",
                columns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID", "DateEnd", "DateStart", "OnlyAirplaneTicket", "Price", "SeatsInArrangement" },
                values: new object[,]
                {
                    { 5, 2, 4, new DateTime(2022, 9, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), false, 123.22, 10 },
                    { 6, 4, 3, new DateTime(2022, 9, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 117.98999999999999, 10 },
                    { 7, 7, 5, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 126.12, 10 },
                    { 8, 1, 21, null, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), true, 72.319999999999993, 10 },
                    { 9, 2, 4, new DateTime(2022, 9, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), false, 123.22, 10 },
                    { 10, 4, 3, new DateTime(2022, 9, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 117.98999999999999, 10 },
                    { 11, 7, 5, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 126.12, 10 },
                    { 12, 1, 21, null, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), true, 72.319999999999993, 10 },
                    { 13, 2, 21, null, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), false, 45.460000000000001, 10 },
                    { 14, 4, 21, null, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), false, 48.780000000000001, 10 },
                    { 15, 1, 21, null, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), false, 87.450000000000003, 10 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateStart",
                table: "Arrangements",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateEnd",
                table: "Arrangements",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);
        }
    }
}
