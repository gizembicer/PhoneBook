using PhoneBook.Data.Context;
using PhoneBook.Entity.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Data.Repositories
{
    internal class TypedRepository<TEntity> : DataRepository<TEntity, DataContext>, ITypedRepository<TEntity> where TEntity : class, IEntity
    {
        public TypedRepository(DataContext dbContext) : base(dbContext)
        {
        }
    }
}
