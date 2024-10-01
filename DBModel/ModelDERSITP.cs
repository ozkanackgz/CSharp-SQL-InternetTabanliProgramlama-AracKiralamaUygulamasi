using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DBModel
{
    public partial class ModelDERSITP : DbContext
    {
        public ModelDERSITP()
            : base("name=ConnectionStr")
        {
        }

        public virtual DbSet<ARACLAR> ARACLAR { get; set; }
        public virtual DbSet<FILO> FILO { get; set; }
        public virtual DbSet<KULLANICI> KULLANICI { get; set; }
        public virtual DbSet<MUSTERILER> MUSTERILER { get; set; }
        public virtual DbSet<REF_SINIFI> REF_SINIFI { get; set; }
        public virtual DbSet<V_ARACLAR> V_ARACLAR { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ARACLAR>()
                .Property(e => e.MARKA)
                .IsUnicode(false);

            modelBuilder.Entity<ARACLAR>()
                .Property(e => e.MODEL)
                .IsUnicode(false);

            modelBuilder.Entity<ARACLAR>()
                .Property(e => e.GUNLUKFIYAT)
                .HasPrecision(8, 2);

            modelBuilder.Entity<ARACLAR>()
                .Property(e => e.ACIKLAMA)
                .IsUnicode(false);

            modelBuilder.Entity<ARACLAR>()
                .HasMany(e => e.FILO)
                .WithRequired(e => e.ARACLAR)
                .HasForeignKey(e => e.ID_ARACLAR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FILO>()
                .Property(e => e.KONUMBAS)
                .IsUnicode(false);

            modelBuilder.Entity<FILO>()
                .Property(e => e.KONUMBIT)
                .IsUnicode(false);

            modelBuilder.Entity<FILO>()
                .Property(e => e.FIYAT)
                .HasPrecision(8, 2);

            modelBuilder.Entity<KULLANICI>()
                .Property(e => e.KULLANICIADI)
                .IsUnicode(false);

            modelBuilder.Entity<KULLANICI>()
                .Property(e => e.SIFRE)
                .IsUnicode(false);

            modelBuilder.Entity<KULLANICI>()
                .Property(e => e.ADSOYAD)
                .IsUnicode(false);

            modelBuilder.Entity<KULLANICI>()
                .Property(e => e.EPOSTA)
                .IsUnicode(false);

            modelBuilder.Entity<MUSTERILER>()
                .Property(e => e.AD)
                .IsUnicode(false);

            modelBuilder.Entity<MUSTERILER>()
                .Property(e => e.SOYAD)
                .IsUnicode(false);

            modelBuilder.Entity<MUSTERILER>()
                .Property(e => e.EPOSTA)
                .IsUnicode(false);

            modelBuilder.Entity<MUSTERILER>()
                .HasMany(e => e.FILO)
                .WithRequired(e => e.MUSTERILER)
                .HasForeignKey(e => e.TCNO_MUSTERILER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<REF_SINIFI>()
                .Property(e => e.ARACSINIFI)
                .IsUnicode(false);

            modelBuilder.Entity<REF_SINIFI>()
                .HasMany(e => e.ARACLAR)
                .WithRequired(e => e.REF_SINIFI)
                .HasForeignKey(e => e.KOD_REF_SINIFI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<V_ARACLAR>()
                .Property(e => e.ARACSINIFI)
                .IsUnicode(false);

            modelBuilder.Entity<V_ARACLAR>()
                .Property(e => e.MARKA)
                .IsUnicode(false);

            modelBuilder.Entity<V_ARACLAR>()
                .Property(e => e.MODEL)
                .IsUnicode(false);

            modelBuilder.Entity<V_ARACLAR>()
                .Property(e => e.GUNLUKFIYAT)
                .HasPrecision(8, 2);

            modelBuilder.Entity<V_ARACLAR>()
                .Property(e => e.ACIKLAMA)
                .IsUnicode(false);

            modelBuilder.Entity<V_ARACLAR>()
                .Property(e => e.VITES_ACIKLAMA)
                .IsUnicode(false);

            modelBuilder.Entity<V_ARACLAR>()
                .Property(e => e.UYGUN_ACIKLAMA)
                .IsUnicode(false);
        }
    }
}
