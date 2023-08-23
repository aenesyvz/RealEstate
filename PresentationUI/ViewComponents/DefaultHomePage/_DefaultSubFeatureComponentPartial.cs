using Microsoft.AspNetCore.Mvc;

namespace PresentationUI.ViewComponents.DefaultHomePage
{
    public class _DefaultSubFeatureComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
