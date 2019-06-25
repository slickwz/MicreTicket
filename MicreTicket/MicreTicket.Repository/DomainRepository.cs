using MicreTicket.Common.Entities;
using MicreTicket.Common.Repository;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MicreTicket.Repository
{
    public class DomainRepository<T> : IDomainRepository<T> where T : class, IAggergationRoot
    {
        protected readonly DbContext context;
        public DomainRepository(DbContext context)
        {
            this.context = context;
        }
        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public async Task AddAsync(T entity)
        {
            await context.Set<T>().AddAsync(entity);
        }

        public void Remove(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            context.Set<T>().Update(entity);
        }
    }
}
