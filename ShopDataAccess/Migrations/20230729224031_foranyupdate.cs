using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class foranyupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PhoneLists",
                keyColumn: "Id",
                keyValue: new Guid("18399d39-65f8-47ef-9d4a-5913eb60fd2d"));

            migrationBuilder.DeleteData(
                table: "PhoneLists",
                keyColumn: "Id",
                keyValue: new Guid("65ee788f-35e8-49ed-91e2-22ffad942343"));

            migrationBuilder.DeleteData(
                table: "PhoneLists",
                keyColumn: "Id",
                keyValue: new Guid("ffa70b7f-a434-401a-923b-4f17936abd03"));

            migrationBuilder.InsertData(
                table: "PhoneLists",
                columns: new[] { "Id", "PhoneModel", "PhonePrice" },
                values: new object[,]
                {
                    { new Guid("23172592-5eec-4804-ab47-72242cc1cf41"), "RedmiNote12pro", 400 },
                    { new Guid("4e2dd676-3805-484b-8682-6f99e1f96b46"), "SmasungGalaxys11", 1500 },
                    { new Guid("75cddc4f-50a8-43cd-bcb0-f9cfadc54478"), "IPhone114pro", 1000 },
                    { new Guid("7bb28b8c-ed19-4d19-8245-a531bdeef99e"), "Iphone13promax", 1300 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PhoneLists",
                keyColumn: "Id",
                keyValue: new Guid("23172592-5eec-4804-ab47-72242cc1cf41"));

            migrationBuilder.DeleteData(
                table: "PhoneLists",
                keyColumn: "Id",
                keyValue: new Guid("4e2dd676-3805-484b-8682-6f99e1f96b46"));

            migrationBuilder.DeleteData(
                table: "PhoneLists",
                keyColumn: "Id",
                keyValue: new Guid("75cddc4f-50a8-43cd-bcb0-f9cfadc54478"));

            migrationBuilder.DeleteData(
                table: "PhoneLists",
                keyColumn: "Id",
                keyValue: new Guid("7bb28b8c-ed19-4d19-8245-a531bdeef99e"));

            migrationBuilder.InsertData(
                table: "PhoneLists",
                columns: new[] { "Id", "PhoneModel", "PhonePrice" },
                values: new object[,]
                {
                    { new Guid("18399d39-65f8-47ef-9d4a-5913eb60fd2d"), "IPhone114pro", 1000 },
                    { new Guid("65ee788f-35e8-49ed-91e2-22ffad942343"), "SmasungGalaxys11", 1500 },
                    { new Guid("ffa70b7f-a434-401a-923b-4f17936abd03"), "RedmiNote12pro", 400 }
                });
        }
    }
}
