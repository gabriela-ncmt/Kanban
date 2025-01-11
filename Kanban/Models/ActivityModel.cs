namespace Kanban.Models
{
    public class ActivityModel
    {
        public int Id { get; set; }
        //matricula
        public int Enrollment { get; set; }
        public string Title { get; set; }
        public  string Description { get; set; }
        public DateTime CreatedDate { get; set;} = DateTime.Now;
        public int StatusId { get; set; }
        public StatusModel Status { get; set; }

    }
}
