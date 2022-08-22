using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class editadress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 572, DateTimeKind.Local).AddTicks(1054),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 13, 15, 10, 5, 247, DateTimeKind.Local).AddTicks(4885));

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "UserAddresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 571, DateTimeKind.Local).AddTicks(8932),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 13, 15, 10, 5, 247, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 571, DateTimeKind.Local).AddTicks(1458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 13, 15, 10, 5, 246, DateTimeKind.Local).AddTicks(697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 571, DateTimeKind.Local).AddTicks(6420),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 13, 15, 10, 5, 246, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 570, DateTimeKind.Local).AddTicks(4780),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 13, 15, 10, 5, 245, DateTimeKind.Local).AddTicks(3903));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 570, DateTimeKind.Local).AddTicks(2332),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 13, 15, 10, 5, 244, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 569, DateTimeKind.Local).AddTicks(9753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 13, 15, 10, 5, 244, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 568, DateTimeKind.Local).AddTicks(6028),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 13, 15, 10, 5, 242, DateTimeKind.Local).AddTicks(3640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 569, DateTimeKind.Local).AddTicks(7546),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 13, 15, 10, 5, 244, DateTimeKind.Local).AddTicks(1117));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 569, DateTimeKind.Local).AddTicks(4241),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 13, 15, 10, 5, 243, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 567, DateTimeKind.Local).AddTicks(7060),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 13, 15, 10, 5, 241, DateTimeKind.Local).AddTicks(7486));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 567, DateTimeKind.Local).AddTicks(2032),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 13, 15, 10, 5, 241, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 561, DateTimeKind.Local).AddTicks(5774),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 13, 15, 10, 5, 233, DateTimeKind.Local).AddTicks(6192));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 566, DateTimeKind.Local).AddTicks(9292),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 13, 15, 10, 5, 241, DateTimeKind.Local).AddTicks(12));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "UserAddresses");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 13, 15, 10, 5, 247, DateTimeKind.Local).AddTicks(4885),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 572, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 13, 15, 10, 5, 247, DateTimeKind.Local).AddTicks(1519),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 571, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 13, 15, 10, 5, 246, DateTimeKind.Local).AddTicks(697),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 571, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 13, 15, 10, 5, 246, DateTimeKind.Local).AddTicks(7573),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 571, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 13, 15, 10, 5, 245, DateTimeKind.Local).AddTicks(3903),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 570, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 13, 15, 10, 5, 244, DateTimeKind.Local).AddTicks(9670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 570, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 13, 15, 10, 5, 244, DateTimeKind.Local).AddTicks(4833),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 569, DateTimeKind.Local).AddTicks(9753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 13, 15, 10, 5, 242, DateTimeKind.Local).AddTicks(3640),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 568, DateTimeKind.Local).AddTicks(6028));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 13, 15, 10, 5, 244, DateTimeKind.Local).AddTicks(1117),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 569, DateTimeKind.Local).AddTicks(7546));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 13, 15, 10, 5, 243, DateTimeKind.Local).AddTicks(7940),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 569, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 13, 15, 10, 5, 241, DateTimeKind.Local).AddTicks(7486),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 567, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 13, 15, 10, 5, 241, DateTimeKind.Local).AddTicks(4119),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 567, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 13, 15, 10, 5, 233, DateTimeKind.Local).AddTicks(6192),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 561, DateTimeKind.Local).AddTicks(5774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 13, 15, 10, 5, 241, DateTimeKind.Local).AddTicks(12),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 22, 20, 17, 52, 566, DateTimeKind.Local).AddTicks(9292));
        }
    }
}
