using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class editreturn_post066 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReturnedProducts_Returneds_ReturnedMyId",
                table: "ReturnedProducts");

            migrationBuilder.RenameColumn(
                name: "ReturnedMyId",
                table: "ReturnedProducts",
                newName: "ReturnedId");

            migrationBuilder.RenameIndex(
                name: "IX_ReturnedProducts_ReturnedMyId",
                table: "ReturnedProducts",
                newName: "IX_ReturnedProducts_ReturnedId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 12, 39, 930, DateTimeKind.Local).AddTicks(3702),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 654, DateTimeKind.Local).AddTicks(297));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 12, 39, 930, DateTimeKind.Local).AddTicks(166),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 653, DateTimeKind.Local).AddTicks(6796));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 12, 39, 928, DateTimeKind.Local).AddTicks(6042),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 652, DateTimeKind.Local).AddTicks(2636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 12, 39, 929, DateTimeKind.Local).AddTicks(5414),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 653, DateTimeKind.Local).AddTicks(1999));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 12, 39, 927, DateTimeKind.Local).AddTicks(8151),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 651, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 12, 39, 927, DateTimeKind.Local).AddTicks(3562),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 650, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 12, 39, 926, DateTimeKind.Local).AddTicks(8825),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 649, DateTimeKind.Local).AddTicks(1983));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 12, 39, 925, DateTimeKind.Local).AddTicks(2402),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 646, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 12, 39, 926, DateTimeKind.Local).AddTicks(5055),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 648, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 12, 39, 926, DateTimeKind.Local).AddTicks(1977),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 648, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 12, 39, 924, DateTimeKind.Local).AddTicks(6832),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 646, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 12, 39, 924, DateTimeKind.Local).AddTicks(3365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 645, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 12, 39, 914, DateTimeKind.Local).AddTicks(8964),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 635, DateTimeKind.Local).AddTicks(9762));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 12, 39, 923, DateTimeKind.Local).AddTicks(8783),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 645, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.AddForeignKey(
                name: "FK_ReturnedProducts_Returneds_ReturnedId",
                table: "ReturnedProducts",
                column: "ReturnedId",
                principalTable: "Returneds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReturnedProducts_Returneds_ReturnedId",
                table: "ReturnedProducts");

            migrationBuilder.RenameColumn(
                name: "ReturnedId",
                table: "ReturnedProducts",
                newName: "ReturnedMyId");

            migrationBuilder.RenameIndex(
                name: "IX_ReturnedProducts_ReturnedId",
                table: "ReturnedProducts",
                newName: "IX_ReturnedProducts_ReturnedMyId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 654, DateTimeKind.Local).AddTicks(297),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 12, 39, 930, DateTimeKind.Local).AddTicks(3702));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 653, DateTimeKind.Local).AddTicks(6796),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 12, 39, 930, DateTimeKind.Local).AddTicks(166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 652, DateTimeKind.Local).AddTicks(2636),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 12, 39, 928, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 653, DateTimeKind.Local).AddTicks(1999),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 12, 39, 929, DateTimeKind.Local).AddTicks(5414));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 651, DateTimeKind.Local).AddTicks(4850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 12, 39, 927, DateTimeKind.Local).AddTicks(8151));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 650, DateTimeKind.Local).AddTicks(7895),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 12, 39, 927, DateTimeKind.Local).AddTicks(3562));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 649, DateTimeKind.Local).AddTicks(1983),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 12, 39, 926, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 646, DateTimeKind.Local).AddTicks(6350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 12, 39, 925, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 648, DateTimeKind.Local).AddTicks(7151),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 12, 39, 926, DateTimeKind.Local).AddTicks(5055));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 648, DateTimeKind.Local).AddTicks(1719),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 12, 39, 926, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 646, DateTimeKind.Local).AddTicks(903),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 12, 39, 924, DateTimeKind.Local).AddTicks(6832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 645, DateTimeKind.Local).AddTicks(7448),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 12, 39, 924, DateTimeKind.Local).AddTicks(3365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 635, DateTimeKind.Local).AddTicks(9762),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 12, 39, 914, DateTimeKind.Local).AddTicks(8964));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 645, DateTimeKind.Local).AddTicks(2711),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 12, 39, 923, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.AddForeignKey(
                name: "FK_ReturnedProducts_Returneds_ReturnedMyId",
                table: "ReturnedProducts",
                column: "ReturnedMyId",
                principalTable: "Returneds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
