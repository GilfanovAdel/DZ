using Microsoft.AspNetCore.Mvc;

namespace TeamHost.Web.Areas.Streams.Controllers
{
    [Area("Streams")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
