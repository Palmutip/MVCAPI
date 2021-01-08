﻿// <auto-generated />
using MVCAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVCAPI.Migrations
{
    [DbContext(typeof(mysola97_APIContext))]
    [Migration("20210108120302_incial")]
    partial class incial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MVCAPI.Models.Chaves", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int(11)");

                    b.Property<byte>("Numchave")
                        .HasColumnName("numchave");

                    b.Property<string>("Stringchave")
                        .HasColumnName("stringchave")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Chaves");
                });

            modelBuilder.Entity("MVCAPI.Models.EfmigrationsHistory", b =>
                {
                    b.Property<string>("MigrationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(95)");

                    b.Property<string>("ProductVersion")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.HasKey("MigrationId");

                    b.ToTable("__EFMigrationsHistory");
                });

            modelBuilder.Entity("MVCAPI.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int(11)");

                    b.Property<int>("Class")
                        .HasColumnName("class")
                        .HasColumnType("int(11)");

                    b.Property<int>("Grade")
                        .HasColumnName("grade")
                        .HasColumnType("int(11)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("student");
                });
#pragma warning restore 612, 618
        }
    }
}