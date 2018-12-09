﻿// <auto-generated />
using System;
using IIMStemplate.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IIMStemplate.Migrations.InventoryManagementDb
{
    [DbContext(typeof(InventoryManagementDbContext))]
    [Migration("20181205040647_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IIMStemplate.Models.Donor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("CompanyName");

                    b.Property<int>("DonorEntity");

                    b.Property<string>("DonorName")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("JobTitle");

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<int>("TotalDonations");

                    b.HasKey("ID");

                    b.ToTable("Donors");
                });

            modelBuilder.Entity("IIMStemplate.Models.Log", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActionTaken")
                        .IsRequired();

                    b.Property<string>("EmployeeID")
                        .IsRequired();

                    b.Property<DateTime>("TimeStamp");

                    b.HasKey("ID");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("IIMStemplate.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AcceptPartialShip");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("EmployeeID")
                        .IsRequired();

                    b.Property<int>("PartialOrderID");

                    b.Property<DateTime>("ShipDate");

                    b.HasKey("ID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("IIMStemplate.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Availability");

                    b.Property<string>("Color");

                    b.Property<string>("Condition");

                    b.Property<string>("Description");

                    b.Property<int>("DonorID");

                    b.Property<string>("EstimatedValue");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("OrderID");

                    b.Property<string>("Size");

                    b.Property<string>("Sku")
                        .IsRequired();

                    b.Property<string>("Use");

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("IIMStemplate.Models.Product", b =>
                {
                    b.HasOne("IIMStemplate.Models.Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
