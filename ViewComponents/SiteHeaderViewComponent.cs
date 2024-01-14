using Microsoft.AspNetCore.Mvc;

namespace Portfolio.web.ViewComponents
{
	public class SiteHeaderViewComponent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{

			return View("SiteHeader");

		}
	}
}
