using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class editItemCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 6, 13, 36, 36, 636, DateTimeKind.Local).AddTicks(2559),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 209, DateTimeKind.Local).AddTicks(5665));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 6, 13, 36, 36, 635, DateTimeKind.Local).AddTicks(5961),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 208, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 6, 13, 36, 36, 634, DateTimeKind.Local).AddTicks(4367),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 207, DateTimeKind.Local).AddTicks(5701));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 6, 13, 36, 36, 635, DateTimeKind.Local).AddTicks(1609),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 208, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 6, 13, 36, 36, 633, DateTimeKind.Local).AddTicks(7047),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 206, DateTimeKind.Local).AddTicks(7377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 6, 13, 36, 36, 633, DateTimeKind.Local).AddTicks(1514),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 206, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 6, 13, 36, 36, 631, DateTimeKind.Local).AddTicks(1215),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 203, DateTimeKind.Local).AddTicks(9035));

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "CatalogItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 6, 13, 36, 36, 632, DateTimeKind.Local).AddTicks(7261),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 205, DateTimeKind.Local).AddTicks(6562));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 6, 13, 36, 36, 632, DateTimeKind.Local).AddTicks(3324),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 205, DateTimeKind.Local).AddTicks(2028));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 6, 13, 36, 36, 631, DateTimeKind.Local).AddTicks(9811),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 204, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 6, 13, 36, 36, 630, DateTimeKind.Local).AddTicks(5751),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 203, DateTimeKind.Local).AddTicks(4986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 6, 13, 36, 36, 630, DateTimeKind.Local).AddTicks(2028),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 203, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 6, 13, 36, 36, 619, DateTimeKind.Local).AddTicks(4513),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 189, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 6, 13, 36, 36, 629, DateTimeKind.Local).AddTicks(7538),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 202, DateTimeKind.Local).AddTicks(8687));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slug",
                table: "CatalogItems");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 209, DateTimeKind.Local).AddTicks(5665),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 6, 13, 36, 36, 636, DateTimeKind.Local).AddTicks(2559));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 208, DateTimeKind.Local).AddTicks(8757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 6, 13, 36, 36, 635, DateTimeKind.Local).AddTicks(5961));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 207, DateTimeKind.Local).AddTicks(5701),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 6, 13, 36, 36, 634, DateTimeKind.Local).AddTicks(4367));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 208, DateTimeKind.Local).AddTicks(3869),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 6, 13, 36, 36, 635, DateTimeKind.Local).AddTicks(1609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 206, DateTimeKind.Local).AddTicks(7377),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 6, 13, 36, 36, 633, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 206, DateTimeKind.Local).AddTicks(1330),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 6, 13, 36, 36, 633, DateTimeKind.Local).AddTicks(1514));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 203, DateTimeKind.Local).AddTicks(9035),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 6, 13, 36, 36, 631, DateTimeKind.Local).AddTicks(1215));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 205, DateTimeKind.Local).AddTicks(6562),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 6, 13, 36, 36, 632, DateTimeKind.Local).AddTicks(7261));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 205, DateTimeKind.Local).AddTicks(2028),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 6, 13, 36, 36, 632, DateTimeKind.Local).AddTicks(3324));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 204, DateTimeKind.Local).AddTicks(8103),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 6, 13, 36, 36, 631, DateTimeKind.Local).AddTicks(9811));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 203, DateTimeKind.Local).AddTicks(4986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 6, 13, 36, 36, 630, DateTimeKind.Local).AddTicks(5751));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 203, DateTimeKind.Local).AddTicks(2215),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 6, 13, 36, 36, 630, DateTimeKind.Local).AddTicks(2028));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 189, DateTimeKind.Local).AddTicks(4792),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 6, 13, 36, 36, 619, DateTimeKind.Local).AddTicks(4513));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 202, DateTimeKind.Local).AddTicks(8687),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 6, 13, 36, 36, 629, DateTimeKind.Local).AddTicks(7538));
        }
    }
}
