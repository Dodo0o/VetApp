using System;
using VetApp.Models;

namespace VetApp.Model
{
    public class Asi
    {
        public int AsiID { get; set; }
        public int HayvanID { get; set; }
        public string AsiAdi { get; set; }
        public DateTime Tarih { get; set; }
        public Hayvan Hayvan { get; set; }
    }
}
