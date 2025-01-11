using Kanban.Dto;
using Kanban.Models;

namespace Kanban.Services.Activity
{
    public interface IActivityInterface
    {
        Task<List<ActivityModel>> GetActivitiesAsync();
        Task<List<StatusModel>> GetStatuses();
        Task<ActivityModel> AddActivity(AddActivityDto addActivityDto);

        Task<ActivityModel> ChangeCard(int activityId);
        Task<ActivityModel> Delete(int activityId);
        Task<ActivityModel> ChangePreviousCard(int activityId);
    }
}
