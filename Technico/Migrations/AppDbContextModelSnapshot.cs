﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Technico.Models;

#nullable disable

namespace Technico.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Technico.Models.AppDbContext+OwnerProperty", b =>
                {
                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.HasKey("OwnerId", "PropertyId");

                    b.HasIndex("PropertyId");

                    b.ToTable("OwnerProperty");
                });

            modelBuilder.Entity("Technico.Models.Owner", b =>
                {
                    b.Property<int>("VATNumber")
                        .HasMaxLength(9)
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PhoneNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VATNumber");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("Technico.Models.Property", b =>
                {
                    b.Property<int>("PropertyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PropertyId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerVATNumber")
                        .HasColumnType("int");

                    b.Property<int>("YearOfConstruction")
                        .HasColumnType("int");

                    b.HasKey("PropertyId");

                    b.HasIndex("OwnerVATNumber");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("Technico.Models.Repair", b =>
                {
                    b.Property<int>("RepairId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RepairId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ownerVat")
                        .HasColumnType("int");

                    b.Property<string>("repairAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("repairCost")
                        .HasColumnType("real");

                    b.Property<string>("repairDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("RepairId");

                    b.HasIndex("ownerVat");

                    b.ToTable("Repairs");
                });

            modelBuilder.Entity("Technico.Models.AppDbContext+OwnerProperty", b =>
                {
                    b.HasOne("Technico.Models.Owner", "Owner")
                        .WithMany("OwnerProperties")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Technico.Models.Property", "Property")
                        .WithMany("OwnerProperties")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");

                    b.Navigation("Property");
                });

            modelBuilder.Entity("Technico.Models.Property", b =>
                {
                    b.HasOne("Technico.Models.Owner", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerVATNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Technico.Models.Repair", b =>
                {
                    b.HasOne("Technico.Models.Owner", "Owner")
                        .WithMany("Repairs")
                        .HasForeignKey("ownerVat")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Technico.Models.Owner", b =>
                {
                    b.Navigation("OwnerProperties");

                    b.Navigation("Repairs");
                });

            modelBuilder.Entity("Technico.Models.Property", b =>
                {
                    b.Navigation("OwnerProperties");
                });
#pragma warning restore 612, 618
        }
    }
}
