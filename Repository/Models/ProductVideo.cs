using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
	public class ProductVideo:BaseEntity
	{
		public int OrderBy { get; set; }

		public int ProductId { get; set; }

		[Required]
		[MaxLength(100)]
		public string Video { get; set; }

		public Product Product { get; set; }
	}
}
