using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using AmazingTickets.DomainModel.Entities;
using AmazingTickets.DomainModel.Interfaces.Repositories;

namespace AmazingTickets.Data.Repositories
{
    public class TicketsRepository:Repository<Ticket>, ITicketsRepository
    {
        //Pseudo Banco de Dados concorrente
        private static readonly ConcurrentQueue<Ticket> tickets = new ConcurrentQueue<Ticket>();

        public void Enqueue(Ticket ticket)
        {
            tickets.Enqueue(ticket);
            base.Add(ticket);        }

        public Ticket Dequeue()
        {
            //Ticket ticket;
            tickets.TryDequeue(out var ticket);
            return ticket;
        }

        public override Ticket Add(Ticket entity)
        {
            Enqueue(entity);
            return base.Add(entity);
        }
    }
}
