using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class editreturnedd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReturnedTime",
                table: "Returneds");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 21, 30, 57, 266, DateTimeKind.Local).AddTicks(8001),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 322, DateTimeKind.Local).AddTicks(520));

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
                defaultValue: new DateTime(2022, 9, 9, 21, 30, 57, 266, DateTimeKind.Local).AddTicks(4516),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 321, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 21, 30, 57, 265, DateTimeKind.Local).AddTicks(568),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 320, DateTimeKind.Local).AddTicks(3199));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 21, 30, 57, 265, DateTimeKind.Local).AddTicks(9002),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 321, DateTimeKind.Local).AddTicks(2322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 21, 30, 57, 264, DateTimeKind.Local).AddTicks(3210),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 319, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 21, 30, 57, 263, DateTimeKind.Local).AddTicks(9074),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 319, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 21, 30, 57, 263, DateTimeKind.Local).AddTicks(4494),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 318, DateTimeKind.Local).AddTicks(6758));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 21, 30, 57, 261, DateTimeKind.Local).AddTicks(9599),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 317, DateTimeKind.Local).AddTicks(1081));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 21, 30, 57, 263, DateTimeKind.Local).AddTicks(962),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 318, DateTimeKind.Local).AddTicks(3099));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 21, 30, 57, 262, DateTimeKind.Local).AddTicks(7888),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 317, DateTimeKind.Local).AddTicks(9778));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 21, 30, 57, 261, DateTimeKind.Local).AddTicks(4524),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 316, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 21, 30, 57, 261, DateTimeKind.Local).AddTicks(1072),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 316, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 21, 30, 57, 251, DateTimeKind.Local).AddTicks(4837),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 308, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 21, 30, 57, 260, DateTimeKind.Local).AddTicks(6995),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 315, DateTimeKind.Local).AddTicks(7991));

            migrationBuilder.CreateIndex(
                name: "IX_Returneds_PostProductId",
                table: "Returneds",
                column: "PostProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Returneds_PostProducts_PostProductId",
                table: "Returneds",
                column: "PostProductId",
                principalTable: "PostProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Returneds_PostProducts_PostProductId",
                table: "Returneds");

            migrationBuilder.DropIndex(
                name: "IX_Returneds_PostProductId",
                table: "Returneds");

            migrationBuilder.DropColumn(
                name: "PostProductId",
                table: "Returneds");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 322, DateTimeKind.Local).AddTicks(520),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 21, 30, 57, 266, DateTimeKind.Local).AddTicks(8001));

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
                oldDefaultValue: new DateTime(2022, 9, 9, 21, 30, 57, 266, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 320, DateTimeKind.Local).AddTicks(3199),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 21, 30, 57, 265, DateTimeKind.Local).AddTicks(568));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 321, DateTimeKind.Local).AddTicks(2322),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 21, 30, 57, 265, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 319, DateTimeKind.Local).AddTicks(5548),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 21, 30, 57, 264, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 319, DateTimeKind.Local).AddTicks(1323),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 21, 30, 57, 263, DateTimeKind.Local).AddTicks(9074));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 318, DateTimeKind.Local).AddTicks(6758),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 21, 30, 57, 263, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 317, DateTimeKind.Local).AddTicks(1081),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 21, 30, 57, 261, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 318, DateTimeKind.Local).AddTicks(3099),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 21, 30, 57, 263, DateTimeKind.Local).AddTicks(962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 317, DateTimeKind.Local).AddTicks(9778),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 21, 30, 57, 262, DateTimeKind.Local).AddTicks(7888));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 316, DateTimeKind.Local).AddTicks(5777),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 21, 30, 57, 261, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 316, DateTimeKind.Local).AddTicks(2358),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 21, 30, 57, 261, DateTimeKind.Local).AddTicks(1072));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 308, DateTimeKind.Local).AddTicks(8440),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 21, 30, 57, 251, DateTimeKind.Local).AddTicks(4837));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 9, 17, 47, 41, 315, DateTimeKind.Local).AddTicks(7991),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 9, 21, 30, 57, 260, DateTimeKind.Local).AddTicks(6995));
        }
    }
}
