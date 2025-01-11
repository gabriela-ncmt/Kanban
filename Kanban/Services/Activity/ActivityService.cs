using Kanban.Dto;
using Kanban.Models;

namespace Kanban.Services.Activity
{
    public class ActivityService : IActivityInterface
    {
        public Task<List<ActivityModel>> GetActivities()
        {
            throw new NotImplementedException();
        }

        public Task<List<StatusModel>> GetStatuses()
        {
            throw new NotImplementedException();
        }

        public Task<ActivityModel> PostActivity(PostActivityDto postActivityDto)
        {
            throw new NotImplementedException();
        }
    }
}
