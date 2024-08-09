using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ticket_System.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; } // Foreign Key to ApplicationUser

        public string ImagePath { get; set; } 

        public virtual ApplicationUser User { get; set; }
    }
}
