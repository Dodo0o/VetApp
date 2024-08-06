using System.Collections.Generic;
using System.Linq;
using VetApp;
using VetApp.Model;
using VetApp.Models;

public class MusteriService
{
    private readonly VetAppContext _context;

    public MusteriService(VetAppContext context)
    {
        _context = context;
    }

    public List<Musteri> GetAllMusteriler()
    {
        return _context.Musteriler.ToList();
    }
    public Musteri GetMusteriById(int id)
    {
        return _context.Musteriler.FirstOrDefault(m => m.MusteriID == id);
    }
    public void AddMusteri(Musteri musteri)
    {
        _context.Musteriler.Add(musteri);
        _context.SaveChanges();
    }

    public void UpdateMusteri(Musteri musteri)
    {
        _context.Musteriler.Update(musteri);
        _context.SaveChanges();
    }

    public void DeleteMusteri(int id)
    {
        var musteri = _context.Musteriler.Find(id);
        if (musteri != null)
        {
            _context.Musteriler.Remove(musteri);
            _context.SaveChanges();
        }
    }

}
