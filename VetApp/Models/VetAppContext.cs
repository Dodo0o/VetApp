using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using VetApp.Model;

namespace VetApp.Models
{
    public class VetAppContext : DbContext
    {
        public VetAppContext(DbContextOptions<VetAppContext> options) : base(options) { }

        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Veteriner> Veterinerler { get; set; }
        public DbSet<Hayvan> Hayvanlar { get; set; }
        public DbSet<Randevu> Randevular { get; set; }
        public DbSet<TibbiKayit> TibbiKayitlar { get; set; }
        public DbSet<Asi> Asilar { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Musteri>().ToTable("Musteriler");
            modelBuilder.Entity<Veteriner>().ToTable("Veterinerler");
            modelBuilder.Entity<Hayvan>().ToTable("Hayvanlar");
            modelBuilder.Entity<Randevu>().ToTable("Randevular");
            modelBuilder.Entity<TibbiKayit>().ToTable("TibbiKayitlar");
            modelBuilder.Entity<Asi>().ToTable("Asilar");

            modelBuilder.Entity<Randevu>()
                .HasOne(r => r.Musteri)
                .WithMany(m => m.Randevular)
                .HasForeignKey(r => r.MusteriID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Randevu>()
                .HasOne(r => r.Hayvan)
                .WithMany(h => h.Randevular)
                .HasForeignKey(r => r.HayvanID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TibbiKayit>()
                .HasOne(t => t.Hayvan)
                .WithMany(h => h.TibbiKayitlar)
                .HasForeignKey(t => t.HayvanID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Asi>()
                .HasOne(a => a.Hayvan)
                .WithMany(h => h.Asilar)
                .HasForeignKey(a => a.HayvanID)
                .OnDelete(DeleteBehavior.Cascade);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
                var connectionString = configuration.GetConnectionString("VetAppDB");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
