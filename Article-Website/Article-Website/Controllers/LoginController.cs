using Microsoft.AspNetCore.Mvc;

namespace Article_Website.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
