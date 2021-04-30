﻿// <auto-generated />
using System;
using Marshalls_LLC.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Marshalls_LLC.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210428223804_add_relations_ids")]
    partial class add_relations_ids
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "6.0.0-preview.3.21201.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Marshalls_LLC.Core.Entities.Division", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Division");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Name = "Manager"
                        },
                        new
                        {
                            Id = 1,
                            Name = "Operation"
                        });
                });

            modelBuilder.Entity("Marshalls_LLC.Core.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("BaseSalary")
                        .HasColumnType("float");

                    b.Property<DateTime?>("BeginDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 4, 28, 17, 38, 3, 626, DateTimeKind.Local).AddTicks(6683));

                    b.Property<DateTime?>("Birthday")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

                    b.Property<double>("Commission")
                        .HasColumnType("float");

                    b.Property<double>("CompensationBonus")
                        .HasColumnType("float");

                    b.Property<double>("Contributions")
                        .HasColumnType("float");

                    b.Property<int?>("DivisionId")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeCode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("EmployeeName")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("EmployeeSurname")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<string>("IdentificationNumber")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<int>("OfficeId")
                        .HasColumnType("int");

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.Property<double>("ProductionBonus")
                        .HasColumnType("float");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DivisionId");

                    b.HasIndex("OfficeId");

                    b.HasIndex("PositionId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Marshalls_LLC.Core.Entities.Office", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Office");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "A"
                        },
                        new
                        {
                            Id = 2,
                            Name = "B"
                        },
                        new
                        {
                            Id = 3,
                            Name = "C"
                        });
                });

            modelBuilder.Entity("Marshalls_LLC.Core.Entities.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Position");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            Name = "Cargo assistant"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Head of cargo"
                        },
                        new
                        {
                            Id = 1,
                            Name = "Cargo Manager"
                        });
                });

            modelBuilder.Entity("Marshalls_LLC.Core.Entities.Employee", b =>
                {
                    b.HasOne("Marshalls_LLC.Core.Entities.Division", "Division")
                        .WithMany()
                        .HasForeignKey("DivisionId");

                    b.HasOne("Marshalls_LLC.Core.Entities.Office", "Office")
                        .WithMany()
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Marshalls_LLC.Core.Entities.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Division");

                    b.Navigation("Office");

                    b.Navigation("Position");
                });
#pragma warning restore 612, 618
        }
    }
}
