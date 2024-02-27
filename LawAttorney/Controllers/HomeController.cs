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
            return View("HomeEng/IndexEng");
        }
        public IActionResult IndexRu()
        {
            return View("HomeRu/IndexRu");
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
        public IActionResult Corporate()
        {
            return View("HomeEng/Corporate");
        }
        public IActionResult OurTeam()
        {
            return View("HomeEng/OurTeam");
        }
        public IActionResult PracticeAreas()
        {
            return View("HomeEng/PracticeAreas");
        }
        public IActionResult Articles()
        {
            return View("HomeEng/Articles");
        }
        public IActionResult Article1()
        {
            return View("HomeEng/Article1");
        }
        public IActionResult Article2()
        {
            return View("HomeEng/Article2");
        }
        public IActionResult Article3()
        {
            return View("HomeEng/Article3");
        }
        public IActionResult Article4()
        {
            return View("HomeEng/Article4");
        }
        public IActionResult Article5()
        {
            return View("HomeEng/Article5");
        }
        public IActionResult Article6()
        {
            return View("HomeEng/Article6");
        }
        public IActionResult Article7()
        {
            return View("HomeEng/Article7");
        }
        public IActionResult Article8()
        {
            return View("HomeEng/Article8");
        }
        public IActionResult Article9()
        {
            return View("HomeEng/Article9");
        }
        public IActionResult Contact()
        {
            return View("HomeEng/Contact");
        }

        public IActionResult CorporateRu()
        {
            return View("HomeRu/CorporateRu");
        }
        public IActionResult OurTeamRu()
        {
            return View("HomeRu/OurTeamRu");
        }
        public IActionResult PracticeAreasRu()
        {
            return View("HomeRu/PracticeAreasRu");
        }
        public IActionResult ArticlesRu()
        {
            return View("HomeRu/ArticlesRu");
        }
        public IActionResult Article1Ru()
        {
            return View("HomeRu/Article1Ru");
        }
        public IActionResult Article2Ru()
        {
            return View("HomeRu/Article2Ru");
        }
        public IActionResult Article3Ru()
        {
            return View("HomeRu/Article3Ru");
        }
        public IActionResult Article4Ru()
        {
            return View("HomeRu/Article4Ru");
        }
        public IActionResult Article5Ru()
        {
            return View("HomeRu/Article5Ru");
        }
        public IActionResult Article6Ru()
        {
            return View("HomeRu/Article6Ru");
        }
        public IActionResult Article7Ru()
        {
            return View("HomeRu/Article7Ru");
        }
        public IActionResult Article8Ru()
        {
            return View("HomeRu/Article8Ru");
        }
        public IActionResult Article9Ru()
        {
            return View("HomeRu/Article9Ru");
        }
        public IActionResult ContactRu()
        {
            return View("HomeRu/ContactRu");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
