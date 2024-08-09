using System.ComponentModel.DataAnnotations.Schema;
using Ticket_System.Models;

namespace Ticket_System.DTos
{
    public class AllTicketsDto
    {
        public int TicketIdDTO { get; set; }

        public string UserIdDTO { get; set; } 

        public string ImagePathDTO { get; set; }
    }
}
