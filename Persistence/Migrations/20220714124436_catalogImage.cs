using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class catalogImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 115, DateTimeKind.Local).AddTicks(1520),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 10, 14, 54, 12, 470, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 114, DateTimeKind.Local).AddTicks(6149),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 10, 14, 54, 12, 470, DateTimeKind.Local).AddTicks(4498));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 112, DateTimeKind.Local).AddTicks(8754),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 10, 14, 54, 12, 469, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 114, DateTimeKind.Local).AddTicks(335),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 10, 14, 54, 12, 470, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 111, DateTimeKind.Local).AddTicks(9320),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 10, 14, 54, 12, 469, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 111, DateTimeKind.Local).AddTicks(3114),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 10, 14, 54, 12, 469, DateTimeKind.Local).AddTicks(3403));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 110, DateTimeKind.Local).AddTicks(5931),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 10, 14, 54, 12, 469, DateTimeKind.Local).AddTicks(1285));

            migrationBuilder.AddColumn<int>(
                name: "CatalogTypeImageId",
                table: "CatalogType",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SortIndex",
                table: "CatalogType",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 108, DateTimeKind.Local).AddTicks(6907),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 10, 14, 54, 12, 468, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 110, DateTimeKind.Local).AddTicks(305),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 10, 14, 54, 12, 468, DateTimeKind.Local).AddTicks(9518));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 109, DateTimeKind.Local).AddTicks(4046),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 10, 14, 54, 12, 468, DateTimeKind.Local).AddTicks(7917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 108, DateTimeKind.Local).AddTicks(2429),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 10, 14, 54, 12, 468, DateTimeKind.Local).AddTicks(1358));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 107, DateTimeKind.Local).AddTicks(9328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 10, 14, 54, 12, 467, DateTimeKind.Local).AddTicks(9613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 92, DateTimeKind.Local).AddTicks(8338),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 10, 14, 54, 12, 460, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 107, DateTimeKind.Local).AddTicks(3651),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 10, 14, 54, 12, 467, DateTimeKind.Local).AddTicks(7434));

            migrationBuilder.CreateTable(
                name: "CatalogTypeImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Src = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatalogTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogTypeImages", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatalogType_CatalogTypeImages_CatalogTypeImageId",
                table: "CatalogType");

            migrationBuilder.DropTable(
                name: "CatalogTypeImages");

            migrationBuilder.DropIndex(
                name: "IX_CatalogType_CatalogTypeImageId",
                table: "CatalogType");

            migrationBuilder.DropColumn(
                name: "CatalogTypeImageId",
                table: "CatalogType");

            migrationBuilder.DropColumn(
                name: "SortIndex",
                table: "CatalogType");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 10, 14, 54, 12, 470, DateTimeKind.Local).AddTicks(6215),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 115, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 10, 14, 54, 12, 470, DateTimeKind.Local).AddTicks(4498),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 114, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 10, 14, 54, 12, 469, DateTimeKind.Local).AddTicks(9041),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 112, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 10, 14, 54, 12, 470, DateTimeKind.Local).AddTicks(2400),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 114, DateTimeKind.Local).AddTicks(335));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 10, 14, 54, 12, 469, DateTimeKind.Local).AddTicks(5541),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 111, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 10, 14, 54, 12, 469, DateTimeKind.Local).AddTicks(3403),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 111, DateTimeKind.Local).AddTicks(3114));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 10, 14, 54, 12, 469, DateTimeKind.Local).AddTicks(1285),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 110, DateTimeKind.Local).AddTicks(5931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 10, 14, 54, 12, 468, DateTimeKind.Local).AddTicks(3938),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 108, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 10, 14, 54, 12, 468, DateTimeKind.Local).AddTicks(9518),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 110, DateTimeKind.Local).AddTicks(305));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 10, 14, 54, 12, 468, DateTimeKind.Local).AddTicks(7917),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 109, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 10, 14, 54, 12, 468, DateTimeKind.Local).AddTicks(1358),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 108, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 10, 14, 54, 12, 467, DateTimeKind.Local).AddTicks(9613),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 107, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 10, 14, 54, 12, 460, DateTimeKind.Local).AddTicks(8237),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 92, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 10, 14, 54, 12, 467, DateTimeKind.Local).AddTicks(7434),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 17, 14, 35, 107, DateTimeKind.Local).AddTicks(3651));
        }
    }
}
