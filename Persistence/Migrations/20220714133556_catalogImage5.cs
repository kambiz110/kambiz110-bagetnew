using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class catalogImage5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatalogType_CatalogTypeImages_CatalogTypeImageId",
                table: "CatalogType");

            migrationBuilder.DropIndex(
                name: "IX_CatalogType_CatalogTypeImageId",
                table: "CatalogType");

            migrationBuilder.DropColumn(
                name: "CatalogTypeImageId",
                table: "CatalogType");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 18, 5, 55, 404, DateTimeKind.Local).AddTicks(8166),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 32, 42, 276, DateTimeKind.Local).AddTicks(1556));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 18, 5, 55, 404, DateTimeKind.Local).AddTicks(2685),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 32, 42, 275, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 18, 5, 55, 402, DateTimeKind.Local).AddTicks(5447),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 32, 42, 274, DateTimeKind.Local).AddTicks(6537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 18, 5, 55, 403, DateTimeKind.Local).AddTicks(6186),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 32, 42, 275, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 18, 5, 55, 401, DateTimeKind.Local).AddTicks(4930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 32, 42, 274, DateTimeKind.Local).AddTicks(278));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 18, 5, 55, 400, DateTimeKind.Local).AddTicks(8322),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 32, 42, 273, DateTimeKind.Local).AddTicks(6356));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 18, 5, 55, 400, DateTimeKind.Local).AddTicks(1021),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 32, 42, 273, DateTimeKind.Local).AddTicks(2019));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 18, 5, 55, 397, DateTimeKind.Local).AddTicks(8754),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 32, 42, 271, DateTimeKind.Local).AddTicks(3630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 18, 5, 55, 399, DateTimeKind.Local).AddTicks(5561),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 32, 42, 272, DateTimeKind.Local).AddTicks(8411));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 18, 5, 55, 399, DateTimeKind.Local).AddTicks(975),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 32, 42, 272, DateTimeKind.Local).AddTicks(5216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 18, 5, 55, 397, DateTimeKind.Local).AddTicks(1325),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 32, 42, 270, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 18, 5, 55, 396, DateTimeKind.Local).AddTicks(6301),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 32, 42, 270, DateTimeKind.Local).AddTicks(5973));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 18, 5, 55, 359, DateTimeKind.Local).AddTicks(4804),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 32, 42, 258, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 18, 5, 55, 396, DateTimeKind.Local).AddTicks(22),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 32, 42, 270, DateTimeKind.Local).AddTicks(2092));

            migrationBuilder.CreateIndex(
                name: "IX_CatalogTypeImages_CatalogTypeId",
                table: "CatalogTypeImages",
                column: "CatalogTypeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogTypeImages_CatalogType_CatalogTypeId",
                table: "CatalogTypeImages",
                column: "CatalogTypeId",
                principalTable: "CatalogType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatalogTypeImages_CatalogType_CatalogTypeId",
                table: "CatalogTypeImages");

            migrationBuilder.DropIndex(
                name: "IX_CatalogTypeImages_CatalogTypeId",
                table: "CatalogTypeImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 32, 42, 276, DateTimeKind.Local).AddTicks(1556),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 18, 5, 55, 404, DateTimeKind.Local).AddTicks(8166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 32, 42, 275, DateTimeKind.Local).AddTicks(6633),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 18, 5, 55, 404, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 32, 42, 274, DateTimeKind.Local).AddTicks(6537),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 18, 5, 55, 402, DateTimeKind.Local).AddTicks(5447));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 32, 42, 275, DateTimeKind.Local).AddTicks(2517),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 18, 5, 55, 403, DateTimeKind.Local).AddTicks(6186));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 32, 42, 274, DateTimeKind.Local).AddTicks(278),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 18, 5, 55, 401, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 32, 42, 273, DateTimeKind.Local).AddTicks(6356),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 18, 5, 55, 400, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 32, 42, 273, DateTimeKind.Local).AddTicks(2019),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 18, 5, 55, 400, DateTimeKind.Local).AddTicks(1021));

            migrationBuilder.AddColumn<int>(
                name: "CatalogTypeImageId",
                table: "CatalogType",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 32, 42, 271, DateTimeKind.Local).AddTicks(3630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 18, 5, 55, 397, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 32, 42, 272, DateTimeKind.Local).AddTicks(8411),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 18, 5, 55, 399, DateTimeKind.Local).AddTicks(5561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 32, 42, 272, DateTimeKind.Local).AddTicks(5216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 18, 5, 55, 399, DateTimeKind.Local).AddTicks(975));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 32, 42, 270, DateTimeKind.Local).AddTicks(9159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 18, 5, 55, 397, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 32, 42, 270, DateTimeKind.Local).AddTicks(5973),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 18, 5, 55, 396, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 32, 42, 258, DateTimeKind.Local).AddTicks(7347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 18, 5, 55, 359, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 32, 42, 270, DateTimeKind.Local).AddTicks(2092),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 18, 5, 55, 396, DateTimeKind.Local).AddTicks(22));

            migrationBuilder.CreateIndex(
                name: "IX_CatalogType_CatalogTypeImageId",
                table: "CatalogType",
                column: "CatalogTypeImageId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogType_CatalogTypeImages_CatalogTypeImageId",
                table: "CatalogType",
                column: "CatalogTypeImageId",
                principalTable: "CatalogTypeImages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
