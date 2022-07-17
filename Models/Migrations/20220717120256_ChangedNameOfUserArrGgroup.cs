using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    public partial class ChangedNameOfUserArrGgroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserArrangementGroup_Users_UserID",
                table: "UserArrangementGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserArrangementGroup",
                table: "UserArrangementGroup");

            migrationBuilder.RenameTable(
                name: "UserArrangementGroup",
                newName: "UserArrangementGroups");

            migrationBuilder.RenameIndex(
                name: "IX_UserArrangementGroup_UserID",
                table: "UserArrangementGroups",
                newName: "IX_UserArrangementGroups_UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserArrangementGroups",
                table: "UserArrangementGroups",
                columns: new[] { "UserArrangementGroupID", "UserID", "ArrangementGroupID" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserArrangementGroups_Users_UserID",
                table: "UserArrangementGroups",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserArrangementGroups_Users_UserID",
                table: "UserArrangementGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserArrangementGroups",
                table: "UserArrangementGroups");

            migrationBuilder.RenameTable(
                name: "UserArrangementGroups",
                newName: "UserArrangementGroup");

            migrationBuilder.RenameIndex(
                name: "IX_UserArrangementGroups_UserID",
                table: "UserArrangementGroup",
                newName: "IX_UserArrangementGroup_UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserArrangementGroup",
                table: "UserArrangementGroup",
                columns: new[] { "UserArrangementGroupID", "UserID", "ArrangementGroupID" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserArrangementGroup_Users_UserID",
                table: "UserArrangementGroup",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
