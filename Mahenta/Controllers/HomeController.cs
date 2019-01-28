using Microsoft.AspNetCore.Mvc;

namespace Mahenta
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
