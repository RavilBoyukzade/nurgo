using System.ComponentModel.DataAnnotations;

namespace Admin.Models.Product
{
	public class ProductPhotoViiewModel
	{
		public int OrderBy { get; set; }
		public int ProductId { get; set; }
		public string Image { get; set; }
	}
}
