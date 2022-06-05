using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class edituser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 209, DateTimeKind.Local).AddTicks(5665),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 22, 15, 53, 531, DateTimeKind.Local).AddTicks(2971));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 208, DateTimeKind.Local).AddTicks(8757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 22, 15, 53, 530, DateTimeKind.Local).AddTicks(9047));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 207, DateTimeKind.Local).AddTicks(5701),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 22, 15, 53, 529, DateTimeKind.Local).AddTicks(3078));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 208, DateTimeKind.Local).AddTicks(3869),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 22, 15, 53, 530, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 206, DateTimeKind.Local).AddTicks(7377),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 22, 15, 53, 527, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 206, DateTimeKind.Local).AddTicks(1330),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 22, 15, 53, 526, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 203, DateTimeKind.Local).AddTicks(9035),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 22, 15, 53, 523, DateTimeKind.Local).AddTicks(936));

            migrationBuilder.AddColumn<int>(
                name: "CatalogCompanyId",
                table: "CatalogItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 205, DateTimeKind.Local).AddTicks(6562),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 22, 15, 53, 526, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 205, DateTimeKind.Local).AddTicks(2028),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 22, 15, 53, 525, DateTimeKind.Local).AddTicks(3016));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 204, DateTimeKind.Local).AddTicks(8103),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 22, 15, 53, 524, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 203, DateTimeKind.Local).AddTicks(4986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 22, 15, 53, 522, DateTimeKind.Local).AddTicks(1518));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 203, DateTimeKind.Local).AddTicks(2215),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 22, 15, 53, 521, DateTimeKind.Local).AddTicks(4834));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 189, DateTimeKind.Local).AddTicks(4792),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 22, 15, 53, 496, DateTimeKind.Local).AddTicks(655));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 202, DateTimeKind.Local).AddTicks(8687),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 22, 15, 53, 520, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.CreateIndex(
                name: "IX_CatalogItems_CatalogCompanyId",
                table: "CatalogItems",
                column: "CatalogCompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogItems_CatalogCompanes_CatalogCompanyId",
                table: "CatalogItems",
                column: "CatalogCompanyId",
                principalTable: "CatalogCompanes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatalogItems_CatalogCompanes_CatalogCompanyId",
                table: "CatalogItems");

            migrationBuilder.DropIndex(
                name: "IX_CatalogItems_CatalogCompanyId",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "CatalogCompanyId",
                table: "CatalogItems");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 22, 15, 53, 531, DateTimeKind.Local).AddTicks(2971),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 209, DateTimeKind.Local).AddTicks(5665));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 22, 15, 53, 530, DateTimeKind.Local).AddTicks(9047),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 208, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 22, 15, 53, 529, DateTimeKind.Local).AddTicks(3078),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 207, DateTimeKind.Local).AddTicks(5701));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 22, 15, 53, 530, DateTimeKind.Local).AddTicks(4219),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 208, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 22, 15, 53, 527, DateTimeKind.Local).AddTicks(9239),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 206, DateTimeKind.Local).AddTicks(7377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 22, 15, 53, 526, DateTimeKind.Local).AddTicks(9054),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 206, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 22, 15, 53, 523, DateTimeKind.Local).AddTicks(936),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 203, DateTimeKind.Local).AddTicks(9035));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 22, 15, 53, 526, DateTimeKind.Local).AddTicks(929),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 205, DateTimeKind.Local).AddTicks(6562));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 22, 15, 53, 525, DateTimeKind.Local).AddTicks(3016),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 205, DateTimeKind.Local).AddTicks(2028));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 22, 15, 53, 524, DateTimeKind.Local).AddTicks(6182),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 204, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 22, 15, 53, 522, DateTimeKind.Local).AddTicks(1518),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 203, DateTimeKind.Local).AddTicks(4986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 22, 15, 53, 521, DateTimeKind.Local).AddTicks(4834),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 203, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 22, 15, 53, 496, DateTimeKind.Local).AddTicks(655),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 189, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 22, 15, 53, 520, DateTimeKind.Local).AddTicks(6300),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 5, 22, 2, 52, 202, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.InsertData(
                table: "CatalogBrand",
                columns: new[] { "Id", "Brand", "IsDakely", "RemoveTime", "UpdateTime" },
                values: new object[,]
                {
                    { 1, "سامسونگ", false, null, null },
                    { 2, "شیائومی ", false, null, null },
                    { 3, "اپل", false, null, null },
                    { 4, "هوآوی", false, null, null },
                    { 5, "نوکیا ", false, null, null },
                    { 6, "ال جی", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "CatalogType",
                columns: new[] { "Id", "ParentCatalogTypeId", "RemoveTime", "Type", "UpdateTime" },
                values: new object[] { 1, null, null, "کالای دیجیتال", null });

            migrationBuilder.InsertData(
                table: "CatalogType",
                columns: new[] { "Id", "ParentCatalogTypeId", "RemoveTime", "Type", "UpdateTime" },
                values: new object[] { 2, 1, null, "لوازم جانبی گوشی", null });

            migrationBuilder.InsertData(
                table: "CatalogType",
                columns: new[] { "Id", "ParentCatalogTypeId", "RemoveTime", "Type", "UpdateTime" },
                values: new object[] { 3, 2, null, "پایه نگهدارنده گوشی", null });

            migrationBuilder.InsertData(
                table: "CatalogType",
                columns: new[] { "Id", "ParentCatalogTypeId", "RemoveTime", "Type", "UpdateTime" },
                values: new object[] { 4, 2, null, "پاور بانک (شارژر همراه)", null });

            migrationBuilder.InsertData(
                table: "CatalogType",
                columns: new[] { "Id", "ParentCatalogTypeId", "RemoveTime", "Type", "UpdateTime" },
                values: new object[] { 5, 2, null, "کیف و کاور گوشی", null });
        }
    }
}
