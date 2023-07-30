using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class forupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddress",
                table: "PhoneBookings",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddress",
                table: "PhoneBookings",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

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
    }
}
