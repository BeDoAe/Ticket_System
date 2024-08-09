using Microsoft.EntityFrameworkCore;
using Ticket_System.Models;

namespace Ticket_System.Repositories.TicketRepo
{
    public class TicketRepository : Repository<Ticket> ,ITicketRepository
    {
        private readonly Context context;

        public TicketRepository(Context _context) : base(_context)
        {
            context = _context;
        }
        public async Task<List<Ticket>> GetAllTicketsAsync()
        {
           List<Ticket> tickets= await context.Tickets
                .Include(t => t.User)
                .OrderByDescending(t => t.TicketId)
                .ToListAsync();
            return tickets;
        }
        public async Task<ApplicationUser> GetUserByMobile(string mobile)
        {
            ApplicationUser user = await context.Users.SingleOrDefaultAsync(u=>u.PhoneNumber==mobile);
            if (user != null)
            {
                return user;
            }
            else
            {
                return null;
            }
        }

        public async Task<Ticket> GetTicketByUserMobileAsync(string mobileNumber)
        {
            var user = await context.Users.SingleOrDefaultAsync(u => u.PhoneNumber == mobileNumber);
            if (user == null) return null;

         Ticket ticket= await context.Tickets
                .Where(t => t.UserId == user.Id)
                .Include(t => t.User)
                .SingleOrDefaultAsync();
            return ticket;
        }

        public async Task AddTicketAsync(Ticket ticket)
        {
            await context.Tickets.AddAsync(ticket);
            await context.SaveChangesAsync();
        }
    }
}
