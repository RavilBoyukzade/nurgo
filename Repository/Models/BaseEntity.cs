﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
	public class BaseEntity
	{
		public int Id { get; set; }
		public bool Status { get; set; }
		public DateTime AddedDate { get; set; }
		public DateTime ModifiedDate { get; set; }

		[MaxLength(50)]
		public string AddedBy { get; set; }

		[MaxLength(50)]
		public string ModifiedBy { get; set; }
	}
}
