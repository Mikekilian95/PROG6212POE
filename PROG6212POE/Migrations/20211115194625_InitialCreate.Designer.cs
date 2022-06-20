﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PROG6212POE.Models;

namespace PROG6212POE.Migrations
{
    [DbContext(typeof(EntityContext))]
    [Migration("20211115194625_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("PROG6212POE.Models.ModuleModel", b =>
                {
                    b.Property<int>("ModuleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("ClassHours")
                        .HasColumnType("REAL");

                    b.Property<double>("Credits")
                        .HasColumnType("REAL");

                    b.Property<string>("ModuleCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModuleName")
                        .HasColumnType("TEXT");

                    b.HasKey("ModuleID");

                    b.ToTable("ModuleInfo");
                });
#pragma warning restore 612, 618
        }
    }
}