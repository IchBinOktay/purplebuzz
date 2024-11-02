using Microsoft.AspNetCore.Mvc;

namespace Oktay_PurpleBuzz.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
