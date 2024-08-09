using Ticket_System.Repositories.TicketRepo;
using Ticket_System.Services.TicketService;

namespace Ticket_System.Helpers.UnitOfWork
{
    public interface IUnitOfWork
    {
        public Task<int> CompleteAsync();
        public ITicketRepository TicketRepository { get; }

        public ITicketService TicketService { get; }


    }
}