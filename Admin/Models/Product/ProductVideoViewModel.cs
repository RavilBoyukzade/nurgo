using System.ComponentModel.DataAnnotations;

namespace Admin.Models.Product
{
	public class ProductVideoViewModel
	{
		public int OrderBy { get; set; }
		public int ProductId { get; set; }
		public string Video { get; set; }
	}
}
