using Eshop.Web.Areas.Admin.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.web.Areas.Admin.Controllers
{
  
    public class HomeController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
