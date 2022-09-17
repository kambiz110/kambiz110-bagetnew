using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class Comment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnswerUserName",
                table: "Tickets");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 329, DateTimeKind.Local).AddTicks(2237),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 16, 19, 17, 20, 608, DateTimeKind.Local).AddTicks(2318));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 328, DateTimeKind.Local).AddTicks(6939),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 16, 19, 17, 20, 607, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 327, DateTimeKind.Local).AddTicks(3006),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 16, 19, 17, 20, 606, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 328, DateTimeKind.Local).AddTicks(2350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 16, 19, 17, 20, 607, DateTimeKind.Local).AddTicks(1852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 326, DateTimeKind.Local).AddTicks(5083),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 16, 19, 17, 20, 605, DateTimeKind.Local).AddTicks(4454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 326, DateTimeKind.Local).AddTicks(891),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 16, 19, 17, 20, 604, DateTimeKind.Local).AddTicks(9975));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 325, DateTimeKind.Local).AddTicks(6075),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 16, 19, 17, 20, 604, DateTimeKind.Local).AddTicks(5119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 324, DateTimeKind.Local).AddTicks(290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 16, 19, 17, 20, 602, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 325, DateTimeKind.Local).AddTicks(2549),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 16, 19, 17, 20, 604, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 324, DateTimeKind.Local).AddTicks(9520),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 16, 19, 17, 20, 603, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 323, DateTimeKind.Local).AddTicks(4661),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 16, 19, 17, 20, 602, DateTimeKind.Local).AddTicks(3807));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 323, DateTimeKind.Local).AddTicks(1056),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 16, 19, 17, 20, 602, DateTimeKind.Local).AddTicks(212));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 315, DateTimeKind.Local).AddTicks(560),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 16, 19, 17, 20, 592, DateTimeKind.Local).AddTicks(9085));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 322, DateTimeKind.Local).AddTicks(2976),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 16, 19, 17, 20, 601, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentId = table.Column<long>(type: "bigint", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfirmedUserId = table.Column<long>(type: "bigint", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostId = table.Column<long>(type: "bigint", nullable: false),
                    PostId1 = table.Column<int>(type: "int", nullable: true),
                    CommentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_CatalogItems_PostId1",
                        column: x => x.PostId1,
                        principalTable: "CatalogItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comment_Comment_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Comment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ParentId",
                table: "Comment",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_PostId1",
                table: "Comment",
                column: "PostId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 16, 19, 17, 20, 608, DateTimeKind.Local).AddTicks(2318),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 329, DateTimeKind.Local).AddTicks(2237));

            migrationBuilder.AddColumn<string>(
                name: "AnswerUserName",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 16, 19, 17, 20, 607, DateTimeKind.Local).AddTicks(6824),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 328, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 16, 19, 17, 20, 606, DateTimeKind.Local).AddTicks(2295),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 327, DateTimeKind.Local).AddTicks(3006));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 16, 19, 17, 20, 607, DateTimeKind.Local).AddTicks(1852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 328, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 16, 19, 17, 20, 605, DateTimeKind.Local).AddTicks(4454),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 326, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 16, 19, 17, 20, 604, DateTimeKind.Local).AddTicks(9975),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 326, DateTimeKind.Local).AddTicks(891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 16, 19, 17, 20, 604, DateTimeKind.Local).AddTicks(5119),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 325, DateTimeKind.Local).AddTicks(6075));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 16, 19, 17, 20, 602, DateTimeKind.Local).AddTicks(9175),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 324, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 16, 19, 17, 20, 604, DateTimeKind.Local).AddTicks(1383),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 325, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 16, 19, 17, 20, 603, DateTimeKind.Local).AddTicks(8109),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 324, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 16, 19, 17, 20, 602, DateTimeKind.Local).AddTicks(3807),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 323, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 16, 19, 17, 20, 602, DateTimeKind.Local).AddTicks(212),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 323, DateTimeKind.Local).AddTicks(1056));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 16, 19, 17, 20, 592, DateTimeKind.Local).AddTicks(9085),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 315, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 16, 19, 17, 20, 601, DateTimeKind.Local).AddTicks(5786),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 17, 18, 31, 53, 322, DateTimeKind.Local).AddTicks(2976));
        }
    }
}
