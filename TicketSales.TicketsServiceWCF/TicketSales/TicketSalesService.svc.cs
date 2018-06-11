using AmazingTickets.Application;
using AmazingTickets.Data.Repositories;
using AmazingTickets.DomainModel.Entities;
using AmazingTickets.DomainModel.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AmazingTickets.TicketsServiceWCF.TicketSales
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TicketSalesService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TicketSalesService.svc or TicketSalesService.svc.cs at the Solution Explorer and start debugging.
    public class TicketSalesService : ITicketSalesService
    {
        public Ticket BuyTicket()
        {
            //Infrastructure
            ITicketsRepository ticketsRepository = new TicketsRepository();

            //DomainService
            AmazingTickets.DomainModel.Interfaces.Services.ITicketSalesService ticketSalesService = new AmazingTickets.DomainService.TicketSalesService(ticketsRepository);

            //Application
            TicketSalesServiceApp ticketSalesServiceApp = new TicketSalesServiceApp(ticketSalesService);

            return ticketSalesServiceApp.BuyTicket();
        }
    }
}
