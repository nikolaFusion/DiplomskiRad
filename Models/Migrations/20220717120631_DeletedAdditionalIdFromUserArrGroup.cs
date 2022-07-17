using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    public partial class DeletedAdditionalIdFromUserArrGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserArrangementGroups",
                table: "UserArrangementGroups");

            migrationBuilder.DropIndex(
                name: "IX_UserArrangementGroups_UserID",
                table: "UserArrangementGroups");

            migrationBuilder.DropColumn(
                name: "UserArrangementGroupID",
                table: "UserArrangementGroups");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserArrangementGroups",
                table: "UserArrangementGroups",
                columns: new[] { "UserID", "ArrangementGroupID" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserArrangementGroups",
                table: "UserArrangementGroups");

            migrationBuilder.AddColumn<int>(
                name: "UserArrangementGroupID",
                table: "UserArrangementGroups",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserArrangementGroups",
                table: "UserArrangementGroups",
                columns: new[] { "UserArrangementGroupID", "UserID", "ArrangementGroupID" });

            migrationBuilder.CreateIndex(
                name: "IX_UserArrangementGroups_UserID",
                table: "UserArrangementGroups",
                column: "UserID");
        }
    }
}
