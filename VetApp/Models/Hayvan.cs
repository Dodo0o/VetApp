using System;
using System.Collections.Generic;
using VetApp.Model;

namespace VetApp.Models
{
    public class Hayvan
    {
        public int HayvanID { get; set; }
        public int MusteriID { get; set; }
        public string HayvanAdi { get; set; }
        public string Tur { get; set; }
        public string Cins { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string? ResimYolu { get; set; } // Yeni alan
        public Musteri Musteri { get; set; }
        public ICollection<Randevu> Randevular { get; set; }
        public ICollection<TibbiKayit> TibbiKayitlar { get; set; }
        public ICollection<Asi> Asilar { get; set; }
        public string MusteriAdiSoyadi
        {
            get
            {
                return Musteri != null ? $"{Musteri.Ad} {Musteri.Soyad}" : "Bilinmiyor";
            }
        }
    }

}
