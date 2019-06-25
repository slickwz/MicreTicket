using MicreTicket.Common.Entities;
using MicreTicket.Domain.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MicreTicket.Domain.Entities
{
    /// <summary>
    /// 经销商
    /// </summary>
    public class Dealer : IAggergationRoot
    {
        [Key]
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public decimal TotalEleMoney { get; set; }
        public decimal JiangJinMoney { get; set; }
        public decimal TotalPV { get; set; }
        public CardTypeEnum CardType { get; set; }
        public LevelEnum Level { get; set; }
        public int SubCount { get; set; }
        public List<Contact> Contacts { get; set; }
        public DealerTree DealerTree { get; set; }

        public Dealer()
        {

        }
        private readonly IDealerRepository idealerrepository;
        public Dealer(IDealerRepository idealerrepository)
        {
            this.idealerrepository = idealerrepository;
        }
        public Dealer RegisterDealer(Guid id, string name, string tel, decimal telmoney, List<Contact>
            contacts, Guid? parentid)
        {
            Id = id;
            Code = "Code " + name;
            Name = name;
            Tel = tel;
            TotalEleMoney = telmoney;
            if (telmoney < 2000)
            {
                CardType = CardTypeEnum.普通会员;
            }
            else if (telmoney >= 2000 && telmoney < 4000)
            {
                CardType = CardTypeEnum.银卡会员;
            }
            else
            {
                CardType = CardTypeEnum.金卡会员;
            }
            SubCount = 0;
            TotalPV = 0;
            JiangJinMoney = 0;
            Contacts = contacts;
            DealerTree = new DealerTree(idealerrepository).CreateDealerTree(parentid, id);
            return this;
        }
    }
}
