using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class editreturn_post06_26 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Returneds_PostProducts_PostProductId",
                table: "Returneds");

            migrationBuilder.DropIndex(
                name: "IX_Returneds_PostProductId",
                table: "Returneds");

            migrationBuilder.DropIndex(
                name: "IX_ReturnedProducts_ReturnedId",
                table: "ReturnedProducts");

            migrationBuilder.DropColumn(
                name: "PostProductId",
                table: "Returneds");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 329, DateTimeKind.Local).AddTicks(4045),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 18, 7, 3, 506, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 328, DateTimeKind.Local).AddTicks(8276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 18, 7, 3, 506, DateTimeKind.Local).AddTicks(904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 326, DateTimeKind.Local).AddTicks(4413),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 18, 7, 3, 504, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 328, DateTimeKind.Local).AddTicks(766),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 18, 7, 3, 505, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 325, DateTimeKind.Local).AddTicks(1049),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 18, 7, 3, 504, DateTimeKind.Local).AddTicks(1595));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 324, DateTimeKind.Local).AddTicks(3270),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 18, 7, 3, 503, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 323, DateTimeKind.Local).AddTicks(5192),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 18, 7, 3, 503, DateTimeKind.Local).AddTicks(3571));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 320, DateTimeKind.Local).AddTicks(6114),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 18, 7, 3, 501, DateTimeKind.Local).AddTicks(9324));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 322, DateTimeKind.Local).AddTicks(9210),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 18, 7, 3, 503, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 322, DateTimeKind.Local).AddTicks(3064),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 18, 7, 3, 502, DateTimeKind.Local).AddTicks(7465));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 319, DateTimeKind.Local).AddTicks(4276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 18, 7, 3, 501, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 318, DateTimeKind.Local).AddTicks(8497),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 18, 7, 3, 501, DateTimeKind.Local).AddTicks(1401));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 307, DateTimeKind.Local).AddTicks(6659),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 18, 7, 3, 493, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 318, DateTimeKind.Local).AddTicks(1878),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 18, 7, 3, 500, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.CreateIndex(
                name: "IX_ReturnedProducts_ReturnedId",
                table: "ReturnedProducts",
                column: "ReturnedId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ReturnedProducts_ReturnedId",
                table: "ReturnedProducts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 18, 7, 3, 506, DateTimeKind.Local).AddTicks(3904),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 329, DateTimeKind.Local).AddTicks(4045));

            migrationBuilder.AddColumn<int>(
                name: "PostProductId",
                table: "Returneds",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 18, 7, 3, 506, DateTimeKind.Local).AddTicks(904),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 328, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 18, 7, 3, 504, DateTimeKind.Local).AddTicks(8347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 326, DateTimeKind.Local).AddTicks(4413));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 18, 7, 3, 505, DateTimeKind.Local).AddTicks(6672),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 328, DateTimeKind.Local).AddTicks(766));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 18, 7, 3, 504, DateTimeKind.Local).AddTicks(1595),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 325, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 18, 7, 3, 503, DateTimeKind.Local).AddTicks(7759),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 324, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 18, 7, 3, 503, DateTimeKind.Local).AddTicks(3571),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 323, DateTimeKind.Local).AddTicks(5192));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 18, 7, 3, 501, DateTimeKind.Local).AddTicks(9324),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 320, DateTimeKind.Local).AddTicks(6114));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 18, 7, 3, 503, DateTimeKind.Local).AddTicks(317),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 322, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 18, 7, 3, 502, DateTimeKind.Local).AddTicks(7465),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 322, DateTimeKind.Local).AddTicks(3064));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 18, 7, 3, 501, DateTimeKind.Local).AddTicks(4416),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 319, DateTimeKind.Local).AddTicks(4276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 18, 7, 3, 501, DateTimeKind.Local).AddTicks(1401),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 318, DateTimeKind.Local).AddTicks(8497));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 18, 7, 3, 493, DateTimeKind.Local).AddTicks(4341),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 307, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 18, 18, 7, 3, 500, DateTimeKind.Local).AddTicks(7520),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 18, 19, 0, 17, 318, DateTimeKind.Local).AddTicks(1878));

            migrationBuilder.CreateIndex(
                name: "IX_Returneds_PostProductId",
                table: "Returneds",
                column: "PostProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnedProducts_ReturnedId",
                table: "ReturnedProducts",
                column: "ReturnedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Returneds_PostProducts_PostProductId",
                table: "Returneds",
                column: "PostProductId",
                principalTable: "PostProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
