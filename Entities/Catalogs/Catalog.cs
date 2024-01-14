using Portfolio.web.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.web.Entities.Catalogs
{
	public class Catalog : BaseEntity
	{
		[MaxLength(100)]
        public string Title { get; set; }


		[MaxLength(1000)]
		public string Description { get; set; }


		[MaxLength(1000)]
		// url : baraye darj khode url hastesh : http://mohsen.ir
		public string Url { get; set; }


		[MaxLength(1000)]
		// in bataye onvane link hast ke user mibine . // page man ro bebinid"
		public string UrlTitle { get; set; }


		[MaxLength(300)]
		public string? Image { get; set; }




	}
}
