using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AmazingTickets.DomainModel.Entities;

namespace AmazingTickets.TicketsServiceWCF.TicketManager
{
    [ServiceContract]
    public interface ITicketManagerService
    {
        [OperationContract]
        void AddTicket(Ticket ticket);
    }
}
