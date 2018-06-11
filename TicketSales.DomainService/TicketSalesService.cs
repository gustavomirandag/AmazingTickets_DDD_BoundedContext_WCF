using System;
using AmazingTickets.DomainModel;
using AmazingTickets.DomainModel.Entities;
using AmazingTickets.DomainModel.Interfaces.Repositories;
using AmazingTickets.DomainModel.Interfaces.Services;

namespace AmazingTickets.DomainService
{
    public class TicketSalesService : ITicketSalesService
    {
        private ITicketsRepository _ticketsRepository;

        public TicketSalesService(ITicketsRepository ticketsRepository)
        {
            _ticketsRepository = ticketsRepository;
        }

        public Ticket BuyTicket()
        {
            return _ticketsRepository.Dequeue();
        }
    }
}
