using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Repository.Models
{
	public class SliderItem:BaseEntity
	{
		public int OrderBy { get; set; }
		[Required]
		[MaxLength(100)]
		public string Title { get; set; }
		[Required]
		[MaxLength(150)]
		public string Slogan { get; set; }

		[Required]
		[MaxLength(150)]
		public string Image { get; set; }

		[Required]
		[MaxLength(50)]
		public string ActionText { get; set; }

		[Required]
		[MaxLength(200)]
        public string EndPoint { get; set; }
	}
}
