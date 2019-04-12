﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ReplaceJS.Models;

namespace ReplaceJS.Migrations
{
    [DbContext(typeof(ActorsContext))]
    [Migration("20190412212048_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ReplaceJS.Models.actor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("biography");

                    b.Property<DateTime>("birth_date");

                    b.Property<DateTime>("created_at");

                    b.Property<string>("name");

                    b.Property<string>("profile_url");

                    b.Property<DateTime>("updated_at");

                    b.HasKey("id");

                    b.ToTable("actors");
                });
#pragma warning restore 612, 618
        }
    }
}