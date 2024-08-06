using System.Linq;
using VetApp.Model;
using VetApp.Models;

namespace VetApp.Services
{
    public class GirisService
    {
        private readonly VetAppContext _context;

        public GirisService(VetAppContext context)
        {
            _context = context;
        }

        public Musteri MusteriGiris(string tckimlik, string sifre)
        {
            return _context.Musteriler.FirstOrDefault(m => m.TCKimlik == tckimlik && m.Sifre == sifre);
        }

        public Veteriner VeterinerGiris(string tckimlik, string sifre)
        {
            return _context.Veterinerler.FirstOrDefault(v => v.TCKimlik == tckimlik && v.Sifre == sifre);
        }
    }
}
