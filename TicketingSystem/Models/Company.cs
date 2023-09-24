using System.ComponentModel.DataAnnotations;

namespace TicketingSystem.Models
{
    public class Company
    {   
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

        [Phone]
        public string Phone { get; set; } = string.Empty;

        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public ICollection<Department>? Departments { get; set; }

    }
}
