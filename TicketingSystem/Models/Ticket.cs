using System.ComponentModel.DataAnnotations;

namespace TicketingSystem.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string? Type { get; set; } = string.Empty;

        [Phone]
        [Display(Name = "Contact #")]
        public string Phone { get; set; } = string.Empty;

        public DateTime Date { get; set; } = DateTime.Now;

        public string? UserId { get; set; } = string.Empty;

        public int? TicketStatusId { get; set; } = 1;
        public TicketStatus? TicketStatus { get; set; }

        public int? DepartmentId { get; set; } = 1;
        public Department? Department { get; set; }

    }
}
