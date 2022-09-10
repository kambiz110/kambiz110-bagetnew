using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class paymentInvoiceedit2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_ReturnPaymentInvoice_ReturnPaymentInvoiceId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_ReturnPaymentInvoice_Returneds_ReturnedId",
                table: "ReturnPaymentInvoice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReturnPaymentInvoice",
                table: "ReturnPaymentInvoice");

            migrationBuilder.RenameTable(
                name: "ReturnPaymentInvoice",
                newName: "ReturnPaymentInvoices");

            migrationBuilder.RenameIndex(
                name: "IX_ReturnPaymentInvoice_ReturnedId",
                table: "ReturnPaymentInvoices",
                newName: "IX_ReturnPaymentInvoices_ReturnedId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 21, 7, 55, 155, DateTimeKind.Local).AddTicks(301),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 20, 28, 25, 184, DateTimeKind.Local).AddTicks(6213));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 21, 7, 55, 154, DateTimeKind.Local).AddTicks(6085),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 20, 28, 25, 184, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 21, 7, 55, 153, DateTimeKind.Local).AddTicks(33),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 20, 28, 25, 183, DateTimeKind.Local).AddTicks(3381));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 21, 7, 55, 154, DateTimeKind.Local).AddTicks(860),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 20, 28, 25, 184, DateTimeKind.Local).AddTicks(1120));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 21, 7, 55, 152, DateTimeKind.Local).AddTicks(1116),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 20, 28, 25, 182, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 21, 7, 55, 151, DateTimeKind.Local).AddTicks(6279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 20, 28, 25, 182, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 21, 7, 55, 151, DateTimeKind.Local).AddTicks(1154),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 20, 28, 25, 182, DateTimeKind.Local).AddTicks(2603));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 21, 7, 55, 149, DateTimeKind.Local).AddTicks(2792),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 20, 28, 25, 181, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 21, 7, 55, 150, DateTimeKind.Local).AddTicks(7154),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 20, 28, 25, 182, DateTimeKind.Local).AddTicks(334));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 21, 7, 55, 150, DateTimeKind.Local).AddTicks(3687),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 20, 28, 25, 181, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 21, 7, 55, 148, DateTimeKind.Local).AddTicks(6753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 20, 28, 25, 180, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 21, 7, 55, 148, DateTimeKind.Local).AddTicks(3104),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 20, 28, 25, 180, DateTimeKind.Local).AddTicks(7184));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 21, 7, 55, 138, DateTimeKind.Local).AddTicks(9350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 20, 28, 25, 175, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 21, 7, 55, 147, DateTimeKind.Local).AddTicks(8484),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 20, 28, 25, 180, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReturnPaymentInvoices",
                table: "ReturnPaymentInvoices",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_ReturnPaymentInvoices_ReturnPaymentInvoiceId",
                table: "Orders",
                column: "ReturnPaymentInvoiceId",
                principalTable: "ReturnPaymentInvoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReturnPaymentInvoices_Returneds_ReturnedId",
                table: "ReturnPaymentInvoices",
                column: "ReturnedId",
                principalTable: "Returneds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_ReturnPaymentInvoices_ReturnPaymentInvoiceId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_ReturnPaymentInvoices_Returneds_ReturnedId",
                table: "ReturnPaymentInvoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReturnPaymentInvoices",
                table: "ReturnPaymentInvoices");

            migrationBuilder.RenameTable(
                name: "ReturnPaymentInvoices",
                newName: "ReturnPaymentInvoice");

            migrationBuilder.RenameIndex(
                name: "IX_ReturnPaymentInvoices_ReturnedId",
                table: "ReturnPaymentInvoice",
                newName: "IX_ReturnPaymentInvoice_ReturnedId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 20, 28, 25, 184, DateTimeKind.Local).AddTicks(6213),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 21, 7, 55, 155, DateTimeKind.Local).AddTicks(301));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 20, 28, 25, 184, DateTimeKind.Local).AddTicks(4043),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 21, 7, 55, 154, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 20, 28, 25, 183, DateTimeKind.Local).AddTicks(3381),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 21, 7, 55, 153, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 20, 28, 25, 184, DateTimeKind.Local).AddTicks(1120),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 21, 7, 55, 154, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 20, 28, 25, 182, DateTimeKind.Local).AddTicks(8232),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 21, 7, 55, 152, DateTimeKind.Local).AddTicks(1116));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 20, 28, 25, 182, DateTimeKind.Local).AddTicks(5498),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 21, 7, 55, 151, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 20, 28, 25, 182, DateTimeKind.Local).AddTicks(2603),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 21, 7, 55, 151, DateTimeKind.Local).AddTicks(1154));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 20, 28, 25, 181, DateTimeKind.Local).AddTicks(2817),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 21, 7, 55, 149, DateTimeKind.Local).AddTicks(2792));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 20, 28, 25, 182, DateTimeKind.Local).AddTicks(334),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 21, 7, 55, 150, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 20, 28, 25, 181, DateTimeKind.Local).AddTicks(8413),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 21, 7, 55, 150, DateTimeKind.Local).AddTicks(3687));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 20, 28, 25, 180, DateTimeKind.Local).AddTicks(9358),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 21, 7, 55, 148, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 20, 28, 25, 180, DateTimeKind.Local).AddTicks(7184),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 21, 7, 55, 148, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 20, 28, 25, 175, DateTimeKind.Local).AddTicks(7696),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 21, 7, 55, 138, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 20, 28, 25, 180, DateTimeKind.Local).AddTicks(4429),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 10, 21, 7, 55, 147, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReturnPaymentInvoice",
                table: "ReturnPaymentInvoice",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_ReturnPaymentInvoice_ReturnPaymentInvoiceId",
                table: "Orders",
                column: "ReturnPaymentInvoiceId",
                principalTable: "ReturnPaymentInvoice",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReturnPaymentInvoice_Returneds_ReturnedId",
                table: "ReturnPaymentInvoice",
                column: "ReturnedId",
                principalTable: "Returneds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
