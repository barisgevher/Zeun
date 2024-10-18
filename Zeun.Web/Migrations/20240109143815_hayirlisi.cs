using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zeun.Web.Migrations
{
    /// <inheritdoc />
    public partial class hayirlisi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AkademikDonem",
                columns: table => new
                {
                    AkademikDonemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkademikDonem = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkademikDonem", x => x.AkademikDonemID);
                });

            migrationBuilder.CreateTable(
                name: "AkademikYil",
                columns: table => new
                {
                    AkademikYilID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkademikYil = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkademikYil", x => x.AkademikYilID);
                });

            migrationBuilder.CreateTable(
                name: "Cinsiyet",
                columns: table => new
                {
                    CinsiyetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CinsiyetAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinsiyet", x => x.CinsiyetID);
                });

            migrationBuilder.CreateTable(
                name: "DersAlmaDurumu",
                columns: table => new
                {
                    DersAlmaDurumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersAlmaDurumu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersAlmaDurumu", x => x.DersAlmaDurumID);
                });

            migrationBuilder.CreateTable(
                name: "DersDili",
                columns: table => new
                {
                    DersDiliID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersDili = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersDili", x => x.DersDiliID);
                });

            migrationBuilder.CreateTable(
                name: "DersGunu",
                columns: table => new
                {
                    DersGunuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersGunu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersGunu", x => x.DersGunuID);
                });

            migrationBuilder.CreateTable(
                name: "DerslikTuru",
                columns: table => new
                {
                    DerslikTuruID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DerslikTuruAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DerslikTuru", x => x.DerslikTuruID);
                });

            migrationBuilder.CreateTable(
                name: "DersSaati",
                columns: table => new
                {
                    DersSaatiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersSaati = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersSaati", x => x.DersSaatiID);
                });

            migrationBuilder.CreateTable(
                name: "DersSeviyesi",
                columns: table => new
                {
                    DersSeviyesiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersSeviyesi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersSeviyesi", x => x.DersSeviyesiID);
                });

            migrationBuilder.CreateTable(
                name: "DersTuru",
                columns: table => new
                {
                    DersTuruID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersTuru = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersTuru", x => x.DersTuruID);
                });

            migrationBuilder.CreateTable(
                name: "Fakulte",
                columns: table => new
                {
                    FakulteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FakulteAdi = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fakulte", x => x.FakulteID);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciTuru",
                columns: table => new
                {
                    KullaniciTurID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciTurAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciTuru", x => x.KullaniciTurID);
                });

            migrationBuilder.CreateTable(
                name: "OgrenciDurum",
                columns: table => new
                {
                    OgrenciDurumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciDurumu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrenciDurum", x => x.OgrenciDurumID);
                });

            migrationBuilder.CreateTable(
                name: "OgrenimDili",
                columns: table => new
                {
                    OgrenimDiliID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenimDili = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrenimDili", x => x.OgrenimDiliID);
                });

            migrationBuilder.CreateTable(
                name: "OgretimTuru",
                columns: table => new
                {
                    OgretimTuruID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgretimTurAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgretimTuru", x => x.OgretimTuruID);
                });

            migrationBuilder.CreateTable(
                name: "ProgramTuru",
                columns: table => new
                {
                    ProgramTuruID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgramTurAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramTuru", x => x.ProgramTuruID);
                });

            migrationBuilder.CreateTable(
                name: "SinavTuru",
                columns: table => new
                {
                    SinavTuruID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SinavTuru = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinavTuru", x => x.SinavTuruID);
                });

            migrationBuilder.CreateTable(
                name: "Unvan",
                columns: table => new
                {
                    UnvanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnvanAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unvan", x => x.UnvanID);
                });

            migrationBuilder.CreateTable(
                name: "Derslik",
                columns: table => new
                {
                    DerslikID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DerslikTuruID = table.Column<int>(type: "int", nullable: true),
                    DerslikAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Kapasite = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Derslik", x => x.DerslikID);
                    table.ForeignKey(
                        name: "FK_Derslik_DerslikTuru",
                        column: x => x.DerslikTuruID,
                        principalTable: "DerslikTuru",
                        principalColumn: "DerslikTuruID");
                });

            migrationBuilder.CreateTable(
                name: "Kullanici",
                columns: table => new
                {
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciTuruID = table.Column<int>(type: "int", nullable: true),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Parola = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanici", x => x.KullaniciID);
                    table.ForeignKey(
                        name: "FK_Kullanici_KullaniciTuru",
                        column: x => x.KullaniciTuruID,
                        principalTable: "KullaniciTuru",
                        principalColumn: "KullaniciTurID");
                });

            migrationBuilder.CreateTable(
                name: "Bolum",
                columns: table => new
                {
                    BolumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolumAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProgramTuruID = table.Column<int>(type: "int", nullable: true),
                    OgretimTuruID = table.Column<int>(type: "int", nullable: true),
                    BolumFakulteID = table.Column<int>(type: "int", nullable: true),
                    OgrenimDiliID = table.Column<int>(type: "int", nullable: true),
                    WebAdresi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolum", x => x.BolumID);
                    table.ForeignKey(
                        name: "FK_Bolum_Fakulte",
                        column: x => x.BolumFakulteID,
                        principalTable: "Fakulte",
                        principalColumn: "FakulteID");
                    table.ForeignKey(
                        name: "FK_Bolum_OgrenimDili",
                        column: x => x.OgrenimDiliID,
                        principalTable: "OgrenimDili",
                        principalColumn: "OgrenimDiliID");
                    table.ForeignKey(
                        name: "FK_Bolum_OgretimTuru",
                        column: x => x.OgretimTuruID,
                        principalTable: "OgretimTuru",
                        principalColumn: "OgretimTuruID");
                    table.ForeignKey(
                        name: "FK_Bolum_ProgramTuru",
                        column: x => x.ProgramTuruID,
                        principalTable: "ProgramTuru",
                        principalColumn: "ProgramTuruID");
                });

            migrationBuilder.CreateTable(
                name: "Ogrenci",
                columns: table => new
                {
                    OgrenciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolumID = table.Column<int>(type: "int", nullable: true),
                    OgrenciDurumID = table.Column<int>(type: "int", nullable: true),
                    KullaniciID = table.Column<int>(type: "int", nullable: true),
                    OgrenciNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    KayitTarihi = table.Column<DateTime>(type: "date", nullable: true),
                    AyrilmaTarihi = table.Column<DateTime>(type: "date", nullable: true),
                    Adi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Soyadi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TCKimlikNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CinsiyetID = table.Column<int>(type: "int", nullable: true),
                    DogumTarihi = table.Column<DateTime>(type: "date", nullable: true),
                    Fotograf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TelefonNumarasi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GANO = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenci", x => x.OgrenciID);
                    table.ForeignKey(
                        name: "FK_Ogrenci_Bolum",
                        column: x => x.BolumID,
                        principalTable: "Bolum",
                        principalColumn: "BolumID");
                    table.ForeignKey(
                        name: "FK_Ogrenci_Cinsiyet",
                        column: x => x.CinsiyetID,
                        principalTable: "Cinsiyet",
                        principalColumn: "CinsiyetID");
                    table.ForeignKey(
                        name: "FK_Ogrenci_Kullanici",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanici",
                        principalColumn: "KullaniciID");
                    table.ForeignKey(
                        name: "FK_Ogrenci_OgrenciDurum",
                        column: x => x.OgrenciDurumID,
                        principalTable: "OgrenciDurum",
                        principalColumn: "OgrenciDurumID");
                });

            migrationBuilder.CreateTable(
                name: "OgretimElemani",
                columns: table => new
                {
                    OgretimElemaniID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolumID = table.Column<int>(type: "int", nullable: true),
                    KullaniciID = table.Column<int>(type: "int", nullable: true),
                    UnvanID = table.Column<int>(type: "int", nullable: true),
                    KurumSicilNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Adi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Soyadi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TCKimlikNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CinsiyetID = table.Column<int>(type: "int", nullable: true),
                    DogumTarihi = table.Column<DateTime>(type: "date", nullable: true),
                    Fotograf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgretimElemani", x => x.OgretimElemaniID);
                    table.ForeignKey(
                        name: "FK_OgretimElemani_Bolum",
                        column: x => x.BolumID,
                        principalTable: "Bolum",
                        principalColumn: "BolumID");
                    table.ForeignKey(
                        name: "FK_OgretimElemani_Cinsiyet",
                        column: x => x.CinsiyetID,
                        principalTable: "Cinsiyet",
                        principalColumn: "CinsiyetID");
                    table.ForeignKey(
                        name: "FK_OgretimElemani_Kullanici",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanici",
                        principalColumn: "KullaniciID");
                    table.ForeignKey(
                        name: "FK_OgretimElemani_Unvan",
                        column: x => x.UnvanID,
                        principalTable: "Unvan",
                        principalColumn: "UnvanID");
                });

            migrationBuilder.CreateTable(
                name: "Yandal",
                columns: table => new
                {
                    YandalID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YandalBolumID = table.Column<int>(type: "int", nullable: false),
                    YandalOgrenciID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yandal", x => x.YandalID);
                    table.ForeignKey(
                        name: "FK_Yandal_Bolum",
                        column: x => x.YandalBolumID,
                        principalTable: "Bolum",
                        principalColumn: "BolumID");
                });

            migrationBuilder.CreateTable(
                name: "Danismanlik",
                columns: table => new
                {
                    DanismanlikID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrElmID = table.Column<int>(type: "int", nullable: true),
                    OgrenciID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Danismanlik", x => x.DanismanlikID);
                    table.ForeignKey(
                        name: "FK_Danismanlik_Ogrenci",
                        column: x => x.OgrenciID,
                        principalTable: "Ogrenci",
                        principalColumn: "OgrenciID");
                    table.ForeignKey(
                        name: "FK_Danismanlik_OgretimElemani",
                        column: x => x.OgrElmID,
                        principalTable: "OgretimElemani",
                        principalColumn: "OgretimElemaniID");
                });

            migrationBuilder.CreateTable(
                name: "Degerlendirme",
                columns: table => new
                {
                    DegerlendirmeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SinavID = table.Column<int>(type: "int", nullable: true),
                    OgrenciID = table.Column<int>(type: "int", nullable: true),
                    SinavNotu = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Degerlendirme", x => x.DegerlendirmeID);
                    table.ForeignKey(
                        name: "FK_Degerlendirme_Ogrenci",
                        column: x => x.OgrenciID,
                        principalTable: "Ogrenci",
                        principalColumn: "OgrenciID");
                });

            migrationBuilder.CreateTable(
                name: "DersAcma",
                columns: table => new
                {
                    DersAcmaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkademikYilID = table.Column<int>(type: "int", nullable: true),
                    AkademikDonemID = table.Column<int>(type: "int", nullable: true),
                    MufredatID = table.Column<int>(type: "int", nullable: true),
                    OgrElmID = table.Column<int>(type: "int", nullable: true),
                    Kontejan = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersAcma", x => x.DersAcmaID);
                    table.ForeignKey(
                        name: "FK_DersAcma_AkademikDonem",
                        column: x => x.AkademikDonemID,
                        principalTable: "AkademikDonem",
                        principalColumn: "AkademikDonemID");
                    table.ForeignKey(
                        name: "FK_DersAcma_AkademikYil",
                        column: x => x.AkademikYilID,
                        principalTable: "AkademikYil",
                        principalColumn: "AkademikYilID");
                    table.ForeignKey(
                        name: "FK_DersAcma_OgretimElemani",
                        column: x => x.OgrElmID,
                        principalTable: "OgretimElemani",
                        principalColumn: "OgretimElemaniID");
                });

            migrationBuilder.CreateTable(
                name: "DersAlma",
                columns: table => new
                {
                    DersAlmaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersAcmaID = table.Column<int>(type: "int", nullable: true),
                    OgrenciID = table.Column<int>(type: "int", nullable: true),
                    DersAlmaDurumID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersAlma", x => x.DersAlmaID);
                    table.ForeignKey(
                        name: "FK_DersAlma_DersAcma",
                        column: x => x.DersAcmaID,
                        principalTable: "DersAcma",
                        principalColumn: "DersAcmaID");
                    table.ForeignKey(
                        name: "FK_DersAlma_DersAlmaDurumu",
                        column: x => x.DersAlmaDurumID,
                        principalTable: "DersAlmaDurumu",
                        principalColumn: "DersAlmaDurumID");
                    table.ForeignKey(
                        name: "FK_DersAlma_Ogrenci",
                        column: x => x.OgrenciID,
                        principalTable: "Ogrenci",
                        principalColumn: "OgrenciID");
                });

            migrationBuilder.CreateTable(
                name: "DersProgrami",
                columns: table => new
                {
                    DersProgramiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersAcmaID = table.Column<int>(type: "int", nullable: true),
                    DerslikID = table.Column<int>(type: "int", nullable: true),
                    DersGunuID = table.Column<int>(type: "int", nullable: true),
                    DersSaatiID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersProgrami", x => x.DersProgramiID);
                    table.ForeignKey(
                        name: "FK_DersProgrami_DersAcma",
                        column: x => x.DersAcmaID,
                        principalTable: "DersAcma",
                        principalColumn: "DersAcmaID");
                    table.ForeignKey(
                        name: "FK_DersProgrami_DersGunu",
                        column: x => x.DersGunuID,
                        principalTable: "DersGunu",
                        principalColumn: "DersGunuID");
                    table.ForeignKey(
                        name: "FK_DersProgrami_DersSaati",
                        column: x => x.DersSaatiID,
                        principalTable: "DersSaati",
                        principalColumn: "DersSaatiID");
                    table.ForeignKey(
                        name: "FK_DersProgrami_Derslik",
                        column: x => x.DerslikID,
                        principalTable: "Derslik",
                        principalColumn: "DerslikID");
                });

            migrationBuilder.CreateTable(
                name: "Sinav",
                columns: table => new
                {
                    SinavID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersAcmaID = table.Column<int>(type: "int", nullable: true),
                    SinavTuruID = table.Column<int>(type: "int", nullable: true),
                    DerslikID = table.Column<int>(type: "int", nullable: true),
                    OgrElmID = table.Column<int>(type: "int", nullable: true),
                    EtkiOrani = table.Column<int>(type: "int", nullable: true),
                    SinavTarihi = table.Column<DateTime>(type: "date", nullable: true),
                    SinavSaati = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sinav", x => x.SinavID);
                    table.ForeignKey(
                        name: "FK_Sinav_DersAcma",
                        column: x => x.DersAcmaID,
                        principalTable: "DersAcma",
                        principalColumn: "DersAcmaID");
                    table.ForeignKey(
                        name: "FK_Sinav_Derslik",
                        column: x => x.DerslikID,
                        principalTable: "Derslik",
                        principalColumn: "DerslikID");
                    table.ForeignKey(
                        name: "FK_Sinav_OgretimElemani",
                        column: x => x.OgrElmID,
                        principalTable: "OgretimElemani",
                        principalColumn: "OgretimElemaniID");
                    table.ForeignKey(
                        name: "FK_Sinav_SinavTuru",
                        column: x => x.SinavTuruID,
                        principalTable: "SinavTuru",
                        principalColumn: "SinavTuruID");
                });

            migrationBuilder.CreateTable(
                name: "DersHavuzu",
                columns: table => new
                {
                    DersID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersDiliID = table.Column<int>(type: "int", nullable: true),
                    DersSeviyesiID = table.Column<int>(type: "int", nullable: true),
                    DersTuruID = table.Column<int>(type: "int", nullable: true),
                    DersKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DersAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Teorik = table.Column<int>(type: "int", nullable: true),
                    Uygulama = table.Column<int>(type: "int", nullable: true),
                    Kredi = table.Column<float>(type: "real", nullable: true),
                    ECTS = table.Column<int>(type: "int", nullable: true),
                    DersAlmaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersHavuzu", x => x.DersID);
                    table.ForeignKey(
                        name: "FK_DersHavuzu_DersAlma_DersAlmaId",
                        column: x => x.DersAlmaId,
                        principalTable: "DersAlma",
                        principalColumn: "DersAlmaID");
                    table.ForeignKey(
                        name: "FK_DersHavuzu_DersDili",
                        column: x => x.DersDiliID,
                        principalTable: "DersDili",
                        principalColumn: "DersDiliID");
                    table.ForeignKey(
                        name: "FK_DersHavuzu_DersSeviyesi",
                        column: x => x.DersSeviyesiID,
                        principalTable: "DersSeviyesi",
                        principalColumn: "DersSeviyesiID");
                    table.ForeignKey(
                        name: "FK_DersHavuzu_DerslikTuru",
                        column: x => x.DersTuruID,
                        principalTable: "DerslikTuru",
                        principalColumn: "DerslikTuruID");
                });

            migrationBuilder.CreateTable(
                name: "Mufredat",
                columns: table => new
                {
                    MufredatID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolumID = table.Column<int>(type: "int", nullable: true),
                    AkademikYiIID = table.Column<int>(type: "int", nullable: true),
                    AkademikDonemID = table.Column<int>(type: "int", nullable: true),
                    DersID = table.Column<int>(type: "int", nullable: true),
                    DersDonemi = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mufredat", x => x.MufredatID);
                    table.ForeignKey(
                        name: "FK_Mufredat_AkademikDonem",
                        column: x => x.AkademikDonemID,
                        principalTable: "AkademikDonem",
                        principalColumn: "AkademikDonemID");
                    table.ForeignKey(
                        name: "FK_Mufredat_AkademikYil",
                        column: x => x.AkademikYiIID,
                        principalTable: "AkademikYil",
                        principalColumn: "AkademikYilID");
                    table.ForeignKey(
                        name: "FK_Mufredat_Bolum",
                        column: x => x.BolumID,
                        principalTable: "Bolum",
                        principalColumn: "BolumID");
                    table.ForeignKey(
                        name: "FK_Mufredat_DersHavuzu",
                        column: x => x.DersID,
                        principalTable: "DersHavuzu",
                        principalColumn: "DersID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bolum_BolumFakulteID",
                table: "Bolum",
                column: "BolumFakulteID");

            migrationBuilder.CreateIndex(
                name: "IX_Bolum_OgrenimDiliID",
                table: "Bolum",
                column: "OgrenimDiliID");

            migrationBuilder.CreateIndex(
                name: "IX_Bolum_OgretimTuruID",
                table: "Bolum",
                column: "OgretimTuruID");

            migrationBuilder.CreateIndex(
                name: "IX_Bolum_ProgramTuruID",
                table: "Bolum",
                column: "ProgramTuruID");

            migrationBuilder.CreateIndex(
                name: "IX_Danismanlik_OgrElmID",
                table: "Danismanlik",
                column: "OgrElmID");

            migrationBuilder.CreateIndex(
                name: "IX_Danismanlik_OgrenciID",
                table: "Danismanlik",
                column: "OgrenciID");

            migrationBuilder.CreateIndex(
                name: "IX_Degerlendirme_OgrenciID",
                table: "Degerlendirme",
                column: "OgrenciID");

            migrationBuilder.CreateIndex(
                name: "IX_Degerlendirme_SinavID",
                table: "Degerlendirme",
                column: "SinavID");

            migrationBuilder.CreateIndex(
                name: "IX_DersAcma_AkademikDonemID",
                table: "DersAcma",
                column: "AkademikDonemID");

            migrationBuilder.CreateIndex(
                name: "IX_DersAcma_AkademikYilID",
                table: "DersAcma",
                column: "AkademikYilID");

            migrationBuilder.CreateIndex(
                name: "IX_DersAcma_MufredatID",
                table: "DersAcma",
                column: "MufredatID");

            migrationBuilder.CreateIndex(
                name: "IX_DersAcma_OgrElmID",
                table: "DersAcma",
                column: "OgrElmID");

            migrationBuilder.CreateIndex(
                name: "IX_DersAlma_DersAcmaID",
                table: "DersAlma",
                column: "DersAcmaID");

            migrationBuilder.CreateIndex(
                name: "IX_DersAlma_DersAlmaDurumID",
                table: "DersAlma",
                column: "DersAlmaDurumID");

            migrationBuilder.CreateIndex(
                name: "IX_DersAlma_OgrenciID",
                table: "DersAlma",
                column: "OgrenciID");

            migrationBuilder.CreateIndex(
                name: "IX_DersHavuzu_DersAlmaId",
                table: "DersHavuzu",
                column: "DersAlmaId");

            migrationBuilder.CreateIndex(
                name: "IX_DersHavuzu_DersDiliID",
                table: "DersHavuzu",
                column: "DersDiliID");

            migrationBuilder.CreateIndex(
                name: "IX_DersHavuzu_DersSeviyesiID",
                table: "DersHavuzu",
                column: "DersSeviyesiID");

            migrationBuilder.CreateIndex(
                name: "IX_DersHavuzu_DersTuruID",
                table: "DersHavuzu",
                column: "DersTuruID");

            migrationBuilder.CreateIndex(
                name: "IX_Derslik_DerslikTuruID",
                table: "Derslik",
                column: "DerslikTuruID");

            migrationBuilder.CreateIndex(
                name: "IX_DersProgrami_DersAcmaID",
                table: "DersProgrami",
                column: "DersAcmaID");

            migrationBuilder.CreateIndex(
                name: "IX_DersProgrami_DersGunuID",
                table: "DersProgrami",
                column: "DersGunuID");

            migrationBuilder.CreateIndex(
                name: "IX_DersProgrami_DerslikID",
                table: "DersProgrami",
                column: "DerslikID");

            migrationBuilder.CreateIndex(
                name: "IX_DersProgrami_DersSaatiID",
                table: "DersProgrami",
                column: "DersSaatiID");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_KullaniciTuruID",
                table: "Kullanici",
                column: "KullaniciTuruID");

            migrationBuilder.CreateIndex(
                name: "IX_Mufredat_AkademikDonemID",
                table: "Mufredat",
                column: "AkademikDonemID");

            migrationBuilder.CreateIndex(
                name: "IX_Mufredat_AkademikYiIID",
                table: "Mufredat",
                column: "AkademikYiIID");

            migrationBuilder.CreateIndex(
                name: "IX_Mufredat_BolumID",
                table: "Mufredat",
                column: "BolumID");

            migrationBuilder.CreateIndex(
                name: "IX_Mufredat_DersID",
                table: "Mufredat",
                column: "DersID");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenci_BolumID",
                table: "Ogrenci",
                column: "BolumID");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenci_CinsiyetID",
                table: "Ogrenci",
                column: "CinsiyetID");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenci_KullaniciID",
                table: "Ogrenci",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenci_OgrenciDurumID",
                table: "Ogrenci",
                column: "OgrenciDurumID");

            migrationBuilder.CreateIndex(
                name: "IX_OgretimElemani_BolumID",
                table: "OgretimElemani",
                column: "BolumID");

            migrationBuilder.CreateIndex(
                name: "IX_OgretimElemani_CinsiyetID",
                table: "OgretimElemani",
                column: "CinsiyetID");

            migrationBuilder.CreateIndex(
                name: "IX_OgretimElemani_KullaniciID",
                table: "OgretimElemani",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_OgretimElemani_UnvanID",
                table: "OgretimElemani",
                column: "UnvanID");

            migrationBuilder.CreateIndex(
                name: "IX_Sinav_DersAcmaID",
                table: "Sinav",
                column: "DersAcmaID");

            migrationBuilder.CreateIndex(
                name: "IX_Sinav_DerslikID",
                table: "Sinav",
                column: "DerslikID");

            migrationBuilder.CreateIndex(
                name: "IX_Sinav_OgrElmID",
                table: "Sinav",
                column: "OgrElmID");

            migrationBuilder.CreateIndex(
                name: "IX_Sinav_SinavTuruID",
                table: "Sinav",
                column: "SinavTuruID");

            migrationBuilder.CreateIndex(
                name: "IX_Yandal_YandalBolumID",
                table: "Yandal",
                column: "YandalBolumID");

            migrationBuilder.AddForeignKey(
                name: "FK_Degerlendirme_Sinav",
                table: "Degerlendirme",
                column: "SinavID",
                principalTable: "Sinav",
                principalColumn: "SinavID");

            migrationBuilder.AddForeignKey(
                name: "FK_DersAcma_Mufredat",
                table: "DersAcma",
                column: "MufredatID",
                principalTable: "Mufredat",
                principalColumn: "MufredatID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bolum_Fakulte",
                table: "Bolum");

            migrationBuilder.DropForeignKey(
                name: "FK_Bolum_OgrenimDili",
                table: "Bolum");

            migrationBuilder.DropForeignKey(
                name: "FK_Bolum_OgretimTuru",
                table: "Bolum");

            migrationBuilder.DropForeignKey(
                name: "FK_Bolum_ProgramTuru",
                table: "Bolum");

            migrationBuilder.DropForeignKey(
                name: "FK_DersAlma_Ogrenci",
                table: "DersAlma");

            migrationBuilder.DropForeignKey(
                name: "FK_DersAcma_OgretimElemani",
                table: "DersAcma");

            migrationBuilder.DropForeignKey(
                name: "FK_DersAcma_AkademikDonem",
                table: "DersAcma");

            migrationBuilder.DropForeignKey(
                name: "FK_Mufredat_AkademikDonem",
                table: "Mufredat");

            migrationBuilder.DropForeignKey(
                name: "FK_DersAcma_AkademikYil",
                table: "DersAcma");

            migrationBuilder.DropForeignKey(
                name: "FK_Mufredat_AkademikYil",
                table: "Mufredat");

            migrationBuilder.DropForeignKey(
                name: "FK_DersAcma_Mufredat",
                table: "DersAcma");

            migrationBuilder.DropTable(
                name: "Danismanlik");

            migrationBuilder.DropTable(
                name: "Degerlendirme");

            migrationBuilder.DropTable(
                name: "DersProgrami");

            migrationBuilder.DropTable(
                name: "DersTuru");

            migrationBuilder.DropTable(
                name: "Yandal");

            migrationBuilder.DropTable(
                name: "Sinav");

            migrationBuilder.DropTable(
                name: "DersGunu");

            migrationBuilder.DropTable(
                name: "DersSaati");

            migrationBuilder.DropTable(
                name: "Derslik");

            migrationBuilder.DropTable(
                name: "SinavTuru");

            migrationBuilder.DropTable(
                name: "Fakulte");

            migrationBuilder.DropTable(
                name: "OgrenimDili");

            migrationBuilder.DropTable(
                name: "OgretimTuru");

            migrationBuilder.DropTable(
                name: "ProgramTuru");

            migrationBuilder.DropTable(
                name: "Ogrenci");

            migrationBuilder.DropTable(
                name: "OgrenciDurum");

            migrationBuilder.DropTable(
                name: "OgretimElemani");

            migrationBuilder.DropTable(
                name: "Cinsiyet");

            migrationBuilder.DropTable(
                name: "Kullanici");

            migrationBuilder.DropTable(
                name: "Unvan");

            migrationBuilder.DropTable(
                name: "KullaniciTuru");

            migrationBuilder.DropTable(
                name: "AkademikDonem");

            migrationBuilder.DropTable(
                name: "AkademikYil");

            migrationBuilder.DropTable(
                name: "Mufredat");

            migrationBuilder.DropTable(
                name: "Bolum");

            migrationBuilder.DropTable(
                name: "DersHavuzu");

            migrationBuilder.DropTable(
                name: "DersAlma");

            migrationBuilder.DropTable(
                name: "DersDili");

            migrationBuilder.DropTable(
                name: "DersSeviyesi");

            migrationBuilder.DropTable(
                name: "DerslikTuru");

            migrationBuilder.DropTable(
                name: "DersAcma");

            migrationBuilder.DropTable(
                name: "DersAlmaDurumu");
        }
    }
}
