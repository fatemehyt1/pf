using Microsoft.EntityFrameworkCore;
using Portfolio.web.Entities.Catalogs;
using Portfolio.web.Entities.Product;


namespace Portfolio.web.Context
{
	public class ApplicationDbContext : DbContext 
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }


		public DbSet<Product> Products { get; set; }

		public DbSet<Catalog> Catalogs { get; set; }



	}

}
