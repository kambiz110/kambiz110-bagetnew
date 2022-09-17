using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class Comment3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 791, DateTimeKind.Local).AddTicks(6369),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 848, DateTimeKind.Local).AddTicks(7859));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 791, DateTimeKind.Local).AddTicks(2751),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 848, DateTimeKind.Local).AddTicks(1845));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 789, DateTimeKind.Local).AddTicks(8394),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 845, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 790, DateTimeKind.Local).AddTicks(7968),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 847, DateTimeKind.Local).AddTicks(4061));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 789, DateTimeKind.Local).AddTicks(714),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 844, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.AlterColumn<string>(
                name: "ConfirmedUserId",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 788, DateTimeKind.Local).AddTicks(6276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 843, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 788, DateTimeKind.Local).AddTicks(1417),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 843, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 786, DateTimeKind.Local).AddTicks(4655),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 841, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 787, DateTimeKind.Local).AddTicks(7694),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 843, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 787, DateTimeKind.Local).AddTicks(4405),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 842, DateTimeKind.Local).AddTicks(7917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 785, DateTimeKind.Local).AddTicks(8908),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 841, DateTimeKind.Local).AddTicks(2592));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 785, DateTimeKind.Local).AddTicks(5234),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 840, DateTimeKind.Local).AddTicks(9044));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 777, DateTimeKind.Local).AddTicks(5615),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 831, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 785, DateTimeKind.Local).AddTicks(807),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 840, DateTimeKind.Local).AddTicks(4582));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 848, DateTimeKind.Local).AddTicks(7859),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 791, DateTimeKind.Local).AddTicks(6369));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 848, DateTimeKind.Local).AddTicks(1845),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 791, DateTimeKind.Local).AddTicks(2751));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 845, DateTimeKind.Local).AddTicks(7370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 789, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 847, DateTimeKind.Local).AddTicks(4061),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 790, DateTimeKind.Local).AddTicks(7968));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 844, DateTimeKind.Local).AddTicks(3561),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 789, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.AlterColumn<long>(
                name: "ConfirmedUserId",
                table: "Comments",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 843, DateTimeKind.Local).AddTicks(9456),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 788, DateTimeKind.Local).AddTicks(6276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 843, DateTimeKind.Local).AddTicks(4477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 788, DateTimeKind.Local).AddTicks(1417));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 841, DateTimeKind.Local).AddTicks(8289),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 786, DateTimeKind.Local).AddTicks(4655));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 843, DateTimeKind.Local).AddTicks(968),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 787, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 842, DateTimeKind.Local).AddTicks(7917),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 787, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 841, DateTimeKind.Local).AddTicks(2592),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 785, DateTimeKind.Local).AddTicks(8908));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 840, DateTimeKind.Local).AddTicks(9044),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 785, DateTimeKind.Local).AddTicks(5234));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 831, DateTimeKind.Local).AddTicks(7471),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 777, DateTimeKind.Local).AddTicks(5615));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 840, DateTimeKind.Local).AddTicks(4582),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 51, 22, 785, DateTimeKind.Local).AddTicks(807));
        }
    }
}
