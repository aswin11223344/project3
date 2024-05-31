using Microsoft.AspNetCore.Mvc;

namespace Modalproject.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult login()
        {
            return View();
        }
    }
}
