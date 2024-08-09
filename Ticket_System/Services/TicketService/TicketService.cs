using System.Net.Mail;
using Ticket_System.DTos;
using Ticket_System.Helpers;
using Ticket_System.Models;
using Ticket_System.Repositories.TicketRepo;

namespace Ticket_System.Services.TicketService
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository ticketRepository;
        public TicketService(ITicketRepository _ticketRepository) {
        
            this.ticketRepository = _ticketRepository;
        
        }

          public async Task<bool> CreateTicket(TicketDto ticketDto)
        {
            ApplicationUser user = await ticketRepository.GetUserByMobile(ticketDto.DtoUserMobileNumber);
            if (user != null)
            {
                Ticket ticket = new Ticket();
                ticket.ImagePath = await HtmlToImageService.SaveFileAsync(ticketDto.DtoImage);
                ticket.User = user;
                ticket.UserId = user.Id;
                
             await   ticketRepository.AddTicketAsync(ticket);    
              return true;

            }

            return false;

        }
        public async Task<List<AllTicketsDto>> AllTickets()
        {
            List<Ticket> tickets =  ticketRepository.GetAll();
         List<  AllTicketsDto> allTicketsDtos = new List<AllTicketsDto>();

            foreach (Ticket ticket in tickets)
            {
                AllTicketsDto allTicketsDto = new AllTicketsDto
                {
                    TicketIdDTO = ticket.TicketId,
                    UserIdDTO = ticket.UserId,
                    ImagePathDTO = ticket.ImagePath
                };

                allTicketsDtos.Add(allTicketsDto);
            }
            if (allTicketsDtos !=null)
            {
                return  allTicketsDtos;

            }
            else
            {
                return new List<AllTicketsDto>();
            }
        }
        public async Task <TicketMobileDto> GetTicketbyMobile( string mobileNumber)
        {
            Ticket ticket = await ticketRepository.GetTicketByUserMobileAsync(mobileNumber);
            ApplicationUser user =await ticketRepository.GetUserByMobile(mobileNumber);
            TicketMobileDto ticketDto = new TicketMobileDto();
            if (ticket != null)
            {
                ticketDto.DtoUserMobileNumber = mobileNumber;
                ticketDto.DTOTicketNum=ticket.TicketId;
                ticketDto.DtoImage = ticket.ImagePath;
                ticketDto.DtoUserFirstName = user.FirstName;
                return ticketDto;
            }
            else return new TicketMobileDto();


        }

    }
}
