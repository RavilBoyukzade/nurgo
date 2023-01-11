using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Models
{
	public class Product :BaseEntity
	{
		[Required]
		[MaxLength(200)]
		public string CarName { get; set; }
		[Required]
		[MaxLength(100)]
		public string Title { get; set; }
		[Required]
		[Column(TypeName = "ntext")]
		public string Description { get; set; }
		[Required]
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
        public ICollection<ProductPhoto> Photos { get; set; }
		public ICollection<ProductFuture> Futures { get; set; }
    }
}
