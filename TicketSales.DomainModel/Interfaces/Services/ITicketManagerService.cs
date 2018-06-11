using System;
using System.Collections.Generic;
using System.Text;
using AmazingTickets.DomainModel.Entities;

namespace AmazingTickets.DomainModel.Interfaces.Services
{
    public interface ITicketManagerService
    {
        void AddTicket(Ticket ticket);
    }
}
