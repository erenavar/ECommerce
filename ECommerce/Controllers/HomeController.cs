using ECommerce.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ECommerce.Controllers
{
	public class HomeController : Controller
	{
		#region MyRegion
		//private readonly ILogger<HomeController> _logger;

		//public HomeController(ILogger<HomeController> logger)
		//{
		//	_logger = logger;
		//}

		//public IActionResult Index()
		//{
		//	return View();
		//}

		//public IActionResult Privacy()
		//{
		//	return View();
		//}

		//[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		//public IActionResult Error()
		//{
		//	return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		//} 
		#endregion

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult AboutUs()
		{
			return View();
		}

		public IActionResult Contact()
		{
			return View();
		}

		public IActionResult Listing()
		{
			return View();
		}

		public IActionResult ProductDetail()
		{
			return View();
		}
	}
}