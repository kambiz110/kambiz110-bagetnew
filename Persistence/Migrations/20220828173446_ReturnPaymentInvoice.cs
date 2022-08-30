using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class ReturnPaymentInvoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 951, DateTimeKind.Local).AddTicks(4047),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 780, DateTimeKind.Local).AddTicks(1053));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 950, DateTimeKind.Local).AddTicks(8627),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 779, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 948, DateTimeKind.Local).AddTicks(5928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 779, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 950, DateTimeKind.Local).AddTicks(2471),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 779, DateTimeKind.Local).AddTicks(5811));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 947, DateTimeKind.Local).AddTicks(6492),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 778, DateTimeKind.Local).AddTicks(6791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 947, DateTimeKind.Local).AddTicks(1133),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 778, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 946, DateTimeKind.Local).AddTicks(5089),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 778, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 944, DateTimeKind.Local).AddTicks(5645),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 777, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 946, DateTimeKind.Local).AddTicks(384),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 777, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 945, DateTimeKind.Local).AddTicks(6215),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 777, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 943, DateTimeKind.Local).AddTicks(9052),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 776, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 943, DateTimeKind.Local).AddTicks(4533),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 776, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 932, DateTimeKind.Local).AddTicks(6325),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 771, DateTimeKind.Local).AddTicks(3002));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 942, DateTimeKind.Local).AddTicks(8874),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 776, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.CreateTable(
                name: "ReturnPaymentInvoice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    DatePay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FollowKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankOrigin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankDestination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnPaymentInvoice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReturnPaymentInvoice_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReturnPaymentInvoice_OrderId",
                table: "ReturnPaymentInvoice",
                column: "OrderId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReturnPaymentInvoice");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 780, DateTimeKind.Local).AddTicks(1053),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 951, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 779, DateTimeKind.Local).AddTicks(8454),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 950, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 779, DateTimeKind.Local).AddTicks(1351),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 948, DateTimeKind.Local).AddTicks(5928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 779, DateTimeKind.Local).AddTicks(5811),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 950, DateTimeKind.Local).AddTicks(2471));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 778, DateTimeKind.Local).AddTicks(6791),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 947, DateTimeKind.Local).AddTicks(6492));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 778, DateTimeKind.Local).AddTicks(4153),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 947, DateTimeKind.Local).AddTicks(1133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 778, DateTimeKind.Local).AddTicks(1338),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 946, DateTimeKind.Local).AddTicks(5089));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 777, DateTimeKind.Local).AddTicks(1987),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 944, DateTimeKind.Local).AddTicks(5645));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 777, DateTimeKind.Local).AddTicks(9105),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 946, DateTimeKind.Local).AddTicks(384));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 777, DateTimeKind.Local).AddTicks(7170),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 945, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 776, DateTimeKind.Local).AddTicks(8771),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 943, DateTimeKind.Local).AddTicks(9052));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 776, DateTimeKind.Local).AddTicks(6667),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 943, DateTimeKind.Local).AddTicks(4533));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 771, DateTimeKind.Local).AddTicks(3002),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 932, DateTimeKind.Local).AddTicks(6325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 19, 43, 22, 776, DateTimeKind.Local).AddTicks(4010),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 942, DateTimeKind.Local).AddTicks(8874));
        }
    }
}
