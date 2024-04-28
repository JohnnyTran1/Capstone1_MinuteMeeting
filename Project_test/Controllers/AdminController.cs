using Microsoft.AspNetCore.Mvc;

namespace Project_test.Controllers
{
	public class AdminController : Controller
	{
		public IActionResult CreateProject()
		{
			return View();
		}

		public IActionResult EditProject()
		{
			return View();
		}
		public IActionResult ViewProjects()
		{
			return View();
		}

		public IActionResult ManageProject()
		{
			return View();
		}

		public IActionResult CreateUser()
		{
			return View();
		}
		public IActionResult MeetingMinutes_View()
		{
			return View();
		}

		public IActionResult Login_View()
		{
			return View();
		}

		[HttpPost]
		public IActionResult GoHome()
		{

			return RedirectToAction("ViewProjects", "Admin");
		}

		[HttpPost]
		public IActionResult GoMeetingMinutes()
		{

			return RedirectToAction("MeetingMinutes_View", "Admin");
		}
	}
}