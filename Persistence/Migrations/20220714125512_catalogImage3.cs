using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class catalogImage3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatalogType_CatalogTypeImages_CatalogTypeImageId",
                table: "CatalogType");

            migrationBuilder.DropIndex(
                name: "IX_CatalogType_CatalogTypeImageId",
                table: "CatalogType");

            migrationBuilder.DropColumn(
                name: "CatalogTypeImageId",
                table: "CatalogType");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 25, 11, 314, DateTimeKind.Local).AddTicks(1584),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 553, DateTimeKind.Local).AddTicks(5626));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 25, 11, 313, DateTimeKind.Local).AddTicks(5279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 552, DateTimeKind.Local).AddTicks(9426));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 25, 11, 311, DateTimeKind.Local).AddTicks(7864),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 550, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 25, 11, 312, DateTimeKind.Local).AddTicks(8932),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 552, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 25, 11, 311, DateTimeKind.Local).AddTicks(949),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 547, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 25, 11, 310, DateTimeKind.Local).AddTicks(5796),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 547, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 25, 11, 309, DateTimeKind.Local).AddTicks(7990),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 546, DateTimeKind.Local).AddTicks(6379));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 25, 11, 308, DateTimeKind.Local).AddTicks(1962),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 545, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 25, 11, 309, DateTimeKind.Local).AddTicks(3083),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 546, DateTimeKind.Local).AddTicks(2568));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 25, 11, 308, DateTimeKind.Local).AddTicks(9785),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 545, DateTimeKind.Local).AddTicks(9351));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 25, 11, 307, DateTimeKind.Local).AddTicks(6912),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 544, DateTimeKind.Local).AddTicks(1409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 25, 11, 307, DateTimeKind.Local).AddTicks(3356),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 543, DateTimeKind.Local).AddTicks(5089));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 25, 11, 294, DateTimeKind.Local).AddTicks(1396),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 526, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 25, 11, 306, DateTimeKind.Local).AddTicks(8988),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 542, DateTimeKind.Local).AddTicks(7867));

            migrationBuilder.CreateIndex(
                name: "IX_CatalogTypeImages_CatalogTypeId",
                table: "CatalogTypeImages",
                column: "CatalogTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogTypeImages_CatalogType_CatalogTypeId",
                table: "CatalogTypeImages",
                column: "CatalogTypeId",
                principalTable: "CatalogType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatalogTypeImages_CatalogType_CatalogTypeId",
                table: "CatalogTypeImages");

            migrationBuilder.DropIndex(
                name: "IX_CatalogTypeImages_CatalogTypeId",
                table: "CatalogTypeImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 553, DateTimeKind.Local).AddTicks(5626),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 25, 11, 314, DateTimeKind.Local).AddTicks(1584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 552, DateTimeKind.Local).AddTicks(9426),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 25, 11, 313, DateTimeKind.Local).AddTicks(5279));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 550, DateTimeKind.Local).AddTicks(6914),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 25, 11, 311, DateTimeKind.Local).AddTicks(7864));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 552, DateTimeKind.Local).AddTicks(2725),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 25, 11, 312, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 547, DateTimeKind.Local).AddTicks(8152),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 25, 11, 311, DateTimeKind.Local).AddTicks(949));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 547, DateTimeKind.Local).AddTicks(1241),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 25, 11, 310, DateTimeKind.Local).AddTicks(5796));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 546, DateTimeKind.Local).AddTicks(6379),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 25, 11, 309, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.AddColumn<int>(
                name: "CatalogTypeImageId",
                table: "CatalogType",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 545, DateTimeKind.Local).AddTicks(1026),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 25, 11, 308, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 546, DateTimeKind.Local).AddTicks(2568),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 25, 11, 309, DateTimeKind.Local).AddTicks(3083));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 545, DateTimeKind.Local).AddTicks(9351),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 25, 11, 308, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 544, DateTimeKind.Local).AddTicks(1409),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 25, 11, 307, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 543, DateTimeKind.Local).AddTicks(5089),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 25, 11, 307, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 526, DateTimeKind.Local).AddTicks(8670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 25, 11, 294, DateTimeKind.Local).AddTicks(1396));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 17, 32, 542, DateTimeKind.Local).AddTicks(7867),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 25, 11, 306, DateTimeKind.Local).AddTicks(8988));

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
    }
}
