using MicreTicket.Domain.Entities;
using MicreTicket.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace MicreTicket.Repository
{
    public class ProductEFCoreRepository : DomainRepository<ProductSPU>, IProductRepository
    {
        public ProductEFCoreRepository(DbContext context) : base(context)
        {
        }
    }
}
