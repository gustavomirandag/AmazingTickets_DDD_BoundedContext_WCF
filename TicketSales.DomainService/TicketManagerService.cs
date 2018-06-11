using System;
using System.Collections.Generic;
using System.Text;
using AmazingTickets.DomainModel.Entities;
using AmazingTickets.DomainModel.Interfaces.Repositories;
using AmazingTickets.DomainModel.Interfaces.Services;

namespace AmazingTickets.DomainService
{
    public class TicketManagerService : ITicketManagerService
    {
        private ITicketsRepository _ticketsRepository;

        public TicketManagerService(ITicketsRepository ticketsRepository)
        {
            _ticketsRepository = ticketsRepository;
        }
        public void AddTicket(Ticket ticket)
        {
            _ticketsRepository.Add(ticket);
        }
    }
}
