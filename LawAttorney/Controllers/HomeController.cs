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

        public IActionResult Anasayfa()
        {
            return View();
        }
        public IActionResult HomePage()
        {
            return View("en/HomePage");
        }
        public IActionResult HomePageRu()
        {
            return View("ru/HomePageRu");
        }
        public IActionResult Kurumsal()
        {
            return View();
        }
        public IActionResult Ekibimiz()
        {
            return View();
        }
        public IActionResult CalismaAlanlarimiz()
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
        public IActionResult iletisim()
        {
            return View();
        }     
        public IActionResult Corporate()
        {
            return View("en/Corporate");
        }
        public IActionResult OurTeam()
        {
            return View("en/OurTeam");
        }
        public IActionResult PracticeAreas()
        {
            return View("en/PracticeAreas");
        }
        public IActionResult Articles()
        {
            return View("en/Articles");
        }
        public IActionResult Article1()
        {
            return View("en/Article1");
        }
        public IActionResult Article2()
        {
            return View("en/Article2");
        }
        public IActionResult Article3()
        {
            return View("en/Article3");
        }
        public IActionResult Article4()
        {
            return View("en/Article4");
        }
        public IActionResult Article5()
        {
            return View("en/Article5");
        }
        public IActionResult Article6()
        {
            return View("en/Article6");
        }
        public IActionResult Article7()
        {
            return View("en/Article7");
        }
        public IActionResult Article8()
        {
            return View("en/Article8");
        }
        public IActionResult Article9()
        {
            return View("en/Article9");
        }
        public IActionResult Contact()
        {
            return View("en/Contact");
        }

        public IActionResult CorporateRu()
        {
            return View("ru/CorporateRu");
        }
        public IActionResult OurTeamRu()
        {
            return View("ru/OurTeamRu");
        }
        public IActionResult PracticeAreasRu()
        {
            return View("ru/PracticeAreasRu");
        }
        public IActionResult ArticlesRu()
        {
            return View("ru/ArticlesRu");
        }
        public IActionResult Article1Ru()
        {
            return View("ru/Article1Ru");
        }
        public IActionResult Article2Ru()
        {
            return View("ru/Article2Ru");
        }
        public IActionResult Article3Ru()
        {
            return View("ru/Article3Ru");
        }
        public IActionResult Article4Ru()
        {
            return View("ru/Article4Ru");
        }
        public IActionResult Article5Ru()
        {
            return View("ru/Article5Ru");
        }
        public IActionResult Article6Ru()
        {
            return View("ru/Article6Ru");
        }
        public IActionResult Article7Ru()
        {
            return View("ru/Article7Ru");
        }
        public IActionResult Article8Ru()
        {
            return View("ru/Article8Ru");
        }
        public IActionResult Article9Ru()
        {
            return View("ru/Article9Ru");
        }
        public IActionResult ContactRu()
        {
            return View("ru/ContactRu");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
