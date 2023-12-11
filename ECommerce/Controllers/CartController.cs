using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
	public class CartController : Controller
	{
		public IActionResult AddProduct()
		{
			return View();
		}

		public IActionResult Edit()
		{
			return View();
		}
	}
}
