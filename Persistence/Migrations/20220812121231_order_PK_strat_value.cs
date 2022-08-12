using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class order_PK_strat_value : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 12, 16, 42, 30, 674, DateTimeKind.Local).AddTicks(7305),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 9, 16, 57, 53, 116, DateTimeKind.Local).AddTicks(7581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 12, 16, 42, 30, 674, DateTimeKind.Local).AddTicks(4118),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 9, 16, 57, 53, 116, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3419),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 9, 16, 57, 53, 115, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "3030, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 12, 16, 42, 30, 674, DateTimeKind.Local).AddTicks(163),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 9, 16, 57, 53, 116, DateTimeKind.Local).AddTicks(3052));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 12, 16, 42, 30, 672, DateTimeKind.Local).AddTicks(6933),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 9, 16, 57, 53, 115, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 12, 16, 42, 30, 672, DateTimeKind.Local).AddTicks(2968),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 9, 16, 57, 53, 115, DateTimeKind.Local).AddTicks(2618));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 12, 16, 42, 30, 671, DateTimeKind.Local).AddTicks(8419),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 9, 16, 57, 53, 114, DateTimeKind.Local).AddTicks(9946));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 12, 16, 42, 30, 670, DateTimeKind.Local).AddTicks(3709),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 9, 16, 57, 53, 114, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 12, 16, 42, 30, 671, DateTimeKind.Local).AddTicks(4845),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 9, 16, 57, 53, 114, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 12, 16, 42, 30, 671, DateTimeKind.Local).AddTicks(1642),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 9, 16, 57, 53, 114, DateTimeKind.Local).AddTicks(6008));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 12, 16, 42, 30, 669, DateTimeKind.Local).AddTicks(8744),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 9, 16, 57, 53, 113, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 12, 16, 42, 30, 669, DateTimeKind.Local).AddTicks(5352),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 9, 16, 57, 53, 113, DateTimeKind.Local).AddTicks(6138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 12, 16, 42, 30, 661, DateTimeKind.Local).AddTicks(1104),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 9, 16, 57, 53, 105, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 12, 16, 42, 30, 669, DateTimeKind.Local).AddTicks(1074),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 9, 16, 57, 53, 113, DateTimeKind.Local).AddTicks(3478));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 9, 16, 57, 53, 116, DateTimeKind.Local).AddTicks(7581),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 12, 16, 42, 30, 674, DateTimeKind.Local).AddTicks(7305));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 9, 16, 57, 53, 116, DateTimeKind.Local).AddTicks(5435),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 12, 16, 42, 30, 674, DateTimeKind.Local).AddTicks(4118));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 9, 16, 57, 53, 115, DateTimeKind.Local).AddTicks(9063),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3419));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "3030, 1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 9, 16, 57, 53, 116, DateTimeKind.Local).AddTicks(3052),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 12, 16, 42, 30, 674, DateTimeKind.Local).AddTicks(163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 9, 16, 57, 53, 115, DateTimeKind.Local).AddTicks(5086),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 12, 16, 42, 30, 672, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 9, 16, 57, 53, 115, DateTimeKind.Local).AddTicks(2618),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 12, 16, 42, 30, 672, DateTimeKind.Local).AddTicks(2968));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 9, 16, 57, 53, 114, DateTimeKind.Local).AddTicks(9946),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 12, 16, 42, 30, 671, DateTimeKind.Local).AddTicks(8419));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 9, 16, 57, 53, 114, DateTimeKind.Local).AddTicks(1203),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 12, 16, 42, 30, 670, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 9, 16, 57, 53, 114, DateTimeKind.Local).AddTicks(7837),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 12, 16, 42, 30, 671, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 9, 16, 57, 53, 114, DateTimeKind.Local).AddTicks(6008),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 12, 16, 42, 30, 671, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 9, 16, 57, 53, 113, DateTimeKind.Local).AddTicks(8128),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 12, 16, 42, 30, 669, DateTimeKind.Local).AddTicks(8744));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 9, 16, 57, 53, 113, DateTimeKind.Local).AddTicks(6138),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 12, 16, 42, 30, 669, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 9, 16, 57, 53, 105, DateTimeKind.Local).AddTicks(6604),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 12, 16, 42, 30, 661, DateTimeKind.Local).AddTicks(1104));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 9, 16, 57, 53, 113, DateTimeKind.Local).AddTicks(3478),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 12, 16, 42, 30, 669, DateTimeKind.Local).AddTicks(1074));
        }
    }
}
