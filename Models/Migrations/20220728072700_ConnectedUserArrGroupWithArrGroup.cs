using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    public partial class ConnectedUserArrGroupWithArrGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_UserArrangementGroups_ArrangementGroupID",
                table: "UserArrangementGroups",
                column: "ArrangementGroupID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserArrangementGroups_ArrangementGroups_ArrangementGroupID",
                table: "UserArrangementGroups",
                column: "ArrangementGroupID",
                principalTable: "ArrangementGroups",
                principalColumn: "ArrangementGroupID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserArrangementGroups_ArrangementGroups_ArrangementGroupID",
                table: "UserArrangementGroups");

            migrationBuilder.DropIndex(
                name: "IX_UserArrangementGroups_ArrangementGroupID",
                table: "UserArrangementGroups");
        }
    }
}
