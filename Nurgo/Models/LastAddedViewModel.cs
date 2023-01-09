using System.Collections;
using System.Collections.Generic;

namespace Nurgo.Models
{
	public class LastAddedViewModel
	{
		public int Id { get; set; }
		public string CarName { get; set; }
		public decimal Price { get; set; }
		public IList<string> Photos { get; set; }
	}
}
