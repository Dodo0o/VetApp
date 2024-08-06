using System.Collections.Generic;
using System.Linq;
using VetApp.Model;
using VetApp.Models;

namespace VetApp.Services
{
    public class AsiService
    {
        private readonly VetAppContext _context;

        public AsiService(VetAppContext context)
        {
            _context = context;
        }

        public List<Asi> GetAsilarByHayvanID(int hayvanID)
        {
            return _context.Asilar.Where(a => a.HayvanID == hayvanID).ToList();
        }

        public void AddAsi(Asi asi)
        {
            _context.Asilar.Add(asi);
            _context.SaveChanges();
        }

        public void UpdateAsi(Asi asi)
        {
            _context.Asilar.Update(asi);
            _context.SaveChanges();
        }

        public void DeleteAsi(int asiID)
        {
            var asi = _context.Asilar.Find(asiID);
            if (asi != null)
            {
                _context.Asilar.Remove(asi);
                _context.SaveChanges();
            }
        }
    }
}
