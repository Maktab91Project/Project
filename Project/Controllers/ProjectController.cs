using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
	public class ProjectController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult ProjectDetail()
		{
			return View();
		}
		public IActionResult Resume()
		{
			return View();
		}
		[HttpGet]
		public IActionResult PostResume() 
		{
			return View();
		}
		[HttpGet]
		public IActionResult PostJob() 
		{
			return View();
		}

	}
}
