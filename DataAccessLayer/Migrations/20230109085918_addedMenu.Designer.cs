﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230109085918_addedMenu")]
    partial class addedMenu
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityLayer.Admin", b =>
                {
                    b.Property<int>("adminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("adminId"));

                    b.Property<string>("adminEmail")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("adminName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("adminPassword")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("adminType")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("silindi")
                        .HasColumnType("bit");

                    b.HasKey("adminId");

                    b.ToTable("adminler");
                });

            modelBuilder.Entity("EntityLayer.Firma", b =>
                {
                    b.Property<int>("firmaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("firmaId"));

                    b.Property<string>("firmaAd")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("iletisim")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("logoUrl")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("silindi")
                        .HasColumnType("bit");

                    b.HasKey("firmaId");

                    b.ToTable("firmalar");
                });

            modelBuilder.Entity("EntityLayer.Guzergah", b =>
                {
                    b.Property<int>("guzergahId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("guzergahId"));

                    b.Property<string>("kalkisYeri")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("silindi")
                        .HasColumnType("bit");

                    b.Property<string>("varisYeri")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("guzergahId");

                    b.ToTable("guzergahlar");
                });

            modelBuilder.Entity("EntityLayer.GuzergahOtobus", b =>
                {
                    b.Property<int>("seferId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("seferId"));

                    b.Property<double>("biletFiyat")
                        .HasColumnType("float");

                    b.Property<int>("guzergahId")
                        .HasColumnType("int");

                    b.Property<bool>("guzergahOtobusSilindi")
                        .HasColumnType("bit");

                    b.Property<string>("kalkisSaat")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<int>("otobusId")
                        .HasColumnType("int");

                    b.Property<int>("sure")
                        .HasColumnType("int");

                    b.Property<DateTime>("tarih")
                        .HasColumnType("datetime2");

                    b.HasKey("seferId");

                    b.HasIndex("guzergahId");

                    b.HasIndex("otobusId");

                    b.ToTable("seferler");
                });

            modelBuilder.Entity("EntityLayer.GuzergahOtobusKullanici", b =>
                {
                    b.Property<int>("biletId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("biletId"));

                    b.Property<DateTime>("biletKesimTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("koltukNo")
                        .HasColumnType("int");

                    b.Property<int>("kullaniciId")
                        .HasColumnType("int");

                    b.Property<bool>("odemeTipi")
                        .HasColumnType("bit");

                    b.Property<int>("seferId")
                        .HasColumnType("int");

                    b.Property<string>("seriNo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("silindi")
                        .HasColumnType("bit");

                    b.Property<string>("yolcuAd")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<bool>("yolcuCinsiyet")
                        .HasColumnType("bit");

                    b.Property<string>("yolcuSoyad")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("yolcuTc")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("biletId");

                    b.HasIndex("kullaniciId");

                    b.HasIndex("seferId");

                    b.ToTable("biletler");
                });

            modelBuilder.Entity("EntityLayer.Kullanici", b =>
                {
                    b.Property<int>("kullaniciId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("kullaniciId"));

                    b.Property<string>("ad")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("cinsiyet")
                        .HasColumnType("bit");

                    b.Property<DateTime>("dogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("kullaniciAd")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("kullaniciSifre")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("mail")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("silindi")
                        .HasColumnType("bit");

                    b.Property<string>("soyad")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("tc")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("tel")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("kullaniciId");

                    b.ToTable("kullanicilar");
                });

            modelBuilder.Entity("EntityLayer.Menu", b =>
                {
                    b.Property<int>("menuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("menuId"));

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("parentId")
                        .HasColumnType("int");

                    b.HasKey("menuId");

                    b.HasIndex("parentId");

                    b.ToTable("menuler");
                });

            modelBuilder.Entity("EntityLayer.Otobus", b =>
                {
                    b.Property<int>("otobusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("otobusId"));

                    b.Property<int>("firmaId")
                        .HasColumnType("int");

                    b.Property<int>("koltukSayisi")
                        .HasColumnType("int");

                    b.Property<string>("marka")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("model")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("otobusSilindi")
                        .HasColumnType("bit");

                    b.Property<string>("plaka")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<bool>("tv")
                        .HasColumnType("bit");

                    b.Property<bool>("wifi")
                        .HasColumnType("bit");

                    b.HasKey("otobusId");

                    b.HasIndex("firmaId");

                    b.ToTable("otobusler");
                });

            modelBuilder.Entity("EntityLayer.GuzergahOtobus", b =>
                {
                    b.HasOne("EntityLayer.Guzergah", "guzergah")
                        .WithMany("seferler")
                        .HasForeignKey("guzergahId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Otobus", "otobus")
                        .WithMany("seferler")
                        .HasForeignKey("otobusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("guzergah");

                    b.Navigation("otobus");
                });

            modelBuilder.Entity("EntityLayer.GuzergahOtobusKullanici", b =>
                {
                    b.HasOne("EntityLayer.Kullanici", "kullanici")
                        .WithMany("biletler")
                        .HasForeignKey("kullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.GuzergahOtobus", "sefer")
                        .WithMany("biletler")
                        .HasForeignKey("seferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("kullanici");

                    b.Navigation("sefer");
                });

            modelBuilder.Entity("EntityLayer.Menu", b =>
                {
                    b.HasOne("EntityLayer.Menu", "parent")
                        .WithMany("children")
                        .HasForeignKey("parentId");

                    b.Navigation("parent");
                });

            modelBuilder.Entity("EntityLayer.Otobus", b =>
                {
                    b.HasOne("EntityLayer.Firma", "firma")
                        .WithMany("otobusler")
                        .HasForeignKey("firmaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("firma");
                });

            modelBuilder.Entity("EntityLayer.Firma", b =>
                {
                    b.Navigation("otobusler");
                });

            modelBuilder.Entity("EntityLayer.Guzergah", b =>
                {
                    b.Navigation("seferler");
                });

            modelBuilder.Entity("EntityLayer.GuzergahOtobus", b =>
                {
                    b.Navigation("biletler");
                });

            modelBuilder.Entity("EntityLayer.Kullanici", b =>
                {
                    b.Navigation("biletler");
                });

            modelBuilder.Entity("EntityLayer.Menu", b =>
                {
                    b.Navigation("children");
                });

            modelBuilder.Entity("EntityLayer.Otobus", b =>
                {
                    b.Navigation("seferler");
                });
#pragma warning restore 612, 618
        }
    }
}
