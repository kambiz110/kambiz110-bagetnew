using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class flowyekinorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 490, DateTimeKind.Local).AddTicks(9155),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 873, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 490, DateTimeKind.Local).AddTicks(6457),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 872, DateTimeKind.Local).AddTicks(9649));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 489, DateTimeKind.Local).AddTicks(7005),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 871, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.AddColumn<string>(
                name: "FollowKey",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 490, DateTimeKind.Local).AddTicks(3181),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 872, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 489, DateTimeKind.Local).AddTicks(1433),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 871, DateTimeKind.Local).AddTicks(37));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 488, DateTimeKind.Local).AddTicks(8183),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 870, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 488, DateTimeKind.Local).AddTicks(4511),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 870, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 487, DateTimeKind.Local).AddTicks(3018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 868, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 488, DateTimeKind.Local).AddTicks(1683),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 869, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 487, DateTimeKind.Local).AddTicks(9316),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 869, DateTimeKind.Local).AddTicks(4106));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 486, DateTimeKind.Local).AddTicks(8971),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 867, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 486, DateTimeKind.Local).AddTicks(6304),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 866, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 481, DateTimeKind.Local).AddTicks(655),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 858, DateTimeKind.Local).AddTicks(7841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 486, DateTimeKind.Local).AddTicks(2958),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 866, DateTimeKind.Local).AddTicks(3672));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FollowKey",
                table: "Orders");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 873, DateTimeKind.Local).AddTicks(2415),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 490, DateTimeKind.Local).AddTicks(9155));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 872, DateTimeKind.Local).AddTicks(9649),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 490, DateTimeKind.Local).AddTicks(6457));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 871, DateTimeKind.Local).AddTicks(8427),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 489, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 872, DateTimeKind.Local).AddTicks(6413),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 490, DateTimeKind.Local).AddTicks(3181));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 871, DateTimeKind.Local).AddTicks(37),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 489, DateTimeKind.Local).AddTicks(1433));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 870, DateTimeKind.Local).AddTicks(5468),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 488, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 870, DateTimeKind.Local).AddTicks(463),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 488, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 868, DateTimeKind.Local).AddTicks(4230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 487, DateTimeKind.Local).AddTicks(3018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 869, DateTimeKind.Local).AddTicks(6648),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 488, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 869, DateTimeKind.Local).AddTicks(4106),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 487, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 867, DateTimeKind.Local).AddTicks(2480),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 486, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 866, DateTimeKind.Local).AddTicks(8556),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 486, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 858, DateTimeKind.Local).AddTicks(7841),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 481, DateTimeKind.Local).AddTicks(655));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 866, DateTimeKind.Local).AddTicks(3672),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 486, DateTimeKind.Local).AddTicks(2958));
        }
    }
}
