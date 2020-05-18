﻿// <auto-generated />
using System;
using Api.WebAPi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Api.WebAPi.Migrations
{
    [DbContext(typeof(ApiContext))]
    [Migration("20200518144555_AddProvincia")]
    partial class AddProvincia
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Api.WebAPi.Data.Entities.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodPais")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomPais")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Paises");
                });

            modelBuilder.Entity("Api.WebAPi.Data.Entities.Provincia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreProv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PaisId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PaisId");

                    b.ToTable("Provincias");
                });

            modelBuilder.Entity("Api.WebAPi.Data.Entities.Provincia", b =>
                {
                    b.HasOne("Api.WebAPi.Data.Entities.Pais", "Pais")
                        .WithMany()
                        .HasForeignKey("PaisId");
                });
#pragma warning restore 612, 618
        }
    }
}
