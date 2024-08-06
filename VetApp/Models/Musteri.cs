using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetApp.Models;

namespace VetApp.Model
{
    public class Musteri
    {
        public int MusteriID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
        public string TCKimlik { get; set; }
        public string Sifre { get; set; }
        public ICollection<Randevu> Randevular { get; set; }
        public ICollection<Hayvan> Hayvanlar { get; set; }

        public string AdSoyad => $"{Ad} {Soyad}";
    }

}
