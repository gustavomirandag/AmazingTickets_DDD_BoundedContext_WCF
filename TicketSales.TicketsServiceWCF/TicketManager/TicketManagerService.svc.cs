using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AmazingTickets.Application;
using AmazingTickets.Application.Interfaces;
using AmazingTickets.Data.Repositories;
using AmazingTickets.DomainModel.Entities;
using AmazingTickets.DomainModel.Interfaces.Repositories;

namespace AmazingTickets.TicketsServiceWCF.TicketManager
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TicketManagerService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TicketManagerService.svc or TicketManagerService.svc.cs at the Solution Explorer and start debugging.
    public class TicketManagerService : ITicketManagerService
    {
        public void AddTicket(Ticket ticket)
        {
            //Infrastructure
            ITicketsRepository ticketsRepository = new TicketsRepository();

            //DomainService
            AmazingTickets.DomainModel.Interfaces.Services.ITicketManagerService ticketManagerService = new AmazingTickets.DomainService.TicketManagerService(ticketsRepository);

            //Application
            TicketManagerServiceApp ticketManagerServiceApp = new TicketManagerServiceApp(ticketManagerService);

            ticketManagerServiceApp.AddTicket(ticket);
        }
    }
}
