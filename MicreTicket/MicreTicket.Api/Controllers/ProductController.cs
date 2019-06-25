using MicreTicket.Application;
using MicreTicket.Common;
using MicreTicket.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace MicreTicket.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ProductSPUService productSPUService;
        public ProductController(ProductSPUService productSPUService)
        {
            this.productSPUService = productSPUService;
        }
        // GET: api/Product
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Product/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Product
        [HttpPost]
        public CallResult Post([FromBody] AddProductSPUDTO dto)
        {
            CallResult cr;
            try
            {
                cr = productSPUService.AddProduct(dto);
            }
            catch (Exception ex)
            {
                cr = new CallResult(500, $"产品创建异常：{ex.Message}/r/n{ex.StackTrace}");
            }
            return cr;
        }

        // PUT: api/Product/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] AddProductSPUDTO dto)
        {

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
