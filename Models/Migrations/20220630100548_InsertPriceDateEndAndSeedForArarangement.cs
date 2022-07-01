using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    public partial class InsertPriceDateEndAndSeedForArarangement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Arrangements",
                newName: "DateStart");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateEnd",
                table: "Arrangements",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OnlyAirplaneTicket",
                table: "Arrangements",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Arrangements",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "SeatsInArrangement",
                table: "Arrangements",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Arrangements",
                columns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID", "DateEnd", "DateStart", "OnlyAirplaneTicket", "Price", "SeatsInArrangement" },
                values: new object[,]
                {
                    { 1, 2, 4, new DateTime(2022, 9, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), false, 123.22, 10 },
                    { 2, 4, 3, new DateTime(2022, 9, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 117.98999999999999, 10 },
                    { 3, 7, 5, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 126.12, 10 }
                });

            migrationBuilder.InsertData(
                table: "TravelPlaces",
                columns: new[] { "TravelPlaceID", "Country", "Description", "ImageUrl", "Name" },
                values: new object[] { 21, "Serbia", "", "https://images.squarespace-cdn.com/content/v1/59dab4fd8fd4d21d6a6219b3/1508457059277-DQ6HIDC9VDJCVAY7NR4A/belgrade-serbia.jpg?format=2500w", "Belgrade" });

            migrationBuilder.InsertData(
                table: "Arrangements",
                columns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID", "DateEnd", "DateStart", "OnlyAirplaneTicket", "Price", "SeatsInArrangement" },
                values: new object[] { 4, 1, 21, null, new DateTime(2022, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), true, 72.319999999999993, 10 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 1, 2, 4 });

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
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 21);

            migrationBuilder.DropColumn(
                name: "DateEnd",
                table: "Arrangements");

            migrationBuilder.DropColumn(
                name: "OnlyAirplaneTicket",
                table: "Arrangements");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Arrangements");

            migrationBuilder.DropColumn(
                name: "SeatsInArrangement",
                table: "Arrangements");

            migrationBuilder.RenameColumn(
                name: "DateStart",
                table: "Arrangements",
                newName: "Date");
        }
    }
}
