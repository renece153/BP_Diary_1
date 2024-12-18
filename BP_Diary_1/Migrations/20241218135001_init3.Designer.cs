﻿// <auto-generated />
using System;
using BP_Diary_1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BP_Diary_1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241218135001_init3")]
    partial class init3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BP_Diary_1.Models.bp_diary_records", b =>
                {
                    b.Property<int>("bp_diary_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("bp_diary_id"));

                    b.Property<DateTime>("date_record")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("NOW()");

                    b.Property<int>("diastolic")
                        .HasColumnType("integer");

                    b.Property<int>("systolic")
                        .HasColumnType("integer");

                    b.HasKey("bp_diary_id");

                    b.ToTable("bp_diary_records");
                });
#pragma warning restore 612, 618
        }
    }
}