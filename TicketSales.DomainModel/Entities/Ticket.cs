using System;

namespace AmazingTickets.DomainModel.Entities
{
    public class Ticket:TEntity
    {
        public string Event { get; set; }
        public DateTime DateTime { get; set; }
        public string Local { get; set; }

        public Ticket(string @event, DateTime dateTime, string local)
        {
            this.Id = Guid.NewGuid();
            Event = @event;
            DateTime = dateTime;
            Local = local;
        }

        public Ticket()
        {
        }
    }
}
