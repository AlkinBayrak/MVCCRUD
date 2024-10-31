using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCCRUD.Context;
using MVCCRUD.Entities.Concrete;

namespace MVCCRUD.Controllers
{
    public class SiparisController : Controller
    {
        private readonly MyDbContext _context;
        public SiparisController(MyDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var model = _context.Siparisler.Include(s=>s.Musteri).Include(m=>m.Urun).ToList();

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.UrunId = new SelectList(_context.Urunler, "Id", "UrunAdi");
            ViewBag.MusteriId = new SelectList(_context.Musteriler, "Id", "Ad");

            return View();
        }

        [HttpPost]
        public IActionResult Create(Siparis siparis)
        {
            _context.Siparisler.Add(siparis);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            Siparis siparis = _context.Siparisler.Where(s => s.Id == id).FirstOrDefault();
            ViewBag.mSiparis = new SelectList(_context.Musteriler, "Id", "Ad", siparis.MusteriId);
            ViewBag.uSiparis = new SelectList(_context.Urunler, "Id", "UrunAdi", siparis.UrunId);

            return View(siparis);
        }

        [HttpPost]
        public IActionResult Edit(Siparis siparis)
        {
            _context.Siparisler.Update(siparis);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            Siparis siparis = _context.Siparisler.Where(c => c.Id == id).FirstOrDefault();

            _context.Siparisler.Remove(siparis);
            _context.SaveChanges();


            return RedirectToAction(nameof(Index));
        }
    }
}
