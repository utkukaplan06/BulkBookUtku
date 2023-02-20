using Microsoft.AspNetCore.Mvc;

namespace BulkBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
