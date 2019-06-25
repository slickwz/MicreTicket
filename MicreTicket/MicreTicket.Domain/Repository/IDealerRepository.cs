using MicreTicket.Common.Entities;
using System;

namespace MicreTicket.Domain.Repository
{
    public interface IDealerRepository
    {
        //void CreateDealer<T>(T entity) where T : class, IAggergationRoot;
        int GetParentDealerLayer(Guid guid);
        //将上级经销商（代注册经销商）的子个数加一
        void AddParentSubCount(Guid? parentdealerid);
        //减去父进销商的电子币（用于注册和下单时，扣减经销商的电子币）
        void SubParentEleMoney(Guid parentdealerid, decimal subelemoney);
        //下订单时，增加经销商的PV
        void AddDealerPV(Guid dealerid, decimal orderpv);
    }
}
