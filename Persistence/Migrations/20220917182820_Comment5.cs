using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class Comment5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_CatalogItems_PostId1",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_PostId1",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "PostId1",
                table: "Comments");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 58, 19, 426, DateTimeKind.Local).AddTicks(8534),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 178, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 58, 19, 426, DateTimeKind.Local).AddTicks(4271),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 177, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 58, 19, 424, DateTimeKind.Local).AddTicks(6812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 176, DateTimeKind.Local).AddTicks(2289));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 58, 19, 425, DateTimeKind.Local).AddTicks(8518),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 177, DateTimeKind.Local).AddTicks(3955));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 58, 19, 423, DateTimeKind.Local).AddTicks(7314),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 175, DateTimeKind.Local).AddTicks(2771));

            migrationBuilder.AlterColumn<int>(
                name: "PostId",
                table: "Comments",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 58, 19, 423, DateTimeKind.Local).AddTicks(2026),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 174, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 58, 19, 422, DateTimeKind.Local).AddTicks(6252),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 174, DateTimeKind.Local).AddTicks(1563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 58, 19, 420, DateTimeKind.Local).AddTicks(6830),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 172, DateTimeKind.Local).AddTicks(1451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 58, 19, 422, DateTimeKind.Local).AddTicks(1903),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 173, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 58, 19, 421, DateTimeKind.Local).AddTicks(8291),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 173, DateTimeKind.Local).AddTicks(3245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 58, 19, 419, DateTimeKind.Local).AddTicks(9981),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 171, DateTimeKind.Local).AddTicks(4288));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 58, 19, 419, DateTimeKind.Local).AddTicks(5619),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 171, DateTimeKind.Local).AddTicks(72));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 58, 19, 414, DateTimeKind.Local).AddTicks(693),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 162, DateTimeKind.Local).AddTicks(2248));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 58, 19, 419, DateTimeKind.Local).AddTicks(2512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 170, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_CatalogItems_PostId",
                table: "Comments",
                column: "PostId",
                principalTable: "CatalogItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_CatalogItems_PostId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_PostId",
                table: "Comments");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 178, DateTimeKind.Local).AddTicks(3984),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 58, 19, 426, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 177, DateTimeKind.Local).AddTicks(9818),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 58, 19, 426, DateTimeKind.Local).AddTicks(4271));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 176, DateTimeKind.Local).AddTicks(2289),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 58, 19, 424, DateTimeKind.Local).AddTicks(6812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 177, DateTimeKind.Local).AddTicks(3955),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 58, 19, 425, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 175, DateTimeKind.Local).AddTicks(2771),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 58, 19, 423, DateTimeKind.Local).AddTicks(7314));

            migrationBuilder.AlterColumn<long>(
                name: "PostId",
                table: "Comments",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "PostId1",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 174, DateTimeKind.Local).AddTicks(7569),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 58, 19, 423, DateTimeKind.Local).AddTicks(2026));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 174, DateTimeKind.Local).AddTicks(1563),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 58, 19, 422, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 172, DateTimeKind.Local).AddTicks(1451),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 58, 19, 420, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 173, DateTimeKind.Local).AddTicks(7091),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 58, 19, 422, DateTimeKind.Local).AddTicks(1903));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 173, DateTimeKind.Local).AddTicks(3245),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 58, 19, 421, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 171, DateTimeKind.Local).AddTicks(4288),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 58, 19, 419, DateTimeKind.Local).AddTicks(9981));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 171, DateTimeKind.Local).AddTicks(72),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 58, 19, 419, DateTimeKind.Local).AddTicks(5619));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 162, DateTimeKind.Local).AddTicks(2248),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 58, 19, 414, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 170, DateTimeKind.Local).AddTicks(4896),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 58, 19, 419, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId1",
                table: "Comments",
                column: "PostId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_CatalogItems_PostId1",
                table: "Comments",
                column: "PostId1",
                principalTable: "CatalogItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
