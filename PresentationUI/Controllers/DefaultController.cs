using Microsoft.AspNetCore.Mvc;

namespace PresentationUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
