using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class Comment2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_CatalogItems_PostId1",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Comment_ParentId",
                table: "Comment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comment",
                table: "Comment");

            migrationBuilder.RenameTable(
                name: "Comment",
                newName: "Comments");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_PostId1",
                table: "Comments",
                newName: "IX_Comments_PostId1");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_ParentId",
                table: "Comments",
                newName: "IX_Comments_ParentId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 848, DateTimeKind.Local).AddTicks(7859),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 329, DateTimeKind.Local).AddTicks(2237));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 848, DateTimeKind.Local).AddTicks(1845),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 328, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 845, DateTimeKind.Local).AddTicks(7370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 327, DateTimeKind.Local).AddTicks(3006));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 847, DateTimeKind.Local).AddTicks(4061),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 328, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 844, DateTimeKind.Local).AddTicks(3561),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 326, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 843, DateTimeKind.Local).AddTicks(9456),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 326, DateTimeKind.Local).AddTicks(891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 843, DateTimeKind.Local).AddTicks(4477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 325, DateTimeKind.Local).AddTicks(6075));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 841, DateTimeKind.Local).AddTicks(8289),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 324, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 843, DateTimeKind.Local).AddTicks(968),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 325, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 842, DateTimeKind.Local).AddTicks(7917),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 324, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 841, DateTimeKind.Local).AddTicks(2592),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 323, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 840, DateTimeKind.Local).AddTicks(9044),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 323, DateTimeKind.Local).AddTicks(1056));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 831, DateTimeKind.Local).AddTicks(7471),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 315, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 840, DateTimeKind.Local).AddTicks(4582),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 322, DateTimeKind.Local).AddTicks(2976));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_CatalogItems_PostId1",
                table: "Comments",
                column: "PostId1",
                principalTable: "CatalogItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Comments_ParentId",
                table: "Comments",
                column: "ParentId",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_CatalogItems_PostId1",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Comments_ParentId",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "Comment");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_PostId1",
                table: "Comment",
                newName: "IX_Comment_PostId1");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_ParentId",
                table: "Comment",
                newName: "IX_Comment_ParentId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 329, DateTimeKind.Local).AddTicks(2237),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 848, DateTimeKind.Local).AddTicks(7859));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 328, DateTimeKind.Local).AddTicks(6939),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 848, DateTimeKind.Local).AddTicks(1845));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 327, DateTimeKind.Local).AddTicks(3006),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 845, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 328, DateTimeKind.Local).AddTicks(2350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 847, DateTimeKind.Local).AddTicks(4061));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 326, DateTimeKind.Local).AddTicks(5083),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 844, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 326, DateTimeKind.Local).AddTicks(891),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 843, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 325, DateTimeKind.Local).AddTicks(6075),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 843, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 324, DateTimeKind.Local).AddTicks(290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 841, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 325, DateTimeKind.Local).AddTicks(2549),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 843, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 324, DateTimeKind.Local).AddTicks(9520),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 842, DateTimeKind.Local).AddTicks(7917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 323, DateTimeKind.Local).AddTicks(4661),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 841, DateTimeKind.Local).AddTicks(2592));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 323, DateTimeKind.Local).AddTicks(1056),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 840, DateTimeKind.Local).AddTicks(9044));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 315, DateTimeKind.Local).AddTicks(560),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 831, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 322, DateTimeKind.Local).AddTicks(2976),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 42, 49, 840, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comment",
                table: "Comment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_CatalogItems_PostId1",
                table: "Comment",
                column: "PostId1",
                principalTable: "CatalogItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Comment_ParentId",
                table: "Comment",
                column: "ParentId",
                principalTable: "Comment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
