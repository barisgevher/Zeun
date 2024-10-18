using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Zeun.Web.Models;

namespace Zeun.Web.Data;

public partial class OgrenciDbContext : DbContext
{
    public OgrenciDbContext()
    {
    }

    public OgrenciDbContext(DbContextOptions<OgrenciDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AkademikDonem> AkademikDonems { get; set; }

    public virtual DbSet<AkademikYil> AkademikYils { get; set; }

    public virtual DbSet<Bolum> Bolums { get; set; }

    public virtual DbSet<Cinsiyet> Cinsiyets { get; set; }

    public virtual DbSet<Danismanlik> Danismanliks { get; set; }

    public virtual DbSet<Degerlendirme> Degerlendirmes { get; set; }

    public virtual DbSet<DersAcma> DersAcmas { get; set; }

    public virtual DbSet<DersAlma> DersAlmas { get; set; }

    public virtual DbSet<DersAlmaDurumu> DersAlmaDurumus { get; set; }

    public virtual DbSet<DersDili> DersDilis { get; set; }

    public virtual DbSet<DersGunu> DersGunus { get; set; }

    public virtual DbSet<DersHavuzu> DersHavuzus { get; set; }

    public virtual DbSet<DersProgrami> DersProgramis { get; set; }

    public virtual DbSet<DersSaati> DersSaatis { get; set; }

    public virtual DbSet<DersSeviyesi> DersSeviyesis { get; set; }

    public virtual DbSet<DersTuru> DersTurus { get; set; }

    public virtual DbSet<Derslik> Dersliks { get; set; }

    public virtual DbSet<DerslikTuru> DerslikTurus { get; set; }

    public virtual DbSet<Fakulte> Fakultes { get; set; }

    public virtual DbSet<Kullanici> Kullanicis { get; set; }

    public virtual DbSet<KullaniciTuru> KullaniciTurus { get; set; }

    public virtual DbSet<Mufredat> Mufredats { get; set; }

    public virtual DbSet<Ogrenci> Ogrencis { get; set; }

    public virtual DbSet<OgrenciDurum> OgrenciDurums { get; set; }

    public virtual DbSet<OgrenimDili> OgrenimDilis { get; set; }

    public virtual DbSet<OgretimElemani> OgretimElemanis { get; set; }

    public virtual DbSet<OgretimTuru> OgretimTurus { get; set; }

    public virtual DbSet<ProgramTuru> ProgramTurus { get; set; }

    public virtual DbSet<Sinav> Sinavs { get; set; }

    public virtual DbSet<SinavTuru> SinavTurus { get; set; }

    public virtual DbSet<Unvan> Unvans { get; set; }

    public virtual DbSet<Yandal> Yandals { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer("Your Sql connection string");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AkademikDonem>(entity =>
        {
            entity.ToTable("AkademikDonem");

            entity.Property(e => e.AkademikDonemId).HasColumnName("AkademikDonemID");
            entity.Property(e => e.AkademikDonem1)
                .HasMaxLength(50)
                .HasColumnName("AkademikDonem");
        });

        modelBuilder.Entity<AkademikYil>(entity =>
        {
            entity.ToTable("AkademikYil");

            entity.Property(e => e.AkademikYilId).HasColumnName("AkademikYilID");
            entity.Property(e => e.AkademikYil1)
                .HasMaxLength(50)
                .HasColumnName("AkademikYil");
        });

        modelBuilder.Entity<Bolum>(entity =>
        {
            entity.ToTable("Bolum");

            entity.Property(e => e.BolumId).HasColumnName("BolumID");
            entity.Property(e => e.BolumAdi).HasMaxLength(50);
            entity.Property(e => e.BolumFakulteId).HasColumnName("BolumFakulteID");
            entity.Property(e => e.OgrenimDiliId).HasColumnName("OgrenimDiliID");
            entity.Property(e => e.OgretimTuruId).HasColumnName("OgretimTuruID");
            entity.Property(e => e.ProgramTuruId).HasColumnName("ProgramTuruID");
            entity.Property(e => e.WebAdresi).HasMaxLength(50);

            entity.HasOne(d => d.BolumFakulte).WithMany(p => p.Bolums)
                .HasForeignKey(d => d.BolumFakulteId)
                .HasConstraintName("FK_Bolum_Fakulte");

            entity.HasOne(d => d.OgrenimDili).WithMany(p => p.Bolums)
                .HasForeignKey(d => d.OgrenimDiliId)
                .HasConstraintName("FK_Bolum_OgrenimDili");

            entity.HasOne(d => d.OgretimTuru).WithMany(p => p.Bolums)
                .HasForeignKey(d => d.OgretimTuruId)
                .HasConstraintName("FK_Bolum_OgretimTuru");

            entity.HasOne(d => d.ProgramTuru).WithMany(p => p.Bolums)
                .HasForeignKey(d => d.ProgramTuruId)
                .HasConstraintName("FK_Bolum_ProgramTuru");
        });

        modelBuilder.Entity<Cinsiyet>(entity =>
        {
            entity.ToTable("Cinsiyet");

            entity.Property(e => e.CinsiyetId).HasColumnName("CinsiyetID");
            entity.Property(e => e.CinsiyetAdi).HasMaxLength(50);
        });

        modelBuilder.Entity<Danismanlik>(entity =>
        {
            entity.ToTable("Danismanlik");

            entity.Property(e => e.DanismanlikId).HasColumnName("DanismanlikID");
            entity.Property(e => e.OgrElmId).HasColumnName("OgrElmID");
            entity.Property(e => e.OgrenciId).HasColumnName("OgrenciID");

            entity.HasOne(d => d.OgrElm).WithMany(p => p.Danismanliks)
                .HasForeignKey(d => d.OgrElmId)
                .HasConstraintName("FK_Danismanlik_OgretimElemani");

            entity.HasOne(d => d.Ogrenci).WithMany(p => p.Danismanliks)
                .HasForeignKey(d => d.OgrenciId)
                .HasConstraintName("FK_Danismanlik_Ogrenci");
        });

        modelBuilder.Entity<Degerlendirme>(entity =>
        {
            entity.ToTable("Degerlendirme");

            entity.Property(e => e.DegerlendirmeId).HasColumnName("DegerlendirmeID");
            entity.Property(e => e.OgrenciId).HasColumnName("OgrenciID");
            entity.Property(e => e.SinavId).HasColumnName("SinavID");

            entity.HasOne(d => d.Ogrenci).WithMany(p => p.Degerlendirmes)
                .HasForeignKey(d => d.OgrenciId)
                .HasConstraintName("FK_Degerlendirme_Ogrenci");

            entity.HasOne(d => d.Sinav).WithMany(p => p.Degerlendirmes)
                .HasForeignKey(d => d.SinavId)
                .HasConstraintName("FK_Degerlendirme_Sinav");
        });

        modelBuilder.Entity<DersAcma>(entity =>
        {
            entity.ToTable("DersAcma");

            entity.Property(e => e.DersAcmaId).HasColumnName("DersAcmaID");
            entity.Property(e => e.AkademikDonemId).HasColumnName("AkademikDonemID");
            entity.Property(e => e.AkademikYilId).HasColumnName("AkademikYilID");
            entity.Property(e => e.MufredatId).HasColumnName("MufredatID");
            entity.Property(e => e.OgrElmId).HasColumnName("OgrElmID");

            entity.HasOne(d => d.AkademikDonem).WithMany(p => p.DersAcmas)
                .HasForeignKey(d => d.AkademikDonemId)
                .HasConstraintName("FK_DersAcma_AkademikDonem");

            entity.HasOne(d => d.AkademikYil).WithMany(p => p.DersAcmas)
                .HasForeignKey(d => d.AkademikYilId)
                .HasConstraintName("FK_DersAcma_AkademikYil");

            entity.HasOne(d => d.Mufredat).WithMany(p => p.DersAcmas)
                .HasForeignKey(d => d.MufredatId)
                .HasConstraintName("FK_DersAcma_Mufredat");

            entity.HasOne(d => d.OgrElm).WithMany(p => p.DersAcmas)
                .HasForeignKey(d => d.OgrElmId)
                .HasConstraintName("FK_DersAcma_OgretimElemani");
        });

        modelBuilder.Entity<DersAlma>(entity =>
        {
            entity.ToTable("DersAlma");

            entity.Property(e => e.DersAlmaId).HasColumnName("DersAlmaID");
            entity.Property(e => e.DersAcmaId).HasColumnName("DersAcmaID");
            entity.Property(e => e.DersAlmaDurumId).HasColumnName("DersAlmaDurumID");
            entity.Property(e => e.OgrenciId).HasColumnName("OgrenciID");

            entity.HasOne(d => d.DersAcma).WithMany(p => p.DersAlmas)
                .HasForeignKey(d => d.DersAcmaId)
                .HasConstraintName("FK_DersAlma_DersAcma");

            entity.HasOne(d => d.DersAlmaDurum).WithMany(p => p.DersAlmas)
                .HasForeignKey(d => d.DersAlmaDurumId)
                .HasConstraintName("FK_DersAlma_DersAlmaDurumu");

            entity.HasOne(d => d.Ogrenci).WithMany(p => p.DersAlmas)
                .HasForeignKey(d => d.OgrenciId)
                .HasConstraintName("FK_DersAlma_Ogrenci");
        });

        modelBuilder.Entity<DersAlmaDurumu>(entity =>
        {
            entity.HasKey(e => e.DersAlmaDurumId);

            entity.ToTable("DersAlmaDurumu");

            entity.Property(e => e.DersAlmaDurumId).HasColumnName("DersAlmaDurumID");
            entity.Property(e => e.DersAlmaDurumu1)
                .HasMaxLength(50)
                .HasColumnName("DersAlmaDurumu");
        });

        modelBuilder.Entity<DersDili>(entity =>
        {
            entity.ToTable("DersDili");

            entity.Property(e => e.DersDiliId).HasColumnName("DersDiliID");
            entity.Property(e => e.DersDili1)
                .HasMaxLength(50)
                .HasColumnName("DersDili");
        });

        modelBuilder.Entity<DersGunu>(entity =>
        {
            entity.ToTable("DersGunu");

            entity.Property(e => e.DersGunuId).HasColumnName("DersGunuID");
            entity.Property(e => e.DersGunu1)
                .HasMaxLength(50)
                .HasColumnName("DersGunu");
        });

        modelBuilder.Entity<DersHavuzu>(entity =>
        {
            entity.HasKey(e => e.DersId);

            entity.ToTable("DersHavuzu");

            entity.Property(e => e.DersId).HasColumnName("DersID");
            entity.Property(e => e.DersAdi).HasMaxLength(50);
            entity.Property(e => e.DersDiliId).HasColumnName("DersDiliID");
            entity.Property(e => e.DersKodu).HasMaxLength(50);
            entity.Property(e => e.DersSeviyesiId).HasColumnName("DersSeviyesiID");
            entity.Property(e => e.DersTuruId).HasColumnName("DersTuruID");
            entity.Property(e => e.Ects).HasColumnName("ECTS");

            entity.HasOne(d => d.DersDili).WithMany(p => p.DersHavuzus)
                .HasForeignKey(d => d.DersDiliId)
                .HasConstraintName("FK_DersHavuzu_DersDili");

            entity.HasOne(d => d.DersSeviyesi).WithMany(p => p.DersHavuzus)
                .HasForeignKey(d => d.DersSeviyesiId)
                .HasConstraintName("FK_DersHavuzu_DersSeviyesi");

            entity.HasOne(d => d.DersTuru).WithMany(p => p.DersHavuzus)
                .HasForeignKey(d => d.DersTuruId)
                .HasConstraintName("FK_DersHavuzu_DerslikTuru");

     


        });

        modelBuilder.Entity<DersProgrami>(entity =>
        {
            entity.ToTable("DersProgrami");

            entity.Property(e => e.DersProgramiId).HasColumnName("DersProgramiID");
            entity.Property(e => e.DersAcmaId).HasColumnName("DersAcmaID");
            entity.Property(e => e.DersGunuId).HasColumnName("DersGunuID");
            entity.Property(e => e.DersSaatiId).HasColumnName("DersSaatiID");
            entity.Property(e => e.DerslikId).HasColumnName("DerslikID");

            entity.HasOne(d => d.DersAcma).WithMany(p => p.DersProgramis)
                .HasForeignKey(d => d.DersAcmaId)
                .HasConstraintName("FK_DersProgrami_DersAcma");

            entity.HasOne(d => d.DersGunu).WithMany(p => p.DersProgramis)
                .HasForeignKey(d => d.DersGunuId)
                .HasConstraintName("FK_DersProgrami_DersGunu");

            entity.HasOne(d => d.DersSaati).WithMany(p => p.DersProgramis)
                .HasForeignKey(d => d.DersSaatiId)
                .HasConstraintName("FK_DersProgrami_DersSaati");

            entity.HasOne(d => d.Derslik).WithMany(p => p.DersProgramis)
                .HasForeignKey(d => d.DerslikId)
                .HasConstraintName("FK_DersProgrami_Derslik");
        });

        modelBuilder.Entity<DersSaati>(entity =>
        {
            entity.ToTable("DersSaati");

            entity.Property(e => e.DersSaatiId).HasColumnName("DersSaatiID");
            entity.Property(e => e.DersSaati1)
                .HasMaxLength(50)
                .HasColumnName("DersSaati");
        });

        modelBuilder.Entity<DersSeviyesi>(entity =>
        {
            entity.ToTable("DersSeviyesi");

            entity.Property(e => e.DersSeviyesiId).HasColumnName("DersSeviyesiID");
            entity.Property(e => e.DersSeviyesi1)
                .HasMaxLength(50)
                .HasColumnName("DersSeviyesi");
        });

        modelBuilder.Entity<DersTuru>(entity =>
        {
            entity.ToTable("DersTuru");

            entity.Property(e => e.DersTuruId).HasColumnName("DersTuruID");
            entity.Property(e => e.DersTuru1)
                .HasMaxLength(50)
                .HasColumnName("DersTuru");
        });

        modelBuilder.Entity<Derslik>(entity =>
        {
            entity.ToTable("Derslik");

            entity.Property(e => e.DerslikId).HasColumnName("DerslikID");
            entity.Property(e => e.DerslikAdi).HasMaxLength(50);
            entity.Property(e => e.DerslikTuruId).HasColumnName("DerslikTuruID");

            entity.HasOne(d => d.DerslikTuru).WithMany(p => p.Dersliks)
                .HasForeignKey(d => d.DerslikTuruId)
                .HasConstraintName("FK_Derslik_DerslikTuru");
        });

        modelBuilder.Entity<DerslikTuru>(entity =>
        {
            entity.ToTable("DerslikTuru");

            entity.Property(e => e.DerslikTuruId).HasColumnName("DerslikTuruID");
            entity.Property(e => e.DerslikTuruAdi).HasMaxLength(50);
        });

        modelBuilder.Entity<Fakulte>(entity =>
        {
            entity.ToTable("Fakulte");

            entity.Property(e => e.FakulteId).HasColumnName("FakulteID");
            entity.Property(e => e.FakulteAdi).HasMaxLength(250);
        });

        modelBuilder.Entity<Kullanici>(entity =>
        {
            entity.ToTable("Kullanici");

            entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");
            entity.Property(e => e.KullaniciAdi).HasMaxLength(50);
            entity.Property(e => e.KullaniciTuruId).HasColumnName("KullaniciTuruID");
            entity.Property(e => e.Parola).HasMaxLength(50);

            entity.HasOne(d => d.KullaniciTuru).WithMany(p => p.Kullanicis)
                .HasForeignKey(d => d.KullaniciTuruId)
                .HasConstraintName("FK_Kullanici_KullaniciTuru");
        });

        modelBuilder.Entity<KullaniciTuru>(entity =>
        {
            entity.HasKey(e => e.KullaniciTurId);

            entity.ToTable("KullaniciTuru");

            entity.Property(e => e.KullaniciTurId).HasColumnName("KullaniciTurID");
            entity.Property(e => e.KullaniciTurAdi).HasMaxLength(50);
        });

        modelBuilder.Entity<Mufredat>(entity =>
        {
            entity.ToTable("Mufredat");

            entity.Property(e => e.MufredatId).HasColumnName("MufredatID");
            entity.Property(e => e.AkademikDonemId).HasColumnName("AkademikDonemID");
            entity.Property(e => e.AkademikYiIid).HasColumnName("AkademikYiIID");
            entity.Property(e => e.BolumId).HasColumnName("BolumID");
            entity.Property(e => e.DersId).HasColumnName("DersID");

            entity.HasOne(d => d.AkademikDonem).WithMany(p => p.Mufredats)
                .HasForeignKey(d => d.AkademikDonemId)
                .HasConstraintName("FK_Mufredat_AkademikDonem");

            entity.HasOne(d => d.AkademikYiI).WithMany(p => p.Mufredats)
                .HasForeignKey(d => d.AkademikYiIid)
                .HasConstraintName("FK_Mufredat_AkademikYil");

            entity.HasOne(d => d.Bolum).WithMany(p => p.Mufredats)
                .HasForeignKey(d => d.BolumId)
                .HasConstraintName("FK_Mufredat_Bolum");

            entity.HasOne(d => d.Ders).WithMany(p => p.Mufredats)
                .HasForeignKey(d => d.DersId)
                .HasConstraintName("FK_Mufredat_DersHavuzu");
        });

        modelBuilder.Entity<Ogrenci>(entity =>
        {
            entity.ToTable("Ogrenci");

            entity.Property(e => e.OgrenciId).HasColumnName("OgrenciID");
            entity.Property(e => e.Adi).HasMaxLength(50);
            entity.Property(e => e.Adres).HasMaxLength(150);
            entity.Property(e => e.AyrilmaTarihi).HasColumnType("date");
            entity.Property(e => e.BolumId).HasColumnName("BolumID");
            entity.Property(e => e.CinsiyetId).HasColumnName("CinsiyetID");
            entity.Property(e => e.DogumTarihi).HasColumnType("date");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Gano).HasColumnName("GANO");
            entity.Property(e => e.KayitTarihi).HasColumnType("date");
            entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");
            entity.Property(e => e.OgrenciDurumId).HasColumnName("OgrenciDurumID");
            entity.Property(e => e.OgrenciNo).HasMaxLength(50);
            entity.Property(e => e.Soyadi).HasMaxLength(50);
            entity.Property(e => e.TckimlikNo)
                .HasMaxLength(50)
                .HasColumnName("TCKimlikNo");
            entity.Property(e => e.TelefonNumarasi).HasMaxLength(50);

            entity.HasOne(d => d.Bolum).WithMany(p => p.Ogrencis)
                .HasForeignKey(d => d.BolumId)
                .HasConstraintName("FK_Ogrenci_Bolum");

            entity.HasOne(d => d.Cinsiyet).WithMany(p => p.Ogrencis)
                .HasForeignKey(d => d.CinsiyetId)
                .HasConstraintName("FK_Ogrenci_Cinsiyet");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.Ogrencis)
                .HasForeignKey(d => d.KullaniciId)
                .HasConstraintName("FK_Ogrenci_Kullanici");

            entity.HasOne(d => d.OgrenciDurum).WithMany(p => p.Ogrencis)
                .HasForeignKey(d => d.OgrenciDurumId)
                .HasConstraintName("FK_Ogrenci_OgrenciDurum");
        });

