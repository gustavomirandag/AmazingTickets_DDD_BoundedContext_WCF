using System;
using System.Collections.Generic;
using System.Text;
using AmazingTickets.DomainModel.Entities;

namespace AmazingTickets.Application.Interfaces
{
    public interface ITicketSalesServiceApp
    {
        Ticket BuyTicket();
    }
}
