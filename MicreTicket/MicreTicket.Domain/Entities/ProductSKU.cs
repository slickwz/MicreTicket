using MicreTicket.Common.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace MicreTicket.Domain.Entities
{
    public class ProductSKU : IEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string Code { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        public string Spec { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public UnitTypeEnum Unit { get; set; }

        public decimal PV { get; set; }
        public decimal DealerPrice { get; set; }
        public string ImageUrl { get; set; }
        public Guid ProductSPUId { get; set; }
        public string ProductSPUName { get; set; }

        public ProductSKU CreateProductSKU(string productspuname, Guid productspuid,
        string imageUrl, decimal dealerprice, decimal pv, string unit, string spec)
        {
            Id = Guid.NewGuid();
            ProductSPUId = productspuid;
            Code = "Code " + productspuname + spec;
            ProductSPUName = productspuname;
            ImageUrl = imageUrl;
            DealerPrice = dealerprice;
            PV = pv;
            switch (unit)
            {
                case "个": Unit = UnitTypeEnum.个; break;
                case "盒":Unit = UnitTypeEnum.盒;break;
                case "包":Unit = UnitTypeEnum.包;break;
                case "瓶":Unit = UnitTypeEnum.瓶;break;
                case "平米": Unit = UnitTypeEnum.平米; break;
                case "斤": Unit = UnitTypeEnum.斤; break;
                case "两": Unit = UnitTypeEnum.两; break;
            }
            Spec = spec;
            return this;
        }
    }
}
