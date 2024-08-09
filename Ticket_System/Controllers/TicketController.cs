using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ticket_System.Helpers.UnitOfWork;
using Ticket_System.Helpers;
using Ticket_System.Models;
using Ticket_System.DTos;

namespace Ticket_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly HtmlToImageService _htmlToImageService;

        public TicketController(IUnitOfWork unitOfWork, HtmlToImageService htmlToImageService)
        {
            _unitOfWork = unitOfWork;
            _htmlToImageService = htmlToImageService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateTicket( TicketDto ticketDto)
        {
            var user = await _unitOfWork.TicketRepository.GetUserByMobile(ticketDto.DtoUserMobileNumber);
            if (user == null)
            {
                return BadRequest("Ticket already exists for this user.");
            }


            

            await _unitOfWork.TicketService.CreateTicket(ticketDto);
            await _unitOfWork.CompleteAsync();

            return Ok("Created Successfully");

        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllTickets()
        {
            var tickets = await _unitOfWork.TicketService.AllTickets();
            return Ok(tickets);
        }

        [HttpGet("by-mobile/{mobileNumber}")]
        public async Task<IActionResult> GetTicketByUserMobile(string mobileNumber)
        {
            var ticket = await _unitOfWork.TicketService.GetTicketbyMobile(mobileNumber);
            if (ticket == null)
            {
                return NotFound();
            }

            return Ok(ticket);
        }
    }
}