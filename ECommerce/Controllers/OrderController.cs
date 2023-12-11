using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
	public class OrderController : Controller
	{
		public IActionResult Create()
		{
			return View();
		}

		public IActionResult Edit()
		{
			return View();
		}
	}
}
