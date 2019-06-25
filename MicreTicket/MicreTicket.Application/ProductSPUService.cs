using MicreTicket.Common;
using MicreTicket.Common.Repository;
using MicreTicket.Domain.Entities;
using MicreTicket.Domain.Repository;
using MicreTicket.DTO;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace MicreTicket.Application
{
    public class ProductSPUService : BaseService
    {
        private IRepository baseRepository;
        private IProductRepository productRepository;
        private ILogger<ProductSPUService> logger;
        public ProductSPUService(IRepository baseRepository, IProductRepository productRepository, ILogger<ProductSPUService> logger)
        {
            this.baseRepository = baseRepository;
            this.productRepository = productRepository;
            this.logger = logger;
        }
        public CallResult AddProduct(string SPUName, string SPUDesc, List<string> SKUSpecs, List<string> SKUUnits, List<decimal> SKUDealerPrices, List<string> SKUImageUrles, List<decimal> SKUPvs)
        {
            var productSPUId = Guid.NewGuid();
            var productSKUs = new List<ProductSKU>();
            for (int i = 0; i < SKUSpecs.Count; i++)
            {
                var productSKU = new ProductSKU().CreateProductSKU(
                    SPUName,
                    productSPUId,
                    SKUImageUrles[i],
                    SKUDealerPrices[i],
                    SKUPvs[i],
                    SKUUnits[i],
                    SKUSpecs[i]);
                productSKUs.Add(productSKU);
            }
            var productSPU = new ProductSPU().CreateProductSPU(productSPUId, SPUName, SPUDesc, productSKUs);
            try
            {
                using (baseRepository)
                {
                    productRepository.Add(productSPU);
                    baseRepository.Commit();
                }
                return new CallResult(200, "产品创建成功");
            }
            catch (Exception ex)
            {
                return new CallResult(500, $"产品创建异常：{ex.Message}/r/n{ex.StackTrace}");
            }
        }
    }
}
