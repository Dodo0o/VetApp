using VetApp.Model;
using System;
using VetApp.Models;

public class Randevu
{
    public int RandevuID { get; set; }
    public int MusteriID { get; set; }
    public int HayvanID { get; set; }
    public DateTime RandevuTarihi { get; set; }
    public string Notlar { get; set; }

    public Musteri Musteri { get; set; }
    public Hayvan Hayvan { get; set; }
    public string MusteriAdiSoyadi
    {
        get { return Musteri != null ? $"{Musteri.Ad} {Musteri.Soyad}" : "Bilinmiyor"; }
    }

    public string HayvanAdi
    {
        get { return Hayvan != null ? Hayvan.HayvanAdi : "Bilinmiyor"; }
    }
}

