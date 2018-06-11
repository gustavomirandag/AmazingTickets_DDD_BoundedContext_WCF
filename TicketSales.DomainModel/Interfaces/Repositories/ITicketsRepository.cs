using System;
using System.Collections.Generic;
using System.Text;
using AmazingTickets.DomainModel.Entities;

namespace AmazingTickets.DomainModel.Interfaces.Repositories
{
    public interface ITicketsRepository : IRepository<Ticket>
    {
        void Enqueue(Ticket ticket);
        Ticket Dequeue();
    }
}
