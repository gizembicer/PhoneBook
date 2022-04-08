using Microsoft.EntityFrameworkCore;

namespace PhoneBook.Data.UnitOfWorks
{
    public abstract class EfCoreUnitOfWork<TDataContext> : IEfCoreUnitOfWork where TDataContext : DbContext
    {
        protected readonly TDataContext Context;

        protected EfCoreUnitOfWork(TDataContext appDbContext)
        {
            Context = appDbContext;
        }

        public virtual void Commit()
        {
            try
            {
                Context.SaveChanges();
            }
            catch (Exception e)
            {

                throw;
            }

        }


        public virtual async Task CommitAsync()
        {
            try
            {
                await Context.SaveChangesAsync();
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
