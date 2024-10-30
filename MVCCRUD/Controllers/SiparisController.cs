using Microsoft.AspNetCore.Mvc;
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

        [HttpPost]
        public IActionResult Create(Siparis siparis)
        {
            _context.Siparisler.Add(siparis);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
