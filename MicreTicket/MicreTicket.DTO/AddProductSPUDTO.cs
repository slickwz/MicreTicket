using System.Collections.Generic;

namespace MicreTicket.DTO
{
    public class AddProductSPUDTO
    {
        public string SPUName { get; set; }
        public string SPUDesc { get; set; }
        public List<string> SKUSpecs { get; set; }
        public List<string> SKUUnits { get; set; }
        public List<decimal> SKUDealerPrices { get; set; }
        public List<string> SKUImageUrles { get; set; }
        public List<decimal> SKUPvs { get; set; }
    }
}
