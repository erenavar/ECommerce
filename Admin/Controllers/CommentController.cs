using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
	public class CommentController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
