using Microsoft.AspNetCore.Mvc;

namespace HW11.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
