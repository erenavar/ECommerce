using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
	public class CategoryController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
