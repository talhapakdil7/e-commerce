using e_commerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_commerce.Controllers
{
    public class KategoriController : Controller
    {
        private readonly DataContext _context;

        public KategoriController(DataContext context)
        {
            _context = context;
        }
        

        public IActionResult Index()
        {

            var kategoriler = _context.Kategoriler.Select(i=> new KategoriGetModel
            {
              Id = i.Id,
              KategoriAdi = i.KategoriAdi,
              Url = i.Url,
              UrunSayisi = i.Uruns.Count()  


            }).ToList();
             
             


            return View(kategoriler);
        }
    }
}