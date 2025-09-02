using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using e_commerce.Models;

namespace e_commerce.Controllers;

public class HomeController : Controller
{
    
    private readonly DataContext _context;

        public HomeController(DataContext context)
        {
            _context = context;
        }
         
    public IActionResult Index()
    {

        var urunler = _context.Urunler.Where(i=>i.Anasayfa && i.Aktif).ToList();
        ViewData["Kategoriler"] = _context.Kategoriler.ToList();
        return View(urunler);
    }

  
}
