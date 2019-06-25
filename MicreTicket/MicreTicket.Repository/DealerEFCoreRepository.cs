using MicreTicket.Domain.Entities;
using MicreTicket.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace MicreTicket.Repository
{
    public class DealerEFCoreRepository : DomainRepository<Dealer>, IDealerRepository
    {
        private EFCoreContext context;
        public DealerEFCoreRepository(DbContext context) : base(context)
        {
            this.context = context as EFCoreContext;
        }
        public void AddDealerPV(Guid dealerid, decimal orderpv)
        {
            context.Dealer.First(x => x.Id == dealerid).TotalPV += orderpv;
        }

        public void AddParentSubCount(Guid? parentdealerid)
        {
            context.Dealer.First(x => x.Id == parentdealerid).SubCount += 1;
        }

        public int GetParentDealerLayer(Guid id)
        {
            return context.Dealer.First(x => x.Id == id).DealerTree.Layer;
        }

        public void SubParentEleMoney(Guid parentdealerid, decimal subelemoney)
        {
            context.Dealer.First(x => x.Id == parentdealerid).TotalEleMoney += subelemoney;
        }
    }
}
