using Microsoft.AspNetCore.Mvc;
using Oktay_PurpleBuzz.Models.About;

namespace Oktay_PurpleBuzz.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            var teamMembers = new List<TeamMemberVM>
            {
                new TeamMemberVM { Name= "", Surname = "", Position = "", PhotoPath = "" }
            };
            return View();
        }
    }
}
