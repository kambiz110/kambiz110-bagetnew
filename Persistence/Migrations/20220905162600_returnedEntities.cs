using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class returnedEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 20, 55, 59, 796, DateTimeKind.Local).AddTicks(984),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 490, DateTimeKind.Local).AddTicks(9155));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 20, 55, 59, 795, DateTimeKind.Local).AddTicks(8495),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 490, DateTimeKind.Local).AddTicks(6457));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 20, 55, 59, 794, DateTimeKind.Local).AddTicks(9606),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 489, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 20, 55, 59, 795, DateTimeKind.Local).AddTicks(5509),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 490, DateTimeKind.Local).AddTicks(3181));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 20, 55, 59, 794, DateTimeKind.Local).AddTicks(4728),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 489, DateTimeKind.Local).AddTicks(1433));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 20, 55, 59, 794, DateTimeKind.Local).AddTicks(2041),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 488, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 20, 55, 59, 793, DateTimeKind.Local).AddTicks(8879),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 488, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 20, 55, 59, 792, DateTimeKind.Local).AddTicks(8623),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 487, DateTimeKind.Local).AddTicks(3018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 20, 55, 59, 793, DateTimeKind.Local).AddTicks(6524),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 488, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 20, 55, 59, 793, DateTimeKind.Local).AddTicks(4524),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 487, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 20, 55, 59, 792, DateTimeKind.Local).AddTicks(5163),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 486, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 20, 55, 59, 792, DateTimeKind.Local).AddTicks(2883),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 486, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 20, 55, 59, 787, DateTimeKind.Local).AddTicks(1429),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 481, DateTimeKind.Local).AddTicks(655));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 20, 55, 59, 791, DateTimeKind.Local).AddTicks(9829),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 486, DateTimeKind.Local).AddTicks(2958));

            migrationBuilder.CreateTable(
                name: "Nazarats",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatalogItemId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Ip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtInserted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Removed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemove = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nazarats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nazarats_CatalogItems_CatalogItemId",
                        column: x => x.CatalogItemId,
                        principalTable: "CatalogItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Returneds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Returneds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Returneds_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReturnedProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostalCompane = table.Column<int>(type: "int", nullable: false),
                    TrackingNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalStatus = table.Column<int>(type: "int", nullable: false),
                    ReturnedId = table.Column<int>(type: "int", nullable: false),
                    PostOfficeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReciveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnedProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReturnedProducts_Returneds_ReturnedId",
                        column: x => x.ReturnedId,
                        principalTable: "Returneds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReturneOrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderItemId = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ItemStatus = table.Column<int>(type: "int", nullable: false),
                    ReturnedId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturneOrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReturneOrderItems_OrderItems_OrderItemId",
                        column: x => x.OrderItemId,
                        principalTable: "OrderItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReturneOrderItems_Returneds_ReturnedId",
                        column: x => x.ReturnedId,
                        principalTable: "Returneds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Nazarats_CatalogItemId",
                table: "Nazarats",
                column: "CatalogItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnedProducts_ReturnedId",
                table: "ReturnedProducts",
                column: "ReturnedId");

            migrationBuilder.CreateIndex(
                name: "IX_Returneds_OrderId",
                table: "Returneds",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturneOrderItems_OrderItemId",
                table: "ReturneOrderItems",
                column: "OrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturneOrderItems_ReturnedId",
                table: "ReturneOrderItems",
                column: "ReturnedId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nazarats");

            migrationBuilder.DropTable(
                name: "ReturnedProducts");

            migrationBuilder.DropTable(
                name: "ReturneOrderItems");

            migrationBuilder.DropTable(
                name: "Returneds");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 490, DateTimeKind.Local).AddTicks(9155),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 5, 20, 55, 59, 796, DateTimeKind.Local).AddTicks(984));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 490, DateTimeKind.Local).AddTicks(6457),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 5, 20, 55, 59, 795, DateTimeKind.Local).AddTicks(8495));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 489, DateTimeKind.Local).AddTicks(7005),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 5, 20, 55, 59, 794, DateTimeKind.Local).AddTicks(9606));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 490, DateTimeKind.Local).AddTicks(3181),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 5, 20, 55, 59, 795, DateTimeKind.Local).AddTicks(5509));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 489, DateTimeKind.Local).AddTicks(1433),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 5, 20, 55, 59, 794, DateTimeKind.Local).AddTicks(4728));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 488, DateTimeKind.Local).AddTicks(8183),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 5, 20, 55, 59, 794, DateTimeKind.Local).AddTicks(2041));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 488, DateTimeKind.Local).AddTicks(4511),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 5, 20, 55, 59, 793, DateTimeKind.Local).AddTicks(8879));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 487, DateTimeKind.Local).AddTicks(3018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 5, 20, 55, 59, 792, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 488, DateTimeKind.Local).AddTicks(1683),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 5, 20, 55, 59, 793, DateTimeKind.Local).AddTicks(6524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 487, DateTimeKind.Local).AddTicks(9316),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 5, 20, 55, 59, 793, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 486, DateTimeKind.Local).AddTicks(8971),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 5, 20, 55, 59, 792, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 486, DateTimeKind.Local).AddTicks(6304),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 5, 20, 55, 59, 792, DateTimeKind.Local).AddTicks(2883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 481, DateTimeKind.Local).AddTicks(655),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 5, 20, 55, 59, 787, DateTimeKind.Local).AddTicks(1429));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 1, 10, 11, 6, 486, DateTimeKind.Local).AddTicks(2958),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 5, 20, 55, 59, 791, DateTimeKind.Local).AddTicks(9829));
        }
    }
}
