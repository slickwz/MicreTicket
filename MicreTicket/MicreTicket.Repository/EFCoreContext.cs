using MicreTicket.Domain.Context;
using MicreTicket.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MicreTicket.Repository
{
    public class EFCoreContext : DbContext, IProductContext
    {
        public EFCoreContext() : base() { }
        public EFCoreContext(DbContextOptions options) : base(options) { }
        public DbSet<ProductSPU> ProductSPU { get; set; }
        public DbSet<ProductSKU> ProductSKU { get; set; }
        public DbSet<Dealer> Dealer { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<DealerTree> DealerTree { get; set; }
    }
}
