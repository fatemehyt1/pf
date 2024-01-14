using Microsoft.AspNetCore.Mvc;

namespace Portfolio.web.ViewComponents
{
	public class SiteFooterViewComponent : ViewComponent
	{
     public IViewComponentResult Invoke() 
		{
			
			return View("SiteFooter");
	
		}
	}
}
