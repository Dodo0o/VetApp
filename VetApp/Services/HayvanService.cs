using System.Collections.Generic;
using System.Linq;
using System.IO;
using VetApp.Models;
using Microsoft.EntityFrameworkCore;

namespace VetApp.Services
{
    public class HayvanService
    {
        private readonly VetAppContext _context;

        public HayvanService(VetAppContext context)
        {
            _context = context;
        }

        public List<Hayvan> GetAllHayvanlar()
        {
            return _context.Hayvanlar.Include(h => h.Musteri).ToList();
        }

        public List<Hayvan> GetHayvanlarByMusteriID(int musteriID)
        {
            return _context.Hayvanlar.Where(h => h.MusteriID == musteriID).ToList();
        }

        public Hayvan GetHayvanById(int id)
        {
            return _context.Hayvanlar.FirstOrDefault(h => h.HayvanID == id);
        }

        public void AddHayvan(Hayvan hayvan, string resimDosyaYolu)
        {
            if (!string.IsNullOrEmpty(resimDosyaYolu))
            {
                string hedefDizin = Path.Combine("wwwroot", "resimler");
                if (!Directory.Exists(hedefDizin))
                {
                    Directory.CreateDirectory(hedefDizin);
                }

                string hedefYol = Path.Combine(hedefDizin, Path.GetFileName(resimDosyaYolu));
                File.Copy(resimDosyaYolu, hedefYol, true);
                hayvan.ResimYolu = hedefYol;
            }

            _context.Hayvanlar.Add(hayvan);
            _context.SaveChanges();
        }

        public void UpdateHayvan(Hayvan hayvan, string resimDosyaYolu)
        {
            if (!string.IsNullOrEmpty(resimDosyaYolu))
            {
                string hedefDizin = Path.Combine("wwwroot", "resimler");
                if (!Directory.Exists(hedefDizin))
                {
                    Directory.CreateDirectory(hedefDizin);
                }

                string hedefYol = Path.Combine(hedefDizin, Path.GetFileName(resimDosyaYolu));
                File.Copy(resimDosyaYolu, hedefYol, true);
                hayvan.ResimYolu = hedefYol;
            }

            _context.Hayvanlar.Update(hayvan);
            _context.SaveChanges();
        }

        public void DeleteHayvan(int id)
        {
            var hayvan = _context.Hayvanlar.Find(id);
            if (hayvan != null)
            {
                _context.Hayvanlar.Remove(hayvan);
                _context.SaveChanges();
            }
        }
    }
}
