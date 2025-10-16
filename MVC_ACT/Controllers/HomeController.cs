using Microsoft.AspNetCore.Mvc;

namespace MVC_ACT.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult About() => View();
        public IActionResult Resume() => View();
        public IActionResult Education() => View();
        public IActionResult Experience() => View();
        public IActionResult Skills() => View();
        public IActionResult Projects() => View();
        public IActionResult Hobbies() => View();
        public IActionResult Gallery() => View();
        public IActionResult Contact() => View();
    }
}
