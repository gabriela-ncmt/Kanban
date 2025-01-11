using Kanban.Dto;
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
        public async Task<IActionResult> Add()
        {
            var status = await _activityInterface.GetStatuses();
            ViewBag.Status = status;
            return View ();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddActivityDto addActivityDto)
        {
            if(ModelState.IsValid)
            {
                var activity = await _activityInterface.AddActivity(addActivityDto);
                return RedirectToAction("Index");
            }
            else
            {
                var status = await _activityInterface.GetStatuses();
                ViewBag.Status = status;
                return View(addActivityDto);
            }
        }

        public async Task<IActionResult> ChangeCard(int id)
        {
            var activity = await _activityInterface.ChangeCard(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var activity = await _activityInterface.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
