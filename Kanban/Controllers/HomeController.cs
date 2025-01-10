using Kanban.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Kanban.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
