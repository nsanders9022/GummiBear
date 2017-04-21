using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GummiBear.Models;


namespace GummiBear.Controllers
{
    public class ProductsController : Controller
    {
        private GummiBearDbContext db = new GummiBearDbContext();
        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }
    }
}
