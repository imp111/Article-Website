using Microsoft.AspNetCore.Mvc;

namespace Article_Website.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
