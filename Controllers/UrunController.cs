using e_commerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace e_commerce.Controllers
{
    public class UrunController : Controller
    {

        private readonly DataContext _context;

        public UrunController(DataContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            var urunler = _context.Urunler.Where(i => i.Aktif).ToList();
            return View(urunler);
        }
        
        public ActionResult Details(int id)
        {
            // var urun = _context.Urunler.FirstOrDefault(i => i.Id == id && i.Aktif);
            var urun = _context.Urunler.Find(id);
            return View(urun);
        }


    }
}