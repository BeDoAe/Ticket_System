using Ticket_System.DTos;

namespace Ticket_System.Services.TicketService
{
    public interface ITicketService
    {
        public Task<bool> CreateTicket(TicketDto ticketDto);

        public  Task<List<AllTicketsDto>> AllTickets();

        public Task<TicketMobileDto> GetTicketbyMobile(string mobileNumber);



    }
}
