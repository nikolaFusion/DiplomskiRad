using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Models.Migrations
{
    public partial class InsertedArrangementGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArrangementGroup_Arrangements_ArrangementID",
                table: "ArrangementGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_UserArrangementsGroup_ArrangementGroup_ArrangementGroupID",
                table: "UserArrangementsGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_UserArrangementsGroup_Users_UserID",
                table: "UserArrangementsGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Arrangements",
                table: "Arrangements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserArrangementsGroup",
                table: "UserArrangementsGroup");

            migrationBuilder.DropIndex(
                name: "IX_UserArrangementsGroup_ArrangementGroupID",
                table: "UserArrangementsGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArrangementGroup",
                table: "ArrangementGroup");

            migrationBuilder.DropIndex(
                name: "IX_ArrangementGroup_ArrangementID",
                table: "ArrangementGroup");

            migrationBuilder.DropColumn(
                name: "ArrangementID",
                table: "ArrangementGroup");

            migrationBuilder.RenameTable(
                name: "UserArrangementsGroup",
                newName: "UserArrangementGroup");

            migrationBuilder.RenameTable(
                name: "ArrangementGroup",
                newName: "ArrangementGroups");

            migrationBuilder.RenameIndex(
                name: "IX_UserArrangementsGroup_UserID",
                table: "UserArrangementGroup",
                newName: "IX_UserArrangementGroup_UserID");

            migrationBuilder.AlterColumn<int>(
                name: "ArrangementID",
                table: "Arrangements",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "UserArrangementGroupID",
                table: "UserArrangementGroup",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Arrangements",
                table: "Arrangements",
                columns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserArrangementGroup",
                table: "UserArrangementGroup",
                columns: new[] { "UserArrangementGroupID", "UserID", "ArrangementGroupID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArrangementGroups",
                table: "ArrangementGroups",
                column: "ArrangementGroupID");

            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 1, 2, 4 },
                column: "StartPlaceID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 2, 4, 3 },
                column: "StartPlaceID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 3, 7, 5 },
                column: "StartPlaceID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 4, 1, 21 },
                column: "StartPlaceID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 5, 2, 4 },
                column: "StartPlaceID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 6, 4, 3 },
                column: "StartPlaceID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 7, 7, 5 },
                column: "StartPlaceID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumns: new[] { "ArrangementID", "TravelCompanyID", "TravelPlaceID" },
                keyValues: new object[] { 8, 1, 21 },
                column: "StartPlaceID",
                value: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_UserArrangementGroup_Users_UserID",
                table: "UserArrangementGroup",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserArrangementGroup_Users_UserID",
                table: "UserArrangementGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Arrangements",
                table: "Arrangements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserArrangementGroup",
                table: "UserArrangementGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArrangementGroups",
                table: "ArrangementGroups");

            migrationBuilder.RenameTable(
                name: "UserArrangementGroup",
                newName: "UserArrangementsGroup");

            migrationBuilder.RenameTable(
                name: "ArrangementGroups",
                newName: "ArrangementGroup");

            migrationBuilder.RenameIndex(
                name: "IX_UserArrangementGroup_UserID",
                table: "UserArrangementsGroup",
                newName: "IX_UserArrangementsGroup_UserID");

            migrationBuilder.AlterColumn<int>(
                name: "ArrangementID",
                table: "Arrangements",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "UserArrangementGroupID",
                table: "UserArrangementsGroup",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "ArrangementID",
                table: "ArrangementGroup",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Arrangements",
                table: "Arrangements",
                column: "ArrangementID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserArrangementsGroup",
                table: "UserArrangementsGroup",
                column: "UserArrangementGroupID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArrangementGroup",
                table: "ArrangementGroup",
                column: "ArrangementGroupID");

            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumn: "ArrangementID",
                keyValue: 1,
                column: "StartPlaceID",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumn: "ArrangementID",
                keyValue: 2,
                column: "StartPlaceID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumn: "ArrangementID",
                keyValue: 3,
                column: "StartPlaceID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumn: "ArrangementID",
                keyValue: 4,
                column: "StartPlaceID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumn: "ArrangementID",
                keyValue: 5,
                column: "StartPlaceID",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumn: "ArrangementID",
                keyValue: 6,
                column: "StartPlaceID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumn: "ArrangementID",
                keyValue: 7,
                column: "StartPlaceID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Arrangements",
                keyColumn: "ArrangementID",
                keyValue: 8,
                column: "StartPlaceID",
                value: 5);

            migrationBuilder.CreateIndex(
                name: "IX_UserArrangementsGroup_ArrangementGroupID",
                table: "UserArrangementsGroup",
                column: "ArrangementGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_ArrangementGroup_ArrangementID",
                table: "ArrangementGroup",
                column: "ArrangementID");

            migrationBuilder.AddForeignKey(
                name: "FK_ArrangementGroup_Arrangements_ArrangementID",
                table: "ArrangementGroup",
                column: "ArrangementID",
                principalTable: "Arrangements",
                principalColumn: "ArrangementID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserArrangementsGroup_ArrangementGroup_ArrangementGroupID",
                table: "UserArrangementsGroup",
                column: "ArrangementGroupID",
                principalTable: "ArrangementGroup",
                principalColumn: "ArrangementGroupID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserArrangementsGroup_Users_UserID",
                table: "UserArrangementsGroup",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
