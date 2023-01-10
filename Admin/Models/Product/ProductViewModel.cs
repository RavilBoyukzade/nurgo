using System.Collections.Generic;

namespace Admin.Models.Product
{
	public class ProductViewModel
	{
		public int Id { get; set; }
		public bool Status { get; set; }
		public string CarName { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public string Marka { get; set; }
		public string Model { get; set; }
		public string BodyStyle { get; set; }
		public string Year { get; set; }
		public string Condition { get; set; }
		public string Killometer { get; set; }
		public string İnteryer { get; set; }
		public string Transmissiya { get; set; }
		public string Engine { get; set; }
		public string FuelType { get; set; }
		public IList<ProductPhotoViiewModel> Photos { get; set; }
		public IList<ProductVideoViewModel> Videos { get; set; }
		public IList<ProductFutureViewModel> Futures { get; set; }
	}
}
