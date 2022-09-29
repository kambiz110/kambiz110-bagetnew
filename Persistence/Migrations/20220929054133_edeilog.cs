using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class edeilog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DayLogs");

            migrationBuilder.RenameColumn(
                name: "VisitorVersionVersion",
                table: "Visitors",
                newName: "OperationSystemVersion");

            migrationBuilder.RenameColumn(
                name: "VisitorVersionFamily",
                table: "Visitors",
                newName: "OperationSystemFamily");

            migrationBuilder.AddColumn<string>(
                name: "BrowserFamily",
                table: "Visitors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BrowserVersion",
                table: "Visitors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 29, 9, 11, 32, 620, DateTimeKind.Local).AddTicks(8054),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 24, 18, 36, 34, 473, DateTimeKind.Local).AddTicks(7125));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 29, 9, 11, 32, 620, DateTimeKind.Local).AddTicks(4164),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 24, 18, 36, 34, 473, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 29, 9, 11, 32, 618, DateTimeKind.Local).AddTicks(8212),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 24, 18, 36, 34, 471, DateTimeKind.Local).AddTicks(1718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 29, 9, 11, 32, 619, DateTimeKind.Local).AddTicks(8941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 24, 18, 36, 34, 472, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 29, 9, 11, 32, 617, DateTimeKind.Local).AddTicks(9505),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 24, 18, 36, 34, 470, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 29, 9, 11, 32, 617, DateTimeKind.Local).AddTicks(4818),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 24, 18, 36, 34, 469, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 29, 9, 11, 32, 616, DateTimeKind.Local).AddTicks(9349),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 24, 18, 36, 34, 469, DateTimeKind.Local).AddTicks(5111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 29, 9, 11, 32, 615, DateTimeKind.Local).AddTicks(1011),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 24, 18, 36, 34, 467, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 29, 9, 11, 32, 616, DateTimeKind.Local).AddTicks(5309),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 24, 18, 36, 34, 469, DateTimeKind.Local).AddTicks(1370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 29, 9, 11, 32, 616, DateTimeKind.Local).AddTicks(1966),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 24, 18, 36, 34, 468, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 29, 9, 11, 32, 614, DateTimeKind.Local).AddTicks(4644),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 24, 18, 36, 34, 467, DateTimeKind.Local).AddTicks(3677));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 29, 9, 11, 32, 614, DateTimeKind.Local).AddTicks(749),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 24, 18, 36, 34, 467, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 29, 9, 11, 32, 607, DateTimeKind.Local).AddTicks(6290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 24, 18, 36, 34, 458, DateTimeKind.Local).AddTicks(4325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 29, 9, 11, 32, 613, DateTimeKind.Local).AddTicks(6297),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 24, 18, 36, 34, 466, DateTimeKind.Local).AddTicks(5843));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrowserFamily",
                table: "Visitors");

            migrationBuilder.DropColumn(
                name: "BrowserVersion",
                table: "Visitors");

            migrationBuilder.RenameColumn(
                name: "OperationSystemVersion",
                table: "Visitors",
                newName: "VisitorVersionVersion");

            migrationBuilder.RenameColumn(
                name: "OperationSystemFamily",
                table: "Visitors",
                newName: "VisitorVersionFamily");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 24, 18, 36, 34, 473, DateTimeKind.Local).AddTicks(7125),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 29, 9, 11, 32, 620, DateTimeKind.Local).AddTicks(8054));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 24, 18, 36, 34, 473, DateTimeKind.Local).AddTicks(1026),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 29, 9, 11, 32, 620, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 24, 18, 36, 34, 471, DateTimeKind.Local).AddTicks(1718),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 29, 9, 11, 32, 618, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 24, 18, 36, 34, 472, DateTimeKind.Local).AddTicks(920),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 29, 9, 11, 32, 619, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 24, 18, 36, 34, 470, DateTimeKind.Local).AddTicks(4195),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 29, 9, 11, 32, 617, DateTimeKind.Local).AddTicks(9505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 24, 18, 36, 34, 469, DateTimeKind.Local).AddTicks(9702),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 29, 9, 11, 32, 617, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 24, 18, 36, 34, 469, DateTimeKind.Local).AddTicks(5111),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 29, 9, 11, 32, 616, DateTimeKind.Local).AddTicks(9349));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 24, 18, 36, 34, 467, DateTimeKind.Local).AddTicks(9099),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 29, 9, 11, 32, 615, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 24, 18, 36, 34, 469, DateTimeKind.Local).AddTicks(1370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 29, 9, 11, 32, 616, DateTimeKind.Local).AddTicks(5309));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 24, 18, 36, 34, 468, DateTimeKind.Local).AddTicks(8226),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 29, 9, 11, 32, 616, DateTimeKind.Local).AddTicks(1966));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 24, 18, 36, 34, 467, DateTimeKind.Local).AddTicks(3677),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 29, 9, 11, 32, 614, DateTimeKind.Local).AddTicks(4644));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 24, 18, 36, 34, 467, DateTimeKind.Local).AddTicks(190),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 29, 9, 11, 32, 614, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 24, 18, 36, 34, 458, DateTimeKind.Local).AddTicks(4325),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 29, 9, 11, 32, 607, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 24, 18, 36, 34, 466, DateTimeKind.Local).AddTicks(5843),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 29, 9, 11, 32, 613, DateTimeKind.Local).AddTicks(6297));

            migrationBuilder.CreateTable(
                name: "DayLogs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayLogs", x => x.Id);
                });
        }
    }
}
