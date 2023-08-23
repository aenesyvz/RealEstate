using Microsoft.AspNetCore.Mvc;

namespace PresentationUI.ViewComponents.DefaultHomePage
{
    public class _DefaultFeatureComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
