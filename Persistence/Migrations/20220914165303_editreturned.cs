using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class editreturned : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 14, 21, 23, 2, 412, DateTimeKind.Local).AddTicks(5151),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 21, 19, 57, 497, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.AddColumn<string>(
                name: "FollowKey",
                table: "Returneds",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 14, 21, 23, 2, 412, DateTimeKind.Local).AddTicks(2495),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 21, 19, 57, 497, DateTimeKind.Local).AddTicks(10));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 14, 21, 23, 2, 411, DateTimeKind.Local).AddTicks(3171),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 21, 19, 57, 495, DateTimeKind.Local).AddTicks(3067));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 14, 21, 23, 2, 411, DateTimeKind.Local).AddTicks(9415),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 21, 19, 57, 496, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 14, 21, 23, 2, 410, DateTimeKind.Local).AddTicks(7828),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 21, 19, 57, 494, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 14, 21, 23, 2, 410, DateTimeKind.Local).AddTicks(4687),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 21, 19, 57, 494, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 14, 21, 23, 2, 410, DateTimeKind.Local).AddTicks(1453),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 21, 19, 57, 493, DateTimeKind.Local).AddTicks(7535));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 14, 21, 23, 2, 407, DateTimeKind.Local).AddTicks(7904),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 21, 19, 57, 492, DateTimeKind.Local).AddTicks(3723));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 14, 21, 23, 2, 409, DateTimeKind.Local).AddTicks(6911),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 21, 19, 57, 493, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 14, 21, 23, 2, 409, DateTimeKind.Local).AddTicks(3442),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 21, 19, 57, 493, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 14, 21, 23, 2, 406, DateTimeKind.Local).AddTicks(8660),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 21, 19, 57, 491, DateTimeKind.Local).AddTicks(7080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 14, 21, 23, 2, 406, DateTimeKind.Local).AddTicks(2569),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 21, 19, 57, 491, DateTimeKind.Local).AddTicks(3124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 14, 21, 23, 2, 398, DateTimeKind.Local).AddTicks(4905),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 21, 19, 57, 481, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 14, 21, 23, 2, 405, DateTimeKind.Local).AddTicks(8379),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 21, 19, 57, 490, DateTimeKind.Local).AddTicks(8045));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FollowKey",
                table: "Returneds");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 21, 19, 57, 497, DateTimeKind.Local).AddTicks(4267),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 14, 21, 23, 2, 412, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 21, 19, 57, 497, DateTimeKind.Local).AddTicks(10),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 14, 21, 23, 2, 412, DateTimeKind.Local).AddTicks(2495));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 21, 19, 57, 495, DateTimeKind.Local).AddTicks(3067),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 14, 21, 23, 2, 411, DateTimeKind.Local).AddTicks(3171));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 21, 19, 57, 496, DateTimeKind.Local).AddTicks(4830),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 14, 21, 23, 2, 411, DateTimeKind.Local).AddTicks(9415));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 21, 19, 57, 494, DateTimeKind.Local).AddTicks(4153),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 14, 21, 23, 2, 410, DateTimeKind.Local).AddTicks(7828));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 21, 19, 57, 494, DateTimeKind.Local).AddTicks(518),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 14, 21, 23, 2, 410, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 21, 19, 57, 493, DateTimeKind.Local).AddTicks(7535),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 14, 21, 23, 2, 410, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 21, 19, 57, 492, DateTimeKind.Local).AddTicks(3723),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 14, 21, 23, 2, 407, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 21, 19, 57, 493, DateTimeKind.Local).AddTicks(5175),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 14, 21, 23, 2, 409, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 21, 19, 57, 493, DateTimeKind.Local).AddTicks(3107),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 14, 21, 23, 2, 409, DateTimeKind.Local).AddTicks(3442));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 21, 19, 57, 491, DateTimeKind.Local).AddTicks(7080),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 14, 21, 23, 2, 406, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 21, 19, 57, 491, DateTimeKind.Local).AddTicks(3124),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 14, 21, 23, 2, 406, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 21, 19, 57, 481, DateTimeKind.Local).AddTicks(8360),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 14, 21, 23, 2, 398, DateTimeKind.Local).AddTicks(4905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 21, 19, 57, 490, DateTimeKind.Local).AddTicks(8045),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 14, 21, 23, 2, 405, DateTimeKind.Local).AddTicks(8379));
        }
    }
}
