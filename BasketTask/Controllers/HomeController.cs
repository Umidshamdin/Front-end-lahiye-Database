using BasketTask.Data;
using BasketTask.Models;
using BasketTask.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;

        }


        public async Task<IActionResult> Index()
        {
            List<DesignCard> designCards = await _context.DesignCards.ToListAsync();
            List<OwlCarusel> owlCarusels = await _context.OwlCarusels.ToListAsync();

            HomeVM homeVM = new HomeVM
            {
                DesignCards=designCards,
                OwlCarusels=owlCarusels
            };


            return View(homeVM);
        }

      
    }
}
