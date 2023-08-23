using Microsoft.AspNetCore.Mvc;

namespace PresentationUI.ViewComponents.DefaultLayout
{
    public class _HeaderViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
