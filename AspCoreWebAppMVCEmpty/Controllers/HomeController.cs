using Microsoft.AspNetCore.Mvc;

namespace AspCoreWebAppMVCEmpty.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public int Details(int id)
        {
            return id;
        }
    }
}
