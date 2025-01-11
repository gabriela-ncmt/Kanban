using Kanban.Services.Activity;
using Microsoft.AspNetCore.Mvc;

namespace Kanban.Controllers
{
    public class ActivityController : Controller
    {
        private readonly IActivityInterface _activityInterface;
        public ActivityController(IActivityInterface activityInterface)
        {
            _activityInterface = activityInterface;
        }
        public async Task<IActionResult> Index()
        {
            var activities = await _activityInterface.GetActivitiesAsync();
            return View (activities);
        }
    }
}
