﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Patient.Microservice.Data;

namespace Patient.Microservice.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220612075430_patseeddata")]
    partial class patseeddata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Patient.Microservice.Entities.Patient", b =>
                {
                    b.Property<int>("Pat_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Contact_No")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Pat_Id");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            Pat_Id = 1,
                            Address = "Kaluthara",
                            Age = 35,
                            Contact_No = "0761234567",
                            Email = "kamal@gmail.com",
                            Gender = "Male",
                            Name = "Mr.Kamal Suraweera"
                        },
                        new
                        {
                            Pat_Id = 2,
                            Address = "Colombo",
                            Age = 28,
                            Contact_No = "0711234567",
                            Email = "fernando@gmail.com",
                            Gender = "Male",
                            Name = "Mr.Amal Fernando"
                        },
                        new
                        {
                            Pat_Id = 3,
                            Address = "Gampaha",
                            Age = 30,
                            Contact_No = "0771234567",
                            Email = "manuka@gmail.com",
                            Gender = "Male",
                            Name = "Mr.Manuka Liyanage"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
