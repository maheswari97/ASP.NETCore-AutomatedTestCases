using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addedPhonemodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "PhoneModel",
                table: "PhoneBookings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "PhoneLists",
                columns: new[] { "Id", "NumberOfStocks", "PhoneModel", "PhonePrice" },
                values: new object[,]
                {
                    { new Guid("197f70e4-c870-4fc6-b5d4-7e4f3bdff3b5"), 4, "RedmiNote12pro", 400 },
                    { new Guid("c3cbd403-f457-4dc0-971b-de00b8fb41d3"), 1, "Iphone13promax", 1300 },
                    { new Guid("cd580360-46b3-4560-bc55-beece60d1c55"), 2, "SmasungGalaxys11", 1500 },
                    { new Guid("f4b8d672-bc70-43ac-af2b-3e461c58f40a"), 3, "IPhone114pro", 1000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PhoneLists",
                keyColumn: "Id",
                keyValue: new Guid("197f70e4-c870-4fc6-b5d4-7e4f3bdff3b5"));

            migrationBuilder.DeleteData(
                table: "PhoneLists",
                keyColumn: "Id",
                keyValue: new Guid("c3cbd403-f457-4dc0-971b-de00b8fb41d3"));

            migrationBuilder.DeleteData(
                table: "PhoneLists",
                keyColumn: "Id",
                keyValue: new Guid("cd580360-46b3-4560-bc55-beece60d1c55"));

            migrationBuilder.DeleteData(
                table: "PhoneLists",
                keyColumn: "Id",
                keyValue: new Guid("f4b8d672-bc70-43ac-af2b-3e461c58f40a"));

            migrationBuilder.DropColumn(
                name: "PhoneModel",
                table: "PhoneBookings");

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
    }
}
