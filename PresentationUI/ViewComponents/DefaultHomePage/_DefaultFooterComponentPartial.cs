using Microsoft.AspNetCore.Mvc;

namespace PresentationUI.ViewComponents.DefaultHomePage
{
    public class _DefaultFooterComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
