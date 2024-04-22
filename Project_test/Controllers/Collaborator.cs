using Microsoft.AspNetCore.Mvc;
using Project_test.Models;
using System.Diagnostics;

namespace Project_test.Controllers
{
    public class Collaborator : Controller
    {
        public IActionResult MeetingMinutes_View()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login_View()
        {
            return View();
        }
        public IActionResult Home_View()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ViewProjects()
        {
            return View();
        }
        public IActionResult ActionItems_View()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GoHome()
        {

            return RedirectToAction("Home_View", "Collaborator");
        }

        [HttpPost]
        public IActionResult GoMeetingMinutes()
        {

            return RedirectToAction("MeetingMinutes_View", "Collaborator");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