        modelBuilder.Entity<OgrenciDurum>(entity =>
        {
            entity.ToTable("OgrenciDurum");

            entity.Property(e => e.OgrenciDurumId).HasColumnName("OgrenciDurumID");
            entity.Property(e => e.OgrenciDurumu).HasMaxLength(50);
        });

        modelBuilder.Entity<OgrenimDili>(entity =>
        {
            entity.ToTable("OgrenimDili");

            entity.Property(e => e.OgrenimDiliId).HasColumnName("OgrenimDiliID");
            entity.Property(e => e.OgrenimDili1)
                .HasMaxLength(50)
                .HasColumnName("OgrenimDili");
        });

        modelBuilder.Entity<OgretimElemani>(entity =>
        {
            entity.ToTable("OgretimElemani");

            entity.Property(e => e.OgretimElemaniId).HasColumnName("OgretimElemaniID");
            entity.Property(e => e.Adi).HasMaxLength(50);
            entity.Property(e => e.Adres).HasMaxLength(150);
            entity.Property(e => e.BolumId).HasColumnName("BolumID");
            entity.Property(e => e.CinsiyetId).HasColumnName("CinsiyetID");
            entity.Property(e => e.DogumTarihi).HasColumnType("date");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");
            entity.Property(e => e.KurumSicilNo).HasMaxLength(50);
            entity.Property(e => e.Soyadi).HasMaxLength(50);
            entity.Property(e => e.TckimlikNo)
                .HasMaxLength(50)
                .HasColumnName("TCKimlikNo");
            entity.Property(e => e.Telefon).HasMaxLength(50);
            entity.Property(e => e.UnvanId).HasColumnName("UnvanID");

            entity.HasOne(d => d.Bolum).WithMany(p => p.OgretimElemanis)
                .HasForeignKey(d => d.BolumId)
                .HasConstraintName("FK_OgretimElemani_Bolum");

            entity.HasOne(d => d.Cinsiyet).WithMany(p => p.OgretimElemanis)
                .HasForeignKey(d => d.CinsiyetId)
                .HasConstraintName("FK_OgretimElemani_Cinsiyet");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.OgretimElemanis)
                .HasForeignKey(d => d.KullaniciId)
                .HasConstraintName("FK_OgretimElemani_Kullanici");

            entity.HasOne(d => d.Unvan).WithMany(p => p.OgretimElemanis)
                .HasForeignKey(d => d.UnvanId)
                .HasConstraintName("FK_OgretimElemani_Unvan");
        });

        modelBuilder.Entity<OgretimTuru>(entity =>
        {
            entity.ToTable("OgretimTuru");

            entity.Property(e => e.OgretimTuruId).HasColumnName("OgretimTuruID");
            entity.Property(e => e.OgretimTurAdi).HasMaxLength(50);
        });

        modelBuilder.Entity<ProgramTuru>(entity =>
        {
            entity.ToTable("ProgramTuru");

            entity.Property(e => e.ProgramTuruId).HasColumnName("ProgramTuruID");
            entity.Property(e => e.ProgramTurAdi).HasMaxLength(50);
        });

        modelBuilder.Entity<Sinav>(entity =>
        {
            entity.ToTable("Sinav");

            entity.Property(e => e.SinavId).HasColumnName("SinavID");
            entity.Property(e => e.DersAcmaId).HasColumnName("DersAcmaID");
            entity.Property(e => e.DerslikId).HasColumnName("DerslikID");
            entity.Property(e => e.OgrElmId).HasColumnName("OgrElmID");
            entity.Property(e => e.SinavSaati).HasColumnType("date");
            entity.Property(e => e.SinavTarihi).HasColumnType("date");
            entity.Property(e => e.SinavTuruId).HasColumnName("SinavTuruID");

            entity.HasOne(d => d.DersAcma).WithMany(p => p.Sinavs)
                .HasForeignKey(d => d.DersAcmaId)
                .HasConstraintName("FK_Sinav_DersAcma");

            entity.HasOne(d => d.Derslik).WithMany(p => p.Sinavs)
                .HasForeignKey(d => d.DerslikId)
                .HasConstraintName("FK_Sinav_Derslik");

            entity.HasOne(d => d.OgrElm).WithMany(p => p.Sinavs)
                .HasForeignKey(d => d.OgrElmId)
                .HasConstraintName("FK_Sinav_OgretimElemani");

            entity.HasOne(d => d.SinavTuru).WithMany(p => p.Sinavs)
                .HasForeignKey(d => d.SinavTuruId)
                .HasConstraintName("FK_Sinav_SinavTuru");
        });

        modelBuilder.Entity<SinavTuru>(entity =>
        {
            entity.ToTable("SinavTuru");

            entity.Property(e => e.SinavTuruId).HasColumnName("SinavTuruID");
            entity.Property(e => e.SinavTuru1)
                .HasMaxLength(50)
                .HasColumnName("SinavTuru");
        });

        modelBuilder.Entity<Unvan>(entity =>
        {
            entity.ToTable("Unvan");

            entity.Property(e => e.UnvanId).HasColumnName("UnvanID");
            entity.Property(e => e.UnvanAdi).HasMaxLength(50);
        });

        modelBuilder.Entity<Yandal>(entity =>
        {
            entity.ToTable("Yandal");

            entity.Property(e => e.YandalId).HasColumnName("YandalID");
            entity.Property(e => e.YandalBolumId).HasColumnName("YandalBolumID");
            entity.Property(e => e.YandalOgrenciId).HasColumnName("YandalOgrenciID");

            entity.HasOne(d => d.YandalBolum).WithMany(p => p.Yandals)
                .HasForeignKey(d => d.YandalBolumId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Yandal_Bolum");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
