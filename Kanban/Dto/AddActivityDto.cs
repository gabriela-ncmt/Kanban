using System.ComponentModel.DataAnnotations;

namespace Kanban.Dto
{
    public class AddActivityDto
    {
        [Required(ErrorMessage = "Inform Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Inform Description")]
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "Select status")]
        public int StatusId { get; set; }
    }
}
