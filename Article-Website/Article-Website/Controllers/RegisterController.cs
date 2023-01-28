using Microsoft.AspNetCore.Mvc;

namespace Article_Website.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
