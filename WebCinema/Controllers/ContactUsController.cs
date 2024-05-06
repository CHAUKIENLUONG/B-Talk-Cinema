using Microsoft.AspNetCore.Mvc;

namespace WebCinema.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
