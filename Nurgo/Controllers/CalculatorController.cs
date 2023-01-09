using Microsoft.AspNetCore.Mvc;

namespace Nurgo.Controllers
{
	public class CalculatorController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
