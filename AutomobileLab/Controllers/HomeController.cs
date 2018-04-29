using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutomobileLab.Model;

namespace AutomobileLab.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context;

        public HomeController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Autos.ToList());
        }

        public IActionResult Delete(long id)
        {
            var result = _context.Autos.Where(x => x.ID == id).First();
            _context.Remove(result);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(long id)
        {
            var res = _context.Autos.Where(x => x.ID == id).First();
            
            return View(res);
        }

        [HttpPost]
        public IActionResult Edit(Auto entity)
        {
            var res = _context.Autos.Where(x => x.ID == entity.ID).First();
            res.ModelName = entity.ModelName;
            res.ModelType = entity.ModelType;
            res.Price = entity.Price;
            res.ProductionYear = entity.ProductionYear;
            res.BackPackType = entity.BackPackType;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(long id)
        {
            return View(_context.Autos.Where(x => x.ID == id));
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Auto auto)
        {
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}