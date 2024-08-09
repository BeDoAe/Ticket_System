using Ticket_System.Models;
using Ticket_System.Repositories.TicketRepo;
using Ticket_System.Services.TicketService;

namespace Ticket_System.Helpers.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork 
    {
        private readonly Context _context;
        public ITicketRepository TicketRepository { get; }
        public ITicketService TicketService { get; }

        public UnitOfWork(
         Context context ,
         ITicketRepository ticketRepository ,
         ITicketService ticketService
         )
        {
            _context = context;
            TicketRepository = ticketRepository;
            TicketService = ticketService;
        }


        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
