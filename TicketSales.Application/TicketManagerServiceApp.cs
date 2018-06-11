using System;
using System.Collections.Generic;
using System.Text;
using AmazingTickets.DomainModel.Entities;
using AmazingTickets.DomainModel.Interfaces.Services;

namespace AmazingTickets.Application
{
    public class TicketManagerServiceApp
    {
        private ITicketManagerService _ticketService;

        public TicketManagerServiceApp(ITicketManagerService ticketSalesService)
        {
            _ticketService = ticketSalesService;
        }
        public void AddTicket(Ticket ticket)
        {
            //Chama a função do domínio
            _ticketService.AddTicket(ticket);
        }
    }
}
