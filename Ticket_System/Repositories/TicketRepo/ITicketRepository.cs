using Ticket_System.Models;

namespace Ticket_System.Repositories.TicketRepo
{
    public interface ITicketRepository : IRepository<Ticket>
    {

        public Task<List<Ticket>> GetAllTicketsAsync();
       public Task<Ticket> GetTicketByUserMobileAsync(string mobileNumber);
       public Task AddTicketAsync(Ticket ticket);

        public  Task<ApplicationUser> GetUserByMobile(string mobile);

    }
}