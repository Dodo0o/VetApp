using System.Collections.Generic;
using System.Linq;
using VetApp.Model;
using VetApp.Models;

namespace VetApp.Services
{
    public class TibbiKayitService
    {
        private readonly VetAppContext _context;

        public TibbiKayitService(VetAppContext context)
        {
            _context = context;
        }

        public List<TibbiKayit> GetTibbiKayitlarByHayvanID(int hayvanID)
        {
            return _context.TibbiKayitlar.Where(t => t.HayvanID == hayvanID).ToList();
        }

        public void AddTibbiKayit(TibbiKayit tibbiKayit)
        {
            _context.TibbiKayitlar.Add(tibbiKayit);
            _context.SaveChanges();
        }

        public void UpdateTibbiKayit(TibbiKayit tibbiKayit)
        {
            _context.TibbiKayitlar.Update(tibbiKayit);
            _context.SaveChanges();
        }

        public void DeleteTibbiKayit(int tibbiKayitID)
        {
            var tibbiKayit = _context.TibbiKayitlar.Find(tibbiKayitID);
            if (tibbiKayit != null)
            {
                _context.TibbiKayitlar.Remove(tibbiKayit);
                _context.SaveChanges();
            }
        }
    }
}
