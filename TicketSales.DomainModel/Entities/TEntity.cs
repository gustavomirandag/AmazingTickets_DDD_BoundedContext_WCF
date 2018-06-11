using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingTickets.DomainModel.Entities
{
    public abstract class TEntity
    {
        public Guid Id { get; set; }
    }
}
