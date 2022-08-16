﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prescription.Microservice.Data;

namespace Prescription.Microservice.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220612094021_preinitialmigration")]
    partial class preinitialmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Prescription.Microservice.Entities.Prescription", b =>
                {
                    b.Property<int>("Prs_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Doc_Id")
                        .HasColumnType("int");

                    b.Property<int>("Med_Id")
                        .HasColumnType("int");

                    b.Property<int>("Pat_Id")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Prs_Id");

                    b.ToTable("Prescriptions");
                });
#pragma warning restore 612, 618
        }
    }
}