using Microsoft.EntityFrameworkCore;
using PhoneBook.Entity.Interfaces.Entities;
using System;
using System.Linq.Expressions;

namespace PhoneBook.Data.Repositories
{
    public abstract class DataRepository<TEntity, TDataContext> : IDataRepository<TEntity> where TEntity : class, IEntity where TDataContext : DbContext
    {
        protected readonly TDataContext DbContext;
        protected readonly DbSet<TEntity> DbSet;

        protected DataRepository(TDataContext dbContext)
        {
            DbContext = dbContext;
            DbSet = dbContext.Set<TEntity>();
        }

        public TEntity Get<T>(T id) => DbSet.Find(id);
        public void Add(TEntity entity)
        {
            if (entity is ICreatedAtEntity atEntity)
            {
                atEntity.CreatedAt = DateTime.Now;
            }
            DbSet.Add(entity);
            DbContext.SaveChanges();
        }
        public void AddRange(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities.OfType<ICreatedAtEntity>())
            {
                entity.CreatedAt = DateTime.Now;
            }

            DbSet.AddRange(entities);
            DbContext.SaveChanges();
        }
        public void Remove(TEntity entity)
        {
            if (entity is ISoftDelete atEntity)
            {
                atEntity.IsDeleted = true;
                DbSet.Update(entity);
            }
            else
                DbSet.Remove(entity);
            DbContext.SaveChanges();
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                if (entity is ISoftDelete atEntity)
                {
                    atEntity.IsDeleted = true;
                    DbSet.Update(entity);
                }
                else
                {
                    DbSet.RemoveRange(entities);
                }
            }
            DbContext.SaveChanges();
        }
        public void Update(TEntity entity)
        {
            if (entity is IModifiedAtEntity atEntity)
            {
                atEntity.ModifiedAt = DateTime.Now;
            }
            DbSet.Update(entity);
            DbContext.SaveChanges();
        }
        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities.OfType<IModifiedAtEntity>())
            {
                entity.ModifiedAt = DateTime.Now;
            }
            DbSet.UpdateRange(entities);
            DbContext.SaveChanges();
        }
        public IQueryable<TEntity> GetAll() => DbSet.AsNoTracking();
        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate) => DbSet.AsNoTracking().Where(predicate);
        public async Task<TEntity> GetAsync<T>(T id, CancellationToken cancellationToken = default) => await DbSet.FindAsync(id, cancellationToken);
        public async Task AddAsync(TEntity entity, CancellationToken cancellationToken = default) => await DbSet.AddAsync(entity, cancellationToken);
        public async Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default) => await DbSet.AddRangeAsync(entities, cancellationToken);
    }
}
