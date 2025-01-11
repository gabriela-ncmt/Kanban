namespace Kanban.Dto
{
    public class PostActivityDto
    {
        public string Description { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int StatusId { get; set; }
    }
}
