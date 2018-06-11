using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AmazingTickets.DomainModel.Entities;
using AmazingTickets.DomainModel.Interfaces.Repositories;

namespace AmazingTickets.Data.Repositories
{
    public abstract class Repository<T>: IRepository<T> where T : TEntity
    {
        private readonly static List<T> entities = new List<T>();

        public virtual T Add(T entity)
        {
            entities.Add(entity);
            return entity;
        }

        public virtual T Get(Guid id)
        {
            return entities.Find(e => e.Id == id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return entities;
        }

        public virtual bool Remove(Guid id)
        {
            T originalEntity = Get(id);
            return entities.Remove(originalEntity);
        }

        public virtual T Update(T entity)
        {
            Remove(entity.Id);
            Add(entity);
            return entity;
        }
    }
}
