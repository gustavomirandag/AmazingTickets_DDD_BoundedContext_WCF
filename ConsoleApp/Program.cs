using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSales.Data.Repositories;
using TicketSales.DomainModel.Entities;
using TicketSales.DomainModel.Interfaces.Repositories;
using TicketSales.DomainService;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Infrastructure
            ITicketsRepository ticketsRepository;
            ticketsRepository = new TicketsRepository(); //Armazena em Fila
            ticketsRepository = new TicketsInFileRepository(); //Armazena em Arquivo

            //DomainService
            TicketSalesService servico = new TicketSalesService(ticketsRepository);
            servico.AddTicket(new Ticket("RIR", DateTime.Now, "Recreio"));
        }
    }
}
