using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InitialCreatetbl_company : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 925, DateTimeKind.Local).AddTicks(3167),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 9, 15, 16, 49, 544, DateTimeKind.Local).AddTicks(8082));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 925, DateTimeKind.Local).AddTicks(962),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 9, 15, 16, 49, 544, DateTimeKind.Local).AddTicks(5449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 924, DateTimeKind.Local).AddTicks(4653),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 9, 15, 16, 49, 543, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 924, DateTimeKind.Local).AddTicks(8458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 9, 15, 16, 49, 544, DateTimeKind.Local).AddTicks(2507));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 924, DateTimeKind.Local).AddTicks(768),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 9, 15, 16, 49, 543, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 923, DateTimeKind.Local).AddTicks(6580),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 9, 15, 16, 49, 543, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 921, DateTimeKind.Local).AddTicks(7319),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 9, 15, 16, 49, 541, DateTimeKind.Local).AddTicks(3506));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 923, DateTimeKind.Local).AddTicks(3171),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 9, 15, 16, 49, 542, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 922, DateTimeKind.Local).AddTicks(9891),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 9, 15, 16, 49, 542, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 922, DateTimeKind.Local).AddTicks(6826),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 9, 15, 16, 49, 542, DateTimeKind.Local).AddTicks(1828));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 920, DateTimeKind.Local).AddTicks(9485),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 9, 15, 16, 49, 540, DateTimeKind.Local).AddTicks(6977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 910, DateTimeKind.Local).AddTicks(5724),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 9, 15, 16, 49, 530, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 920, DateTimeKind.Local).AddTicks(5726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 9, 15, 16, 49, 540, DateTimeKind.Local).AddTicks(3773));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Banners",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CatalogCompanes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 921, DateTimeKind.Local).AddTicks(2382)),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogCompanes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatalogCompanes");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Banners");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 9, 15, 16, 49, 544, DateTimeKind.Local).AddTicks(8082),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 925, DateTimeKind.Local).AddTicks(3167));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 9, 15, 16, 49, 544, DateTimeKind.Local).AddTicks(5449),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 925, DateTimeKind.Local).AddTicks(962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 9, 15, 16, 49, 543, DateTimeKind.Local).AddTicks(8352),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 924, DateTimeKind.Local).AddTicks(4653));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 9, 15, 16, 49, 544, DateTimeKind.Local).AddTicks(2507),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 924, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 9, 15, 16, 49, 543, DateTimeKind.Local).AddTicks(3604),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 924, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 9, 15, 16, 49, 543, DateTimeKind.Local).AddTicks(324),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 923, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 9, 15, 16, 49, 541, DateTimeKind.Local).AddTicks(3506),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 921, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 9, 15, 16, 49, 542, DateTimeKind.Local).AddTicks(7569),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 923, DateTimeKind.Local).AddTicks(3171));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 9, 15, 16, 49, 542, DateTimeKind.Local).AddTicks(4726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 922, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 9, 15, 16, 49, 542, DateTimeKind.Local).AddTicks(1828),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 922, DateTimeKind.Local).AddTicks(6826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 9, 15, 16, 49, 540, DateTimeKind.Local).AddTicks(6977),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 920, DateTimeKind.Local).AddTicks(9485));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 9, 15, 16, 49, 530, DateTimeKind.Local).AddTicks(4090),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 910, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 9, 15, 16, 49, 540, DateTimeKind.Local).AddTicks(3773),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 4, 20, 23, 920, DateTimeKind.Local).AddTicks(5726));
        }
    }
}
