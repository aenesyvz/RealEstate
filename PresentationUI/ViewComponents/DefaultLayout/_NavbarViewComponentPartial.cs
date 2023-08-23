using Microsoft.AspNetCore.Mvc;

namespace PresentationUI.ViewComponents.DefaultLayout
{
    public class _NavbarViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
