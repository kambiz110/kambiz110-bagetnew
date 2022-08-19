using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations.IdentityDatabase
{
    public partial class role2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RoleId1",
                schema: "identity",
                table: "UserRoles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId1",
                schema: "identity",
                table: "UserRoles",
                column: "RoleId1",
                unique: true,
                filter: "[RoleId1] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Roles_RoleId1",
                schema: "identity",
                table: "UserRoles",
                column: "RoleId1",
                principalSchema: "identity",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Roles_RoleId1",
                schema: "identity",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_RoleId1",
                schema: "identity",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "RoleId1",
                schema: "identity",
                table: "UserRoles");
        }
    }
}
