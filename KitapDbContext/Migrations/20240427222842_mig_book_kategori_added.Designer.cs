﻿// <auto-generated />
using Kitap.arama;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Kitap.arama.Migrations
{
    [DbContext(typeof(KütüphaneContext))]
    [Migration("20240427222842_mig_book_kategori_added")]
    partial class mig_book_kategori_added
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Kitap.arama.Müşteri", b =>
                {
                    b.Property<int>("MüşteriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MüşteriID"));

                    b.Property<int>("KiralananKitapSayısı")
                        .HasColumnType("int");

                    b.Property<string>("KiralananKitaplar")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MüşteriAd")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MüşteriSoyAd")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("OkunanKitapSayısı")
                        .HasColumnType("int");

                    b.HasKey("MüşteriID");

                    b.ToTable("Müşteris");
                });

            modelBuilder.Entity("Kitap.arama.Sube", b =>
                {
                    b.Property<int>("ŞubeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ŞubeID"));

                    b.Property<string>("ŞubeKpaıNo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ŞubeMahalle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ŞubeSokak")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ŞubeUlke")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ŞubeID");

                    b.ToTable("Subes");
                });

            modelBuilder.Entity("Kitap.arama.Worder", b =>
                {
                    b.Property<int>("WorkerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WorkerID"));

                    b.Property<string>("WorkerDepertmant")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("WorkerName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("WorkerSurName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("WorkerID");

                    b.ToTable("Worders");
                });

            modelBuilder.Entity("Kütüphane.Entitiy.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Kategori")
                        .HasColumnType("int");

                    b.Property<string>("KitapAdı")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
