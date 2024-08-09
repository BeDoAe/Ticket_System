using Microsoft.AspNetCore.Identity;

namespace Ticket_System.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }   
        public string LastName { get; set; }

        public virtual Ticket? Ticket { get; set; }
    }
}
