using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RecoverGuidError : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhoneBookings",
                columns: table => new
                {
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DeliveryAddress = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    TypeofPayment = table.Column<int>(type: "int", nullable: false),
                    AvailableDateForCollection = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneBookings", x => x.BookingId);
                });

            migrationBuilder.CreateTable(
                name: "PhoneLists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhonePrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneLists", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhoneBookings");

            migrationBuilder.DropTable(
                name: "PhoneLists");
        }
    }
}
