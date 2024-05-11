using Microsoft.AspNetCore.Mvc;

namespace TeamHost.Web.Areas.Community.Controllers
{
    [Area("Community")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
