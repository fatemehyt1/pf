using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Portfolio.web.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

    }

}
