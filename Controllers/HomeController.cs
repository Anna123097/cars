using cars.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace cars.Controllers
{
    public class HomeController : Controller
    {
        Database db = new Database();

        public IActionResult Index()
        {
            return View(db.GetCar());


        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Benz()
        {
            return View(db.GetCarByToplevo("бензин"));
        }
        public IActionResult Elect()
        {
            return View(db.GetCarByToplevo("электро"));

        }
        public IActionResult Dizel()
        {
            return View(db.GetCarByToplevo("дизель"));

        }
        public IActionResult GetElectById(int id)
        {
            return View(db.GetCarById(id));
        }
        public IActionResult GetDizelById(int id)
        {
            return View(db.GetCarById(id));
        }
        public IActionResult GetBenzById(int id)
        {
            return View(db.GetCarById(id));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
