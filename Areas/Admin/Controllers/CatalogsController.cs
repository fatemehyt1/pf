using Eshop.Web.Areas.Admin.Controllers;
using Microsoft.AspNetCore.Mvc;
using Portfolio.web.Context;
using Portfolio.web.Entities.Catalogs;
using Portfolio.web.Utilities.ImageHandler;
using Portfolio.web.ViewModels.Catalogs;
using Portfolio.Web.Utilities.ImageHandler;

namespace Portfolio.web.Areas.Admin.Controllers
{
    public class CatalogsController : AdminBaseController
    {


        #region canstractor

        private ApplicationDbContext _context;

        public CatalogsController(ApplicationDbContext context)
        {
            _context = context;

        }
        #endregion

        #region catalogs list
        public IActionResult Index()
        {
            var Catalog = _context.Catalogs.OrderByDescending(c=>c.Id).ToList();
            return View(Catalog);
        }
        #endregion

        #region create 

        [HttpGet]
        public IActionResult CreateCatalog()
        {

            return View();
        }

        [HttpPost]
        public IActionResult CreateCatalog(CreatCatalogsViewModel catalog)
        {
            if (ModelState.IsValid) //برای اعتبار سنجی
            {

                string imageName = Guid.NewGuid().ToString("N") + Path.GetExtension(catalog.Image.FileName);
                catalog.Image.AddImageToServer(imageName, PathTools.CatalogImageAbs, 100, 100, PathTools.CatalogImageThumbAbs);//ذخیره سازی عکس توی ادرسی که نوشتیم 

                var dbcatalog = new Catalog() //برای اینکه یک نمونه ی جدید از کاتالوگ وارد دیتابیس کنیم
                {
                    Title = catalog.Title,
                    Description = catalog.Description,
                    Url = catalog.Url,
                    UrlTitle = catalog.UrlTitle,
                    Image = imageName
                };

                _context.Catalogs.Add(dbcatalog);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(catalog);
        }


        #endregion

    }
}
