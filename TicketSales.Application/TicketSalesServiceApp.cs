using System;
using AmazingTickets.DomainModel.Entities;
using AmazingTickets.DomainModel.Interfaces.Services;
using AmazingTickets.DomainService;

namespace AmazingTickets.Application
{
    public class TicketSalesServiceApp
    {
        private ITicketSalesService _ticketSalesService;

        public TicketSalesServiceApp(ITicketSalesService ticketSalesService)
        {
            _ticketSalesService = ticketSalesService;
        }

        public Ticket BuyTicket()
        {
            //Chama a função do domínio
            return _ticketSalesService.BuyTicket();
        }
    }
}
