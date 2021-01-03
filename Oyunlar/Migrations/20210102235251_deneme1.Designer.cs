﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oyunlar.Models;

namespace Oyunlar.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210102235251_deneme1")]
    partial class deneme1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Oyunlar.Models.Admin", b =>
                {
                    b.Property<int>("adminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("kullaniciAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sifre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("adminID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Oyunlar.Models.Degerlendirme", b =>
                {
                    b.Property<int>("degerlendirmeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("kullaniciID")
                        .HasColumnType("int");

                    b.Property<int>("oyunID")
                        .HasColumnType("int");

                    b.Property<int>("puan")
                        .HasColumnType("int");

                    b.Property<string>("yorum")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("degerlendirmeID");

                    b.HasIndex("kullaniciID");

                    b.HasIndex("oyunID");

                    b.ToTable("Degerlendirmes");
                });

            modelBuilder.Entity("Oyunlar.Models.Kategori", b =>
                {
                    b.Property<int>("KategoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("KategoriAd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KategoriID");

                    b.ToTable("Kategoris");
                });

            modelBuilder.Entity("Oyunlar.Models.Kullanici", b =>
                {
                    b.Property<int>("kullaniciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("kullaniciAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sifre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("kullaniciID");

                    b.ToTable("Kullanicis");
                });

            modelBuilder.Entity("Oyunlar.Models.Oyun", b =>
                {
                    b.Property<int>("oyunID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.Property<int>("boyut")
                        .HasColumnType("int");

                    b.Property<string>("oyunAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("puan")
                        .HasColumnType("int");

                    b.Property<int>("yayinlamaTarihi")
                        .HasColumnType("int");

                    b.HasKey("oyunID");

                    b.HasIndex("KategoriID");

                    b.ToTable("Oyuns");
                });

            modelBuilder.Entity("Oyunlar.Models.Degerlendirme", b =>
                {
                    b.HasOne("Oyunlar.Models.Kullanici", "Kullanici")
                        .WithMany("Degerlendirmes")
                        .HasForeignKey("kullaniciID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Oyunlar.Models.Oyun", "Oyun")
                        .WithMany("Degerlendirmes")
                        .HasForeignKey("oyunID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");

                    b.Navigation("Oyun");
                });

            modelBuilder.Entity("Oyunlar.Models.Oyun", b =>
                {
                    b.HasOne("Oyunlar.Models.Kategori", "Kategori")
                        .WithMany("Oyuns")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("Oyunlar.Models.Kategori", b =>
                {
                    b.Navigation("Oyuns");
                });

            modelBuilder.Entity("Oyunlar.Models.Kullanici", b =>
                {
                    b.Navigation("Degerlendirmes");
                });

            modelBuilder.Entity("Oyunlar.Models.Oyun", b =>
                {
                    b.Navigation("Degerlendirmes");
                });
#pragma warning restore 612, 618
        }
    }
}