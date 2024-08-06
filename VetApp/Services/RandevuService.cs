using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using VetApp.Models;

namespace VetApp.Services
{
    public class RandevuService
    {
        private readonly VetAppContext _context;

        public RandevuService(VetAppContext context)
        {
            _context = context;
        }

        public List<Randevu> GetAllRandevular()
        {
            return _context.Randevular
                .Include(r => r.Musteri)
                .Include(r => r.Hayvan)
                .ToList();
        }

        public List<Randevu> GetRandevularByMusteriId(int musteriId)
        {
            return _context.Randevular
                .Where(r => r.MusteriID == musteriId)
                .Include(r => r.Musteri)
                .Include(r => r.Hayvan)
                .ToList();
        }

        public Randevu GetRandevuById(int randevuId)
        {
            return _context.Randevular.Find(randevuId);
        }

        public void AddRandevu(Randevu randevu)
        {
            _context.Randevular.Add(randevu);
            _context.SaveChanges();
        }

        public void UpdateRandevu(Randevu randevu)
        {
            _context.Randevular.Update(randevu);
            _context.SaveChanges();
        }

        public void DeleteRandevu(int id)
        {
            var randevu = _context.Randevular.Find(id);
            if (randevu != null)
            {
                _context.Randevular.Remove(randevu);
                _context.SaveChanges();
            }
        }
    }
}
