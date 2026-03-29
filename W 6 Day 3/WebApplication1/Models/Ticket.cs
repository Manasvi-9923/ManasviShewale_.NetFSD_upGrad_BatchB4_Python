using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public string Status { get; set; } = "Open"; 
    }
}