using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
	public class Setting:BaseEntity
	{
		[Required]
		[MaxLength(150)]
		public string NavLogo { get; set; }

		[Required]
		[MaxLength(150)]
		public string FooterLogo { get; set; }

		[Required]
		[MaxLength(200)]
		public string Adress { get; set; }

		[Required]
		[MaxLength(100)]
		public string WpPhone { get; set; }

		[Required]
		[MaxLength(100)]
		public string Email { get; set; }
	}
}
