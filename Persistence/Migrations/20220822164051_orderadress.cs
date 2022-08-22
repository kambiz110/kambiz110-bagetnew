using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class orderadress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 21, 10, 50, 340, DateTimeKind.Local).AddTicks(4161),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 572, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 21, 10, 50, 340, DateTimeKind.Local).AddTicks(2136),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 571, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 21, 10, 50, 339, DateTimeKind.Local).AddTicks(5235),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 571, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.AddColumn<string>(
                name: "Address_PhoneNumber",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 21, 10, 50, 339, DateTimeKind.Local).AddTicks(9606),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 571, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 21, 10, 50, 339, DateTimeKind.Local).AddTicks(977),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 570, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 21, 10, 50, 338, DateTimeKind.Local).AddTicks(8356),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 570, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 21, 10, 50, 338, DateTimeKind.Local).AddTicks(5510),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 569, DateTimeKind.Local).AddTicks(9753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 21, 10, 50, 337, DateTimeKind.Local).AddTicks(6171),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 568, DateTimeKind.Local).AddTicks(6028));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 21, 10, 50, 338, DateTimeKind.Local).AddTicks(3104),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 569, DateTimeKind.Local).AddTicks(7546));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 21, 10, 50, 338, DateTimeKind.Local).AddTicks(1153),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 569, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 21, 10, 50, 337, DateTimeKind.Local).AddTicks(2832),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 567, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 21, 10, 50, 337, DateTimeKind.Local).AddTicks(715),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 567, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 21, 10, 50, 328, DateTimeKind.Local).AddTicks(8695),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 561, DateTimeKind.Local).AddTicks(5774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 21, 10, 50, 336, DateTimeKind.Local).AddTicks(7974),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 566, DateTimeKind.Local).AddTicks(9292));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address_PhoneNumber",
                table: "Orders");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 572, DateTimeKind.Local).AddTicks(1054),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 21, 10, 50, 340, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 571, DateTimeKind.Local).AddTicks(8932),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 21, 10, 50, 340, DateTimeKind.Local).AddTicks(2136));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 571, DateTimeKind.Local).AddTicks(1458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 21, 10, 50, 339, DateTimeKind.Local).AddTicks(5235));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 571, DateTimeKind.Local).AddTicks(6420),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 21, 10, 50, 339, DateTimeKind.Local).AddTicks(9606));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 570, DateTimeKind.Local).AddTicks(4780),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 21, 10, 50, 339, DateTimeKind.Local).AddTicks(977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 570, DateTimeKind.Local).AddTicks(2332),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 21, 10, 50, 338, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 569, DateTimeKind.Local).AddTicks(9753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 21, 10, 50, 338, DateTimeKind.Local).AddTicks(5510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 568, DateTimeKind.Local).AddTicks(6028),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 21, 10, 50, 337, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 569, DateTimeKind.Local).AddTicks(7546),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 21, 10, 50, 338, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 569, DateTimeKind.Local).AddTicks(4241),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 21, 10, 50, 338, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 567, DateTimeKind.Local).AddTicks(7060),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 21, 10, 50, 337, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 567, DateTimeKind.Local).AddTicks(2032),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 21, 10, 50, 337, DateTimeKind.Local).AddTicks(715));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 561, DateTimeKind.Local).AddTicks(5774),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 21, 10, 50, 328, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 566, DateTimeKind.Local).AddTicks(9292),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 21, 10, 50, 336, DateTimeKind.Local).AddTicks(7974));
        }
    }
}
