using Microsoft.AspNetCore.Mvc;

namespace FileUploader2.Controllers
{
    public class SignalController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}