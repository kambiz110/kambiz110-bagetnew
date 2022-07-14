using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class catalogImage2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatalogType_CatalogTypeImages_CatalogTypeImageId",
                table: "CatalogType");

            migrationBuilder.DropIndex(
                name: "IX_CatalogType_CatalogTypeImageId",
                table: "CatalogType");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 553, DateTimeKind.Local).AddTicks(5626),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 115, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 552, DateTimeKind.Local).AddTicks(9426),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 114, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 550, DateTimeKind.Local).AddTicks(6914),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 112, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 552, DateTimeKind.Local).AddTicks(2725),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 114, DateTimeKind.Local).AddTicks(335));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 547, DateTimeKind.Local).AddTicks(8152),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 111, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 547, DateTimeKind.Local).AddTicks(1241),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 111, DateTimeKind.Local).AddTicks(3114));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 546, DateTimeKind.Local).AddTicks(6379),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 110, DateTimeKind.Local).AddTicks(5931));

            migrationBuilder.AlterColumn<int>(
                name: "CatalogTypeImageId",
                table: "CatalogType",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 545, DateTimeKind.Local).AddTicks(1026),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 108, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 546, DateTimeKind.Local).AddTicks(2568),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 110, DateTimeKind.Local).AddTicks(305));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 545, DateTimeKind.Local).AddTicks(9351),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 109, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 544, DateTimeKind.Local).AddTicks(1409),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 108, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 543, DateTimeKind.Local).AddTicks(5089),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 107, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 526, DateTimeKind.Local).AddTicks(8670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 92, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 542, DateTimeKind.Local).AddTicks(7867),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 107, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.CreateIndex(
                name: "IX_CatalogType_CatalogTypeImageId",
                table: "CatalogType",
                column: "CatalogTypeImageId",
                unique: true,
                filter: "[CatalogTypeImageId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogType_CatalogTypeImages_CatalogTypeImageId",
                table: "CatalogType",
                column: "CatalogTypeImageId",
                principalTable: "CatalogTypeImages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatalogType_CatalogTypeImages_CatalogTypeImageId",
                table: "CatalogType");

            migrationBuilder.DropIndex(
                name: "IX_CatalogType_CatalogTypeImageId",
                table: "CatalogType");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 115, DateTimeKind.Local).AddTicks(1520),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 553, DateTimeKind.Local).AddTicks(5626));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 114, DateTimeKind.Local).AddTicks(6149),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 552, DateTimeKind.Local).AddTicks(9426));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 112, DateTimeKind.Local).AddTicks(8754),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 550, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 114, DateTimeKind.Local).AddTicks(335),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 552, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 111, DateTimeKind.Local).AddTicks(9320),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 547, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 111, DateTimeKind.Local).AddTicks(3114),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 547, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 110, DateTimeKind.Local).AddTicks(5931),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 546, DateTimeKind.Local).AddTicks(6379));

            migrationBuilder.AlterColumn<int>(
                name: "CatalogTypeImageId",
                table: "CatalogType",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 108, DateTimeKind.Local).AddTicks(6907),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 545, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 110, DateTimeKind.Local).AddTicks(305),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 546, DateTimeKind.Local).AddTicks(2568));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 109, DateTimeKind.Local).AddTicks(4046),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 545, DateTimeKind.Local).AddTicks(9351));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 108, DateTimeKind.Local).AddTicks(2429),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 544, DateTimeKind.Local).AddTicks(1409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 107, DateTimeKind.Local).AddTicks(9328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 543, DateTimeKind.Local).AddTicks(5089));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 92, DateTimeKind.Local).AddTicks(8338),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 526, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 107, DateTimeKind.Local).AddTicks(3651),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 542, DateTimeKind.Local).AddTicks(7867));

            migrationBuilder.CreateIndex(
                name: "IX_CatalogType_CatalogTypeImageId",
                table: "CatalogType",
                column: "CatalogTypeImageId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogType_CatalogTypeImages_CatalogTypeImageId",
                table: "CatalogType",
                column: "CatalogTypeImageId",
                principalTable: "CatalogTypeImages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
