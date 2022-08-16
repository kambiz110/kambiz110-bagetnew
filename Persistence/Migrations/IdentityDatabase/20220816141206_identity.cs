using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations.IdentityDatabase
{
    public partial class identity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                schema: "identity",
                table: "UserTokens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                schema: "identity",
                table: "UserTokens",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                schema: "identity",
                table: "UserRoles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                schema: "identity",
                table: "UserLogins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                schema: "identity",
                table: "UserClaims",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                schema: "identity",
                table: "RoleClaims",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_UserTokens_UserId1",
                schema: "identity",
                table: "UserTokens",
                column: "UserId1",
                unique: true,
                filter: "[UserId1] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserId",
                schema: "identity",
                table: "UserRoles",
                column: "UserId",
                principalSchema: "identity",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTokens_Users_UserId1",
                schema: "identity",
                table: "UserTokens",
                column: "UserId1",
                principalSchema: "identity",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserId",
                schema: "identity",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTokens_Users_UserId1",
                schema: "identity",
                table: "UserTokens");

            migrationBuilder.DropIndex(
                name: "IX_UserTokens_UserId1",
                schema: "identity",
                table: "UserTokens");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                schema: "identity",
                table: "UserTokens");

            migrationBuilder.DropColumn(
                name: "UserId1",
                schema: "identity",
                table: "UserTokens");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                schema: "identity",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                schema: "identity",
                table: "UserLogins");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                schema: "identity",
                table: "UserClaims");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                schema: "identity",
                table: "RoleClaims");
        }
    }
}
