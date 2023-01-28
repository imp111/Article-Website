using Microsoft.AspNetCore.Mvc;

namespace Article_Website.Controllers
{
    public class CreateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
