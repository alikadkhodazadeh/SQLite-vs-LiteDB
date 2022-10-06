﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SQLite.Data;

#nullable disable

namespace SQLite.Data.Migrations
{
    [DbContext(typeof(SqliteContext))]
    [Migration("20221006211118_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("User", b =>
                {
                    b.Property<int>("Number")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Birthday")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Bloodtype")
                        .HasMaxLength(3)
                        .HasColumnType("TEXT");

                    b.Property<string>("Browseruseragent")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("Ccexpires")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Ccnumber")
                        .HasMaxLength(16)
                        .HasColumnType("TEXT");

                    b.Property<string>("Cctype")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Centimeters")
                        .HasMaxLength(3)
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Color")
                        .HasMaxLength(6)
                        .HasColumnType("TEXT");

                    b.Property<string>("Company")
                        .HasMaxLength(70)
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasMaxLength(2)
                        .HasColumnType("TEXT");

                    b.Property<string>("Countryfull")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Cvv2")
                        .HasMaxLength(3)
                        .HasColumnType("TEXT");

                    b.Property<string>("Domain")
                        .HasMaxLength(70)
                        .HasColumnType("TEXT");

                    b.Property<string>("Emailaddress")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Feetinches")
                        .HasMaxLength(6)
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasMaxLength(6)
                        .HasColumnType("TEXT");

                    b.Property<string>("Givenname")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Guid")
                        .HasMaxLength(36)
                        .HasColumnType("TEXT");

                    b.Property<string>("Kilograms")
                        .HasMaxLength(5)
                        .HasColumnType("TEXT");

                    b.Property<double>("Latitude")
                        .HasColumnType("REAL");

                    b.Property<double>("Longitude")
                        .HasColumnType("REAL");

                    b.Property<string>("Maidenname")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Middleinitial")
                        .HasMaxLength(1)
                        .HasColumnType("TEXT");

                    b.Property<string>("Moneygrammtcn")
                        .HasMaxLength(8)
                        .HasColumnType("TEXT");

                    b.Property<string>("Nameset")
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<string>("Nationalid")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Occupation")
                        .HasMaxLength(70)
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<string>("Pounds")
                        .HasMaxLength(5)
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .HasMaxLength(22)
                        .HasColumnType("TEXT");

                    b.Property<string>("Statefull")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Streetaddress")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .HasMaxLength(23)
                        .HasColumnType("TEXT");

                    b.Property<int>("Telephonecountrycode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Telephonenumber")
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasMaxLength(6)
                        .HasColumnType("TEXT");

                    b.Property<string>("Tropicalzodiac")
                        .HasMaxLength(11)
                        .HasColumnType("TEXT");

                    b.Property<string>("Upstracking")
                        .HasMaxLength(24)
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<string>("Vehicle")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("Westernunionmtcn")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Zipcode")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.HasKey("Number");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
