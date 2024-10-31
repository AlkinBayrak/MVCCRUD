using Microsoft.AspNetCore.Mvc;
using MVCCRUD.Context;
using MVCCRUD.Entities.Concrete;

namespace MVCCRUD.Controllers
{
    public class UrunController : Controller
    {
        private readonly MyDbContext _context;

        public UrunController(MyDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var model = _context.Urunler.ToList();

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            

            return View();
        }

        [HttpPost]
        public IActionResult Create(Urun urun)
        {
            _context.Urunler.Add(urun);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }


        public IActionResult Edit(int id)
        {
            Urun urun = _context.Urunler.Where(c => c.Id == id).FirstOrDefault();


            return View(urun);
        }

        [HttpPost]
        public IActionResult Update(Urun urun)
        {

            _context.Urunler.Update(urun);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            Urun urun = _context.Urunler.Where(c => c.Id == id).FirstOrDefault();

            _context.Urunler.Remove(urun);
            _context.SaveChanges();


            return RedirectToAction(nameof(Index));
        }
    }
}
