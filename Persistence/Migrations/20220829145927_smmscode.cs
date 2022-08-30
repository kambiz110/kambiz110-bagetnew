using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class smmscode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 873, DateTimeKind.Local).AddTicks(2415),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 951, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 872, DateTimeKind.Local).AddTicks(9649),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 950, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 871, DateTimeKind.Local).AddTicks(8427),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 948, DateTimeKind.Local).AddTicks(5928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 872, DateTimeKind.Local).AddTicks(6413),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 950, DateTimeKind.Local).AddTicks(2471));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 871, DateTimeKind.Local).AddTicks(37),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 947, DateTimeKind.Local).AddTicks(6492));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 870, DateTimeKind.Local).AddTicks(5468),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 947, DateTimeKind.Local).AddTicks(1133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 870, DateTimeKind.Local).AddTicks(463),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 946, DateTimeKind.Local).AddTicks(5089));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 868, DateTimeKind.Local).AddTicks(4230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 944, DateTimeKind.Local).AddTicks(5645));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 869, DateTimeKind.Local).AddTicks(6648),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 946, DateTimeKind.Local).AddTicks(384));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 869, DateTimeKind.Local).AddTicks(4106),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 945, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 867, DateTimeKind.Local).AddTicks(2480),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 943, DateTimeKind.Local).AddTicks(9052));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 866, DateTimeKind.Local).AddTicks(8556),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 943, DateTimeKind.Local).AddTicks(4533));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 858, DateTimeKind.Local).AddTicks(7841),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 932, DateTimeKind.Local).AddTicks(6325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 866, DateTimeKind.Local).AddTicks(3672),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 942, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.CreateTable(
                name: "SmsCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Used = table.Column<bool>(type: "bit", nullable: false),
                    RequestCount = table.Column<int>(type: "int", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmsCodes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SmsCodes");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 951, DateTimeKind.Local).AddTicks(4047),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 873, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 950, DateTimeKind.Local).AddTicks(8627),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 872, DateTimeKind.Local).AddTicks(9649));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 948, DateTimeKind.Local).AddTicks(5928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 871, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 950, DateTimeKind.Local).AddTicks(2471),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 872, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 947, DateTimeKind.Local).AddTicks(6492),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 871, DateTimeKind.Local).AddTicks(37));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatologCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 947, DateTimeKind.Local).AddTicks(1133),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 870, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 946, DateTimeKind.Local).AddTicks(5089),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 870, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 944, DateTimeKind.Local).AddTicks(5645),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 868, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 946, DateTimeKind.Local).AddTicks(384),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 869, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 945, DateTimeKind.Local).AddTicks(6215),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 869, DateTimeKind.Local).AddTicks(4106));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogCompanes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 943, DateTimeKind.Local).AddTicks(9052),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 867, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 943, DateTimeKind.Local).AddTicks(4533),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 866, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 932, DateTimeKind.Local).AddTicks(6325),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 858, DateTimeKind.Local).AddTicks(7841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 28, 22, 4, 44, 942, DateTimeKind.Local).AddTicks(8874),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 29, 19, 29, 26, 866, DateTimeKind.Local).AddTicks(3672));
        }
    }
}
