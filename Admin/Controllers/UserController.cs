using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
	public class UserController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
