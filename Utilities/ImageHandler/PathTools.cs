namespace Portfolio.web.Utilities.ImageHandler
{
    public static class PathTools
    {
        #region Products

        public static string CatalogImage = "/images/catalogs/";
        public static string CatalogImageAbs = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/catalogs/");
        public static string CatalogImageThumb = "/images/catalogs/thumbs/";
        public static string CatalogImageThumbAbs = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/catalogs/thumbs/");

        #endregion
    }
}