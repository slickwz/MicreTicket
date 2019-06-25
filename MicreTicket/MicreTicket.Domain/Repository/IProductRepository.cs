using MicreTicket.Common.Entities;
using MicreTicket.Common.Repository;
using MicreTicket.Domain.Entities;

namespace MicreTicket.Domain.Repository
{
    public interface IProductRepository : IDomainRepository<ProductSPU>
    {
        //void CreateProduct<T>(T entity) where T : class, IAggergationRoot;
    }
}
