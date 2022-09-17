using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class Comment4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 178, DateTimeKind.Local).AddTicks(3984),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 791, DateTimeKind.Local).AddTicks(6369));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 177, DateTimeKind.Local).AddTicks(9818),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 791, DateTimeKind.Local).AddTicks(2751));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 176, DateTimeKind.Local).AddTicks(2289),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 789, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 177, DateTimeKind.Local).AddTicks(3955),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 790, DateTimeKind.Local).AddTicks(7968));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 175, DateTimeKind.Local).AddTicks(2771),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 789, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 174, DateTimeKind.Local).AddTicks(7569),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 788, DateTimeKind.Local).AddTicks(6276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 174, DateTimeKind.Local).AddTicks(1563),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 788, DateTimeKind.Local).AddTicks(1417));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 172, DateTimeKind.Local).AddTicks(1451),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 786, DateTimeKind.Local).AddTicks(4655));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 173, DateTimeKind.Local).AddTicks(7091),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 787, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 173, DateTimeKind.Local).AddTicks(3245),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 787, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 171, DateTimeKind.Local).AddTicks(4288),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 785, DateTimeKind.Local).AddTicks(8908));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 171, DateTimeKind.Local).AddTicks(72),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 785, DateTimeKind.Local).AddTicks(5234));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 162, DateTimeKind.Local).AddTicks(2248),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 777, DateTimeKind.Local).AddTicks(5615));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 170, DateTimeKind.Local).AddTicks(4896),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 785, DateTimeKind.Local).AddTicks(807));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 791, DateTimeKind.Local).AddTicks(6369),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 178, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 791, DateTimeKind.Local).AddTicks(2751),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 177, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 789, DateTimeKind.Local).AddTicks(8394),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 176, DateTimeKind.Local).AddTicks(2289));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 790, DateTimeKind.Local).AddTicks(7968),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 177, DateTimeKind.Local).AddTicks(3955));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 789, DateTimeKind.Local).AddTicks(714),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 175, DateTimeKind.Local).AddTicks(2771));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 788, DateTimeKind.Local).AddTicks(6276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 174, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 788, DateTimeKind.Local).AddTicks(1417),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 174, DateTimeKind.Local).AddTicks(1563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 786, DateTimeKind.Local).AddTicks(4655),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 172, DateTimeKind.Local).AddTicks(1451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 787, DateTimeKind.Local).AddTicks(7694),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 173, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 787, DateTimeKind.Local).AddTicks(4405),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 173, DateTimeKind.Local).AddTicks(3245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 785, DateTimeKind.Local).AddTicks(8908),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 171, DateTimeKind.Local).AddTicks(4288));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 785, DateTimeKind.Local).AddTicks(5234),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 171, DateTimeKind.Local).AddTicks(72));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 777, DateTimeKind.Local).AddTicks(5615),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 162, DateTimeKind.Local).AddTicks(2248));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 785, DateTimeKind.Local).AddTicks(807),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 22, 53, 22, 170, DateTimeKind.Local).AddTicks(4896));
        }
    }
}
