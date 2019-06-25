using MicreTicket.Common.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MicreTicket.Domain.Entities
{
    public class ProductSPU : IAggergationRoot
    {
        [Key]
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string ProductSPUName { get; set; }
        public string ProductSPUDesc { get; set; }
        public List<ProductSKU> ProductSKUS { get; set; }

        public ProductSPU CreateProductSPU(Guid id, string spuname, string spudesc, List<ProductSKU> productskus)
        {
            this.Id = id;
            this.Code = "Code " + spuname;
            this.ProductSPUName = spuname;
            this.ProductSKUS = productskus;
            this.ProductSPUDesc = spudesc;
            return this;
        }
    }
}
