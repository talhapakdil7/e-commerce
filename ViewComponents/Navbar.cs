using e_commerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace e_commerce.ViewComponents
{

    public class Navbar : ViewComponent
    {

        private readonly DataContext _context;
        
        public Navbar(DataContext context)
        {
            _context = context;
        }


        public IViewComponentResult Invoke()
        {
            var kategoriler = _context.Kategoriler.ToList();
            return View(kategoriler);
        }




    }
}