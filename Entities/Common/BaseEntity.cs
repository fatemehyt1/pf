using System.ComponentModel.DataAnnotations;

namespace Portfolio.web.Entities.Common
{
	public class BaseEntity
	{
		[Key]
        public int Id { get; set; }
    }
}
