using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addedStocksfield : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PhoneLists",
                keyColumn: "Id",
                keyValue: new Guid("8e0748d1-bbea-465a-b09d-068d651f5bf6"));

            migrationBuilder.DeleteData(
                table: "PhoneLists",
                keyColumn: "Id",
                keyValue: new Guid("b3f82ca4-5b5d-4fbd-98c1-fc61e226c5e6"));

            migrationBuilder.DeleteData(
                table: "PhoneLists",
                keyColumn: "Id",
                keyValue: new Guid("b4664865-69cd-4404-821c-1cca69e472ee"));

            migrationBuilder.DeleteData(
                table: "PhoneLists",
                keyColumn: "Id",
                keyValue: new Guid("ecc6a958-24c1-41eb-b21a-1105ec09e699"));

            migrationBuilder.AddColumn<int>(
                name: "NumberOfStocks",
                table: "PhoneLists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "PhoneLists",
                columns: new[] { "Id", "NumberOfStocks", "PhoneModel", "PhonePrice" },
                values: new object[,]
                {
                    { new Guid("00a98291-7768-4198-85cd-f26e55896e46"), 4, "RedmiNote12pro", 400 },
                    { new Guid("0b1ab671-7b1e-438b-876c-1f5b53e9f67d"), 3, "IPhone114pro", 1000 },
                    { new Guid("26ac47e1-ef1f-4688-86eb-07bab4d4eddc"), 2, "SmasungGalaxys11", 1500 },
                    { new Guid("f099ac27-7b8c-4564-996e-1a48941a6141"), 1, "Iphone13promax", 1300 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PhoneLists",
                keyColumn: "Id",
                keyValue: new Guid("00a98291-7768-4198-85cd-f26e55896e46"));

            migrationBuilder.DeleteData(
                table: "PhoneLists",
                keyColumn: "Id",
                keyValue: new Guid("0b1ab671-7b1e-438b-876c-1f5b53e9f67d"));

            migrationBuilder.DeleteData(
                table: "PhoneLists",
                keyColumn: "Id",
                keyValue: new Guid("26ac47e1-ef1f-4688-86eb-07bab4d4eddc"));

            migrationBuilder.DeleteData(
                table: "PhoneLists",
                keyColumn: "Id",
                keyValue: new Guid("f099ac27-7b8c-4564-996e-1a48941a6141"));

            migrationBuilder.DropColumn(
                name: "NumberOfStocks",
                table: "PhoneLists");

            migrationBuilder.InsertData(
                table: "PhoneLists",
                columns: new[] { "Id", "PhoneModel", "PhonePrice" },
                values: new object[,]
                {
                    { new Guid("8e0748d1-bbea-465a-b09d-068d651f5bf6"), "IPhone114pro", 1000 },
                    { new Guid("b3f82ca4-5b5d-4fbd-98c1-fc61e226c5e6"), "Iphone13promax", 1300 },
                    { new Guid("b4664865-69cd-4404-821c-1cca69e472ee"), "RedmiNote12pro", 400 },
                    { new Guid("ecc6a958-24c1-41eb-b21a-1105ec09e699"), "SmasungGalaxys11", 1500 }
                });
        }
    }
}
