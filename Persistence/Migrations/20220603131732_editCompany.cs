using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class editCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 6, 17, 31, 725, DateTimeKind.Local).AddTicks(7890),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 925, DateTimeKind.Local).AddTicks(3167));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 6, 17, 31, 725, DateTimeKind.Local).AddTicks(5906),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 925, DateTimeKind.Local).AddTicks(962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 6, 17, 31, 724, DateTimeKind.Local).AddTicks(9567),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 924, DateTimeKind.Local).AddTicks(4653));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 6, 17, 31, 725, DateTimeKind.Local).AddTicks(3566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 924, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 6, 17, 31, 724, DateTimeKind.Local).AddTicks(5725),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 924, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 6, 17, 31, 724, DateTimeKind.Local).AddTicks(2846),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 923, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 6, 17, 31, 723, DateTimeKind.Local).AddTicks(2491),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 921, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 6, 17, 31, 724, DateTimeKind.Local).AddTicks(614),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 923, DateTimeKind.Local).AddTicks(3171));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 6, 17, 31, 723, DateTimeKind.Local).AddTicks(8474),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 922, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 6, 17, 31, 723, DateTimeKind.Local).AddTicks(6516),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 922, DateTimeKind.Local).AddTicks(6826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 6, 17, 31, 723, DateTimeKind.Local).AddTicks(123),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 921, DateTimeKind.Local).AddTicks(2382));

            migrationBuilder.AddColumn<bool>(
                name: "IsDakely",
                table: "CatalogCompanes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 6, 17, 31, 722, DateTimeKind.Local).AddTicks(8310),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 920, DateTimeKind.Local).AddTicks(9485));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 6, 17, 31, 715, DateTimeKind.Local).AddTicks(5183),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 910, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 6, 17, 31, 722, DateTimeKind.Local).AddTicks(5855),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 920, DateTimeKind.Local).AddTicks(5726));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDakely",
                table: "CatalogCompanes");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 925, DateTimeKind.Local).AddTicks(3167),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 6, 17, 31, 725, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 925, DateTimeKind.Local).AddTicks(962),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 6, 17, 31, 725, DateTimeKind.Local).AddTicks(5906));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 924, DateTimeKind.Local).AddTicks(4653),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 6, 17, 31, 724, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 924, DateTimeKind.Local).AddTicks(8458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 6, 17, 31, 725, DateTimeKind.Local).AddTicks(3566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 924, DateTimeKind.Local).AddTicks(768),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 6, 17, 31, 724, DateTimeKind.Local).AddTicks(5725));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 923, DateTimeKind.Local).AddTicks(6580),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 6, 17, 31, 724, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 921, DateTimeKind.Local).AddTicks(7319),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 6, 17, 31, 723, DateTimeKind.Local).AddTicks(2491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 923, DateTimeKind.Local).AddTicks(3171),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 6, 17, 31, 724, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 922, DateTimeKind.Local).AddTicks(9891),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 6, 17, 31, 723, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 922, DateTimeKind.Local).AddTicks(6826),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 6, 17, 31, 723, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 921, DateTimeKind.Local).AddTicks(2382),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 6, 17, 31, 723, DateTimeKind.Local).AddTicks(123));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 920, DateTimeKind.Local).AddTicks(9485),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 6, 17, 31, 722, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 910, DateTimeKind.Local).AddTicks(5724),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 6, 17, 31, 715, DateTimeKind.Local).AddTicks(5183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 920, DateTimeKind.Local).AddTicks(5726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 6, 17, 31, 722, DateTimeKind.Local).AddTicks(5855));
        }
    }
}
