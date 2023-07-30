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
    [Migration("20230730093731_forupdate")]
    partial class forupdate
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

                    b.Property<string>("PhoneModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhonePrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PhoneLists");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9627c3f9-8f01-461a-b41e-d410ff5c5c49"),
                            PhoneModel = "IPhone114pro",
                            PhonePrice = 1000
                        },
                        new
                        {
                            Id = new Guid("ae865423-5fc7-46d9-9d58-c995cc23503c"),
                            PhoneModel = "SmasungGalaxys11",
                            PhonePrice = 1500
                        },
                        new
                        {
                            Id = new Guid("12838f16-967d-4d4b-a78d-0c2f6787e212"),
                            PhoneModel = "RedmiNote12pro",
                            PhonePrice = 400
                        },
                        new
                        {
                            Id = new Guid("5e9c5e28-bb3b-473d-93a6-e13dbbc1a8ca"),
                            PhoneModel = "Iphone13promax",
                            PhonePrice = 1300
                        });
                });
#pragma warning restore 612, 618
        }
    }
}