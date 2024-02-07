using LawAttorney.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LawAttorney.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Kurumsal()
        {
            return View();
        }
        public IActionResult Ekibimiz()
        {
            return View();
        }
        public IActionResult CalismaAlanlari()
        {
            return View();
        }
        public IActionResult Makaleler()
        {
            return View();
        }
        public IActionResult Ýletisim()
        {
            return View();
        }  

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
