using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
	public class Advantage:BaseEntity
	{
		[Required]
		[MaxLength(50)]
		public string Icon { get; set; }

		[Required]
		[MaxLength(100)]
		public string Title { get; set; }

		[Required]
		[MaxLength(150)]
		public string Description { get; set; }
	}
}
