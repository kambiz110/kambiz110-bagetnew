using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class postlee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "PostProducts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 780, DateTimeKind.Local).AddTicks(1053),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 26, 22, 7, 39, 170, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.AddColumn<int>(
                name: "PostalCompane",
                table: "PostProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 779, DateTimeKind.Local).AddTicks(8454),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 26, 22, 7, 39, 170, DateTimeKind.Local).AddTicks(5819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 779, DateTimeKind.Local).AddTicks(1351),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 26, 22, 7, 39, 169, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 779, DateTimeKind.Local).AddTicks(5811),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 26, 22, 7, 39, 170, DateTimeKind.Local).AddTicks(3134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 778, DateTimeKind.Local).AddTicks(6791),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 26, 22, 7, 39, 169, DateTimeKind.Local).AddTicks(2813));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 778, DateTimeKind.Local).AddTicks(4153),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 26, 22, 7, 39, 168, DateTimeKind.Local).AddTicks(9803));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 778, DateTimeKind.Local).AddTicks(1338),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 26, 22, 7, 39, 168, DateTimeKind.Local).AddTicks(6351));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 777, DateTimeKind.Local).AddTicks(1987),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 26, 22, 7, 39, 167, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 777, DateTimeKind.Local).AddTicks(9105),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 26, 22, 7, 39, 168, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 777, DateTimeKind.Local).AddTicks(7170),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 26, 22, 7, 39, 168, DateTimeKind.Local).AddTicks(1707));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 776, DateTimeKind.Local).AddTicks(8771),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 26, 22, 7, 39, 167, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 776, DateTimeKind.Local).AddTicks(6667),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 26, 22, 7, 39, 166, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 771, DateTimeKind.Local).AddTicks(3002),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 26, 22, 7, 39, 157, DateTimeKind.Local).AddTicks(5375));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 776, DateTimeKind.Local).AddTicks(4010),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 26, 22, 7, 39, 165, DateTimeKind.Local).AddTicks(7328));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostalCompane",
                table: "PostProducts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 26, 22, 7, 39, 170, DateTimeKind.Local).AddTicks(8322),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 780, DateTimeKind.Local).AddTicks(1053));

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "PostProducts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 26, 22, 7, 39, 170, DateTimeKind.Local).AddTicks(5819),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 779, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 26, 22, 7, 39, 169, DateTimeKind.Local).AddTicks(8104),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 779, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 26, 22, 7, 39, 170, DateTimeKind.Local).AddTicks(3134),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 779, DateTimeKind.Local).AddTicks(5811));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 26, 22, 7, 39, 169, DateTimeKind.Local).AddTicks(2813),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 778, DateTimeKind.Local).AddTicks(6791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 26, 22, 7, 39, 168, DateTimeKind.Local).AddTicks(9803),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 778, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 26, 22, 7, 39, 168, DateTimeKind.Local).AddTicks(6351),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 778, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 26, 22, 7, 39, 167, DateTimeKind.Local).AddTicks(5683),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 777, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 26, 22, 7, 39, 168, DateTimeKind.Local).AddTicks(3799),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 777, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 26, 22, 7, 39, 168, DateTimeKind.Local).AddTicks(1707),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 777, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 26, 22, 7, 39, 167, DateTimeKind.Local).AddTicks(1984),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 776, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 26, 22, 7, 39, 166, DateTimeKind.Local).AddTicks(9306),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 776, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 26, 22, 7, 39, 157, DateTimeKind.Local).AddTicks(5375),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 771, DateTimeKind.Local).AddTicks(3002));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 26, 22, 7, 39, 165, DateTimeKind.Local).AddTicks(7328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 776, DateTimeKind.Local).AddTicks(4010));
        }
    }
}
