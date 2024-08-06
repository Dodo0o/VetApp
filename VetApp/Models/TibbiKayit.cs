using System;
using VetApp.Models;

namespace VetApp.Model
{
    public class TibbiKayit
    {
        public int TibbiKayitID { get; set; }
        public int HayvanID { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public Hayvan Hayvan { get; set; }
    }
}
