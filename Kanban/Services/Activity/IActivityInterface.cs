using Kanban.Dto;
using Kanban.Models;

namespace Kanban.Services.Activity
{
    public interface IActivityInterface
    {
        Task<List<ActivityModel>> GetActivities();
        Task<List<StatusModel>> GetStatuses();
        Task<ActivityModel> PostActivity(PostActivityDto postActivityDto);
    }
}
