using System;
using System.Collections.Generic;
using System.Text;
using AmazingTickets.DomainModel.Entities;

namespace AmazingTickets.DomainModel.Interfaces.Services
{
    public interface ITicketSalesService
    {
        /// <summary>
        /// Função que retorna um ticket.
        /// </summary>
        /// <returns>Retorna o Ticket ou null</returns>
        Ticket BuyTicket();
    }
}
