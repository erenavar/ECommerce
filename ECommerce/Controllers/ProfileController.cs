using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
	public class ProfileController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
