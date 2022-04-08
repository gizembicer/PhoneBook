using PhoneBook.Entity.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Data.Repositories
{
    public interface IDataRepository<TEntity> where TEntity : IEntity
    {
        TEntity Get<T>(T id);
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);
        IQueryable<TEntity> GetAll(); 
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);


        Task<TEntity> GetAsync<T>(T id, CancellationToken cancellationToken = default);
        Task AddAsync(TEntity entity, CancellationToken cancellationToken = default);
        Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);
    }
}
