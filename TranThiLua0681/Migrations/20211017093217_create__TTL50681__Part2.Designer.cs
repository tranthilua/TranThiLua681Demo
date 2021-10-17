﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TranThiLua0681.Data;

namespace TranThiLua0681.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20211017093217_create__TTL50681__Part2")]
    partial class create__TTL50681__Part2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("TranThiLua0681.Models.PersonTTL0681", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("INTEGER");

                    b.Property<string>("PersonName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("PersonId");

                    b.ToTable("PersonTTL0681");
                });

            modelBuilder.Entity("TranThiLua0681.Models.TTL50681", b =>
                {
                    b.Property<int>("TTLId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TTLGender")
                        .HasColumnType("TEXT");

                    b.Property<string>("TTLName")
                        .HasColumnType("TEXT");

                    b.HasKey("TTLId");

                    b.ToTable("TTL50681");
                });
#pragma warning restore 612, 618
        }
    }
}