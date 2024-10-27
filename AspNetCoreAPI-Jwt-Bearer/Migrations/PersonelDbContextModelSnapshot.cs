﻿// <auto-generated />
using System;
using AspNetCoreAPI_Jwt_Bearer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AspNetCoreAPI_Jwt_Bearer.Migrations
{
    [DbContext(typeof(PersonelDbContext))]
    partial class PersonelDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AspNetCoreAPI_Jwt_Bearer.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BeginDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BeginDate = new DateTime(2024, 10, 28, 0, 25, 24, 833, DateTimeKind.Local).AddTicks(1500),
                            Email = "aliucar@gmail.com",
                            FirstName = "Ali",
                            LastName = "Uçar",
                            Phone = "543 345 66 77"
                        },
                        new
                        {
                            Id = 2,
                            BeginDate = new DateTime(2024, 10, 28, 0, 25, 24, 833, DateTimeKind.Local).AddTicks(1514),
                            Email = "oyakosar@gmail.com",
                            FirstName = "Oya",
                            LastName = "Koşar",
                            Phone = "533 345 22 44"
                        },
                        new
                        {
                            Id = 3,
                            BeginDate = new DateTime(2024, 10, 28, 0, 25, 24, 833, DateTimeKind.Local).AddTicks(1515),
                            Email = "zeynep@gmail.com",
                            FirstName = "Zeynep",
                            LastName = "Sever",
                            Phone = "532 145 33 77"
                        },
                        new
                        {
                            Id = 4,
                            BeginDate = new DateTime(2024, 10, 28, 0, 25, 24, 833, DateTimeKind.Local).AddTicks(1516),
                            Email = "hasan@gmail.com",
                            FirstName = "Hasan",
                            LastName = "Kaya",
                            Phone = "545 345 11 22"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
