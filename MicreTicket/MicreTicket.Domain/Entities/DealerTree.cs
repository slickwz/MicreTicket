using MicreTicket.Common.Entities;
using MicreTicket.Domain.Repository;
using System;

namespace MicreTicket.Domain.Entities
{
    /// <summary>
    /// 经销商树结构
    /// </summary>
    public class DealerTree : IValueObject
    {
        public Guid Id { get; set; }

        public Guid DealerId { get; set; }
        public Guid? ParentDealerId { get; set; }
        public int Layer { get; set; }
        public DealerTree()
        {

        }
        private readonly IDealerRepository idealerrepository;
        public DealerTree(IDealerRepository idealerrepository)
        {
            this.idealerrepository = idealerrepository;
        }
        public DealerTree CreateDealerTree(Guid? parentdealerid, Guid dealerid)
        {
            Id = Guid.NewGuid();
            DealerId = dealerid;
            ParentDealerId = parentdealerid;
            Layer = parentdealerid == null ? 1 : idealerrepository.GetParentDealerLayer(Guid.Parse(parentdealerid.ToString())) + 1;
            return this;
        }
    }
}
