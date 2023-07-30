﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopDataAccess;

#nullable disable

namespace ShopDataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("8e0748d1-bbea-465a-b09d-068d651f5bf6"),
                            PhoneModel = "IPhone114pro",
                            PhonePrice = 1000
                        },
                        new
                        {
                            Id = new Guid("ecc6a958-24c1-41eb-b21a-1105ec09e699"),
                            PhoneModel = "SmasungGalaxys11",
                            PhonePrice = 1500
                        },
                        new
                        {
                            Id = new Guid("b4664865-69cd-4404-821c-1cca69e472ee"),
                            PhoneModel = "RedmiNote12pro",
                            PhonePrice = 400
                        },
                        new
                        {
                            Id = new Guid("b3f82ca4-5b5d-4fbd-98c1-fc61e226c5e6"),
                            PhoneModel = "Iphone13promax",
                            PhonePrice = 1300
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
