﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopDataAccess;

#nullable disable

namespace ShopDataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230731142959_addedStocksfield")]
    partial class addedStocksfield
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ShopDataModel.Model.PhoneBooking", b =>
                {
                    b.Property<Guid>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AvailableDateForCollection")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeliveryAddress")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("PhoneId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TypeofPayment")
                        .HasColumnType("int");

                    b.HasKey("BookingId");

                    b.ToTable("PhoneBookings");
                });

            modelBuilder.Entity("ShopDataModel.Model.PhoneList", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("NumberOfStocks")
                        .HasColumnType("int");

                    b.Property<string>("PhoneModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhonePrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PhoneLists");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0b1ab671-7b1e-438b-876c-1f5b53e9f67d"),
                            NumberOfStocks = 3,
                            PhoneModel = "IPhone114pro",
                            PhonePrice = 1000
                        },
                        new
                        {
                            Id = new Guid("26ac47e1-ef1f-4688-86eb-07bab4d4eddc"),
                            NumberOfStocks = 2,
                            PhoneModel = "SmasungGalaxys11",
                            PhonePrice = 1500
                        },
                        new
                        {
                            Id = new Guid("00a98291-7768-4198-85cd-f26e55896e46"),
                            NumberOfStocks = 4,
                            PhoneModel = "RedmiNote12pro",
                            PhonePrice = 400
                        },
                        new
                        {
                            Id = new Guid("f099ac27-7b8c-4564-996e-1a48941a6141"),
                            NumberOfStocks = 1,
                            PhoneModel = "Iphone13promax",
                            PhonePrice = 1300
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
