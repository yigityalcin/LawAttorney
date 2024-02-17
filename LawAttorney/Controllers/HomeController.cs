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
        public IActionResult IndexEng()
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
        public IActionResult Makale1()
        {
            return View();
        }
        public IActionResult Makale2()
        {
            return View();
        }
        public IActionResult Makale3()
        {
            return View();
        }
        public IActionResult Makale4()
        {
            return View();
        }
        public IActionResult Makale5()
        {
            return View();
        }
        public IActionResult Makale6()
        {
            return View();
        }
        public IActionResult Makale7()
        {
            return View();
        }
        public IActionResult Makale8()
        {
            return View();
        }
        public IActionResult Makale9()
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
