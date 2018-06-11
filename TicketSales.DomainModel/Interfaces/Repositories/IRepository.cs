using System;
using System.Collections.Generic;
using System.Text;
using AmazingTickets.DomainModel.Entities;

namespace AmazingTickets.DomainModel.Interfaces.Repositories
{
    public interface IRepository<T> where T : TEntity
    {
        T Add(T entity);
        T Update(T entity);
        T Get(Guid id);
        IEnumerable<T> GetAll();
        bool Remove(Guid id);
    }
}
