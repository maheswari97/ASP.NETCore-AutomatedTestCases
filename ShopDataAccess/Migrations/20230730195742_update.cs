using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PhoneLists",
                keyColumn: "Id",
                keyValue: new Guid("12838f16-967d-4d4b-a78d-0c2f6787e212"));

            migrationBuilder.DeleteData(
                table: "PhoneLists",
                keyColumn: "Id",
                keyValue: new Guid("5e9c5e28-bb3b-473d-93a6-e13dbbc1a8ca"));

            migrationBuilder.DeleteData(
                table: "PhoneLists",
                keyColumn: "Id",
                keyValue: new Guid("9627c3f9-8f01-461a-b41e-d410ff5c5c49"));

            migrationBuilder.DeleteData(
                table: "PhoneLists",
                keyColumn: "Id",
                keyValue: new Guid("ae865423-5fc7-46d9-9d58-c995cc23503c"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "PhoneLists",
                columns: new[] { "Id", "PhoneModel", "PhonePrice" },
                values: new object[,]
                {
                    { new Guid("12838f16-967d-4d4b-a78d-0c2f6787e212"), "RedmiNote12pro", 400 },
                    { new Guid("5e9c5e28-bb3b-473d-93a6-e13dbbc1a8ca"), "Iphone13promax", 1300 },
                    { new Guid("9627c3f9-8f01-461a-b41e-d410ff5c5c49"), "IPhone114pro", 1000 },
                    { new Guid("ae865423-5fc7-46d9-9d58-c995cc23503c"), "SmasungGalaxys11", 1500 }
                });
        }
    }
}
