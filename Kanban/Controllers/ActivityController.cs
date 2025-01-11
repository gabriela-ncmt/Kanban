using Microsoft.AspNetCore.Mvc;

namespace Kanban.Controllers
{
    public class ActivityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
