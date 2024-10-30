using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCCRUD.Context;
using MVCCRUD.Entities.Concrete;

namespace MVCCRUD.Controllers
{
    public class MusteriController : Controller
    {
        private readonly MyDbContext _context;

        public MusteriController(MyDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var model = _context.Musteriler.ToList();

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Musteri musteri = new Musteri();    

            return View();
        }

        [HttpPost]
        public IActionResult Create(Musteri musteri)
        {
            _context.Musteriler.Add(musteri);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        
        public IActionResult Edit(int id)
        {
            Musteri musteri = _context.Musteriler.Where(c => c.Id == id).FirstOrDefault();

            
            return View(musteri);
        }

        [HttpPost]
        public IActionResult Update(Musteri musteri)
        {
            _context.Musteriler.Update(musteri);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            Musteri musteri = _context.Musteriler.Where(c => c.Id == id).FirstOrDefault();

                _context.Musteriler.Remove(musteri);
                _context.SaveChanges();
            

            return RedirectToAction(nameof(Index));
        }
    }
}
