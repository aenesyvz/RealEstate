using Microsoft.AspNetCore.Mvc;

namespace PresentationUI.ViewComponents.DefaultHomePage
{
    public class _DefaultOurClientsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
