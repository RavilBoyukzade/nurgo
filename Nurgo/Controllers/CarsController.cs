using Microsoft.AspNetCore.Mvc;

namespace Nurgo.Controllers
{
	public class CarsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
