using MicreTicket.Common.Entities;
using System.Threading.Tasks;

namespace MicreTicket.Common.Repository
{
    public interface IDomainRepository<T> where T : class, IAggergationRoot
    {
        void Add(T entity);

        void Update(T entity);

        void Remove(T entity);

        Task AddAsync(T entity);
    }
}
