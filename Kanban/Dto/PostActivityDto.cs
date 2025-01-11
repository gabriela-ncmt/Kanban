namespace Kanban.Dto
{
    public class PostActivityDto
    {
        //matricula
        public string Enrollment { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int StatusId { get; set; }
    }
}
