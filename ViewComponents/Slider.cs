using e_commerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace  e_commerce.ViewComponents
{
    public class Slider : ViewComponent
    {

        private readonly DataContext _context;

        public Slider(DataContext context)
        {
            _context = context;
        }

     public IViewComponentResult Invoke()
        {
            
            var sliderlar = _context.Sliderlar.Where(i => i.Aktif).OrderBy(i => i.Index).ToList();
            return View(sliderlar);
        }

    }
}