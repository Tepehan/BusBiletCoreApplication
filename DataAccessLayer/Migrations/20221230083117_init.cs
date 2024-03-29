﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "firmalar",
                columns: table => new
                {
                    firmaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmaAd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    iletisim = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    logoUrl = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_firmalar", x => x.firmaId);
                });

            migrationBuilder.CreateTable(
                name: "guzergahlar",
                columns: table => new
                {
                    guzergahId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kalkisYeri = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    varisYeri = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_guzergahlar", x => x.guzergahId);
                });

            migrationBuilder.CreateTable(
                name: "kullanicilar",
                columns: table => new
                {
                    kullaniciId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kullaniciAd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    kullaniciSifre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    dogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tc = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    mail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    cinsiyet = table.Column<bool>(type: "bit", nullable: false),
                    tel = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kullanicilar", x => x.kullaniciId);
                });

            migrationBuilder.CreateTable(
                name: "otobusler",
                columns: table => new
                {
                    otobusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    koltukSayisi = table.Column<int>(type: "int", nullable: false),
                    wifi = table.Column<bool>(type: "bit", nullable: false),
                    tv = table.Column<bool>(type: "bit", nullable: false),
                    plaka = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    marka = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    otobusSilindi = table.Column<bool>(type: "bit", nullable: false),
                    firmaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_otobusler", x => x.otobusId);
                    table.ForeignKey(
                        name: "FK_otobusler_firmalar_firmaId",
                        column: x => x.firmaId,
                        principalTable: "firmalar",
                        principalColumn: "firmaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "seferler",
                columns: table => new
                {
                    seferId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sure = table.Column<int>(type: "int", nullable: false),
                    kalkisSaat = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    biletFiyat = table.Column<double>(type: "float", nullable: false),
                    guzergahOtobusSilindi = table.Column<bool>(type: "bit", nullable: false),
                    guzergahId = table.Column<int>(type: "int", nullable: false),
                    otobusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_seferler", x => x.seferId);
                    table.ForeignKey(
                        name: "FK_seferler_guzergahlar_guzergahId",
                        column: x => x.guzergahId,
                        principalTable: "guzergahlar",
                        principalColumn: "guzergahId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_seferler_otobusler_otobusId",
                        column: x => x.otobusId,
                        principalTable: "otobusler",
                        principalColumn: "otobusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "biletler",
                columns: table => new
                {
                    biletId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    seriNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    odemeTipi = table.Column<bool>(type: "bit", nullable: false),
                    koltukNo = table.Column<int>(type: "int", nullable: false),
                    biletKesimTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    yolcuAd = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    yolcuSoyad = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    yolcuTc = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    yolcuCinsiyet = table.Column<bool>(type: "bit", nullable: false),
                    seferId = table.Column<int>(type: "int", nullable: false),
                    kullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_biletler", x => x.biletId);
                    table.ForeignKey(
                        name: "FK_biletler_kullanicilar_kullaniciId",
                        column: x => x.kullaniciId,
                        principalTable: "kullanicilar",
                        principalColumn: "kullaniciId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_biletler_seferler_seferId",
                        column: x => x.seferId,
                        principalTable: "seferler",
                        principalColumn: "seferId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_biletler_kullaniciId",
                table: "biletler",
                column: "kullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_biletler_seferId",
                table: "biletler",
                column: "seferId");

            migrationBuilder.CreateIndex(
                name: "IX_otobusler_firmaId",
                table: "otobusler",
                column: "firmaId");

            migrationBuilder.CreateIndex(
                name: "IX_seferler_guzergahId",
                table: "seferler",
                column: "guzergahId");

            migrationBuilder.CreateIndex(
                name: "IX_seferler_otobusId",
                table: "seferler",
                column: "otobusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "biletler");

            migrationBuilder.DropTable(
                name: "kullanicilar");

            migrationBuilder.DropTable(
                name: "seferler");

            migrationBuilder.DropTable(
                name: "guzergahlar");

            migrationBuilder.DropTable(
                name: "otobusler");

            migrationBuilder.DropTable(
                name: "firmalar");
        }
    }
}
