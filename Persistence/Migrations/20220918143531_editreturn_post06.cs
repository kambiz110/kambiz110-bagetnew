using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class editreturn_post06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 329, DateTimeKind.Local).AddTicks(4045));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 653, DateTimeKind.Local).AddTicks(6796),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 328, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 652, DateTimeKind.Local).AddTicks(2636),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 326, DateTimeKind.Local).AddTicks(4413));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 653, DateTimeKind.Local).AddTicks(1999),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 328, DateTimeKind.Local).AddTicks(766));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 651, DateTimeKind.Local).AddTicks(4850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 325, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 650, DateTimeKind.Local).AddTicks(7895),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 324, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 649, DateTimeKind.Local).AddTicks(1983),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 323, DateTimeKind.Local).AddTicks(5192));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 646, DateTimeKind.Local).AddTicks(6350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 320, DateTimeKind.Local).AddTicks(6114));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 648, DateTimeKind.Local).AddTicks(7151),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 322, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 648, DateTimeKind.Local).AddTicks(1719),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 322, DateTimeKind.Local).AddTicks(3064));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 646, DateTimeKind.Local).AddTicks(903),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 319, DateTimeKind.Local).AddTicks(4276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 645, DateTimeKind.Local).AddTicks(7448),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 318, DateTimeKind.Local).AddTicks(8497));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 635, DateTimeKind.Local).AddTicks(9762),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 307, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 645, DateTimeKind.Local).AddTicks(2711),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 318, DateTimeKind.Local).AddTicks(1878));

            migrationBuilder.AddForeignKey(
                name: "FK_ReturnedProducts_Returneds_ReturnedMyId",
                table: "ReturnedProducts",
                column: "ReturnedMyId",
                principalTable: "Returneds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                defaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 329, DateTimeKind.Local).AddTicks(4045),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 654, DateTimeKind.Local).AddTicks(297));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 328, DateTimeKind.Local).AddTicks(8276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 653, DateTimeKind.Local).AddTicks(6796));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 326, DateTimeKind.Local).AddTicks(4413),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 652, DateTimeKind.Local).AddTicks(2636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 328, DateTimeKind.Local).AddTicks(766),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 653, DateTimeKind.Local).AddTicks(1999));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 325, DateTimeKind.Local).AddTicks(1049),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 651, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 324, DateTimeKind.Local).AddTicks(3270),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 650, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 323, DateTimeKind.Local).AddTicks(5192),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 649, DateTimeKind.Local).AddTicks(1983));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 320, DateTimeKind.Local).AddTicks(6114),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 646, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 322, DateTimeKind.Local).AddTicks(9210),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 648, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 322, DateTimeKind.Local).AddTicks(3064),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 648, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 319, DateTimeKind.Local).AddTicks(4276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 646, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 318, DateTimeKind.Local).AddTicks(8497),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 645, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 307, DateTimeKind.Local).AddTicks(6659),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 5, 30, 635, DateTimeKind.Local).AddTicks(9762));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 318, DateTimeKind.Local).AddTicks(1878),
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
    }
}
