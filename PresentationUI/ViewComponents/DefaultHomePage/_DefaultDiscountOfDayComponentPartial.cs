using Microsoft.AspNetCore.Mvc;

namespace PresentationUI.ViewComponents.DefaultHomePage
{
    public class _DefaultDiscountOfDayComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
