using AmazingTickets.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AmazingTickets.TicketsServiceWCF.TicketSales
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITicketSalesService" in both code and config file together.
    [ServiceContract]
    public interface ITicketSalesService
    {
        [OperationContract]
        Ticket BuyTicket();
    }
}
