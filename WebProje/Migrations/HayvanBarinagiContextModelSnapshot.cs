﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebProje.Models;

namespace WebProje.Migrations
{
    [DbContext(typeof(HayvanBarinagiContext))]
    partial class HayvanBarinagiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebProje.Models.Hayvanlar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HayvanAdi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("HayvanResim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Sahiplenildimi")
                        .HasColumnType("bit");

                    b.Property<string>("Tur")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Hayvan");
                });

            modelBuilder.Entity("WebProje.Models.Sahiplenme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HayvanId")
                        .HasColumnType("int");

                    b.Property<string>("TC")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("adres")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("dogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("isim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soru1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soru2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soru3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soru4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soyIsim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sahiplenme");
                });
#pragma warning restore 612, 618
        }
    }
}
