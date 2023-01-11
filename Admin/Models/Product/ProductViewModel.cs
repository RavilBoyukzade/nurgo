using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Admin.Models.Product
{
	public class ProductViewModel
	{
		public int Id { get; set; }
		public bool Status { get; set; }
		[Required]
		[MaxLength(50)]
		public string CarName { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Range(0.1,double.MaxValue)]
        public decimal Price { get; set; }
        [Required]
        public string Marka { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string BodyStyle { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public string Condition { get; set; }
        [Required]
        public string Killometer { get; set; }
        [Required]
        public string İnteryer { get; set; }
        [Required]
        public string Transmissiya { get; set; }
        [Required]
        public string Engine { get; set; }
        [Required]
        public string FuelType { get; set; }
		public IList<ProductPhotoViiewModel> Photos { get; set; }
		public IList<ProductFutureViewModel> Futures { get; set; }
	}
}
