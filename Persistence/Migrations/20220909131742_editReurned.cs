using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class editReurned : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 322, DateTimeKind.Local).AddTicks(520),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 8, 11, 52, 47, 671, DateTimeKind.Local).AddTicks(5235));

            migrationBuilder.AddColumn<DateTime>(
                name: "ReturnedTime",
                table: "Returneds",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 321, DateTimeKind.Local).AddTicks(7048),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 8, 11, 52, 47, 671, DateTimeKind.Local).AddTicks(1488));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 320, DateTimeKind.Local).AddTicks(3199),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 8, 11, 52, 47, 669, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 321, DateTimeKind.Local).AddTicks(2322),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 8, 11, 52, 47, 670, DateTimeKind.Local).AddTicks(6515));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 319, DateTimeKind.Local).AddTicks(5548),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 8, 11, 52, 47, 668, DateTimeKind.Local).AddTicks(8492));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 319, DateTimeKind.Local).AddTicks(1323),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 8, 11, 52, 47, 668, DateTimeKind.Local).AddTicks(3262));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 318, DateTimeKind.Local).AddTicks(6758),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 8, 11, 52, 47, 667, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 317, DateTimeKind.Local).AddTicks(1081),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 8, 11, 52, 47, 666, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 318, DateTimeKind.Local).AddTicks(3099),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 8, 11, 52, 47, 667, DateTimeKind.Local).AddTicks(4245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 317, DateTimeKind.Local).AddTicks(9778),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 8, 11, 52, 47, 667, DateTimeKind.Local).AddTicks(789));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 316, DateTimeKind.Local).AddTicks(5777),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 8, 11, 52, 47, 665, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 316, DateTimeKind.Local).AddTicks(2358),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 8, 11, 52, 47, 665, DateTimeKind.Local).AddTicks(1589));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 308, DateTimeKind.Local).AddTicks(8440),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 8, 11, 52, 47, 658, DateTimeKind.Local).AddTicks(1402));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 315, DateTimeKind.Local).AddTicks(7991),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 8, 11, 52, 47, 664, DateTimeKind.Local).AddTicks(7279));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReturnedTime",
                table: "Returneds");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 11, 52, 47, 671, DateTimeKind.Local).AddTicks(5235),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 322, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 11, 52, 47, 671, DateTimeKind.Local).AddTicks(1488),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 321, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 11, 52, 47, 669, DateTimeKind.Local).AddTicks(6668),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 320, DateTimeKind.Local).AddTicks(3199));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 11, 52, 47, 670, DateTimeKind.Local).AddTicks(6515),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 321, DateTimeKind.Local).AddTicks(2322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 11, 52, 47, 668, DateTimeKind.Local).AddTicks(8492),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 319, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 11, 52, 47, 668, DateTimeKind.Local).AddTicks(3262),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 319, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 11, 52, 47, 667, DateTimeKind.Local).AddTicks(8180),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 318, DateTimeKind.Local).AddTicks(6758));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 11, 52, 47, 666, DateTimeKind.Local).AddTicks(1012),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 317, DateTimeKind.Local).AddTicks(1081));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 11, 52, 47, 667, DateTimeKind.Local).AddTicks(4245),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 318, DateTimeKind.Local).AddTicks(3099));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 11, 52, 47, 667, DateTimeKind.Local).AddTicks(789),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 317, DateTimeKind.Local).AddTicks(9778));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 11, 52, 47, 665, DateTimeKind.Local).AddTicks(5213),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 316, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 11, 52, 47, 665, DateTimeKind.Local).AddTicks(1589),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 316, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 11, 52, 47, 658, DateTimeKind.Local).AddTicks(1402),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 308, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 11, 52, 47, 664, DateTimeKind.Local).AddTicks(7279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 315, DateTimeKind.Local).AddTicks(7991));
        }
    }
}
