using MicreTicket.Common;
using MicreTicket.DTO;
using Newtonsoft.Json;
using NUnit.Framework;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Tests
{
    public class Tests
    {
        private HttpClient client;
        [SetUp]
        public void Setup()
        {
            client = new HttpClient();
        }

        [Test]
        public void Test1()
        {
            AddProductSPUDTO addproductspudto = new AddProductSPUDTO();
            addproductspudto.SPUName = "XXXʯ��¶ v2";
            addproductspudto.SPUDesc = "XXX����ʯ��¶ v2�����ڳ���";
            addproductspudto.SKUSpecs = new List<string>();
            addproductspudto.SKUSpecs.Add("ÿƿ30����");
            addproductspudto.SKUSpecs.Add("ÿƿ40����");
            addproductspudto.SKUUnits = new List<string>();
            addproductspudto.SKUUnits.Add("ƿ");
            addproductspudto.SKUUnits.Add("ƿ");
            addproductspudto.SKUPvs = new List<decimal>();
            addproductspudto.SKUPvs.Add(120);
            addproductspudto.SKUPvs.Add(300);
            addproductspudto.SKUDealerPrices = new List<decimal>();
            addproductspudto.SKUDealerPrices.Add(30000);
            addproductspudto.SKUDealerPrices.Add(40000);
            addproductspudto.SKUImageUrles = new List<string>() { "image1","image2" };

            string json = JsonConvert.SerializeObject(addproductspudto);
            HttpContent httpcontent = new StringContent(json);
            httpcontent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var res = client.PostAsync("http://localhost:5000/api/product", httpcontent).Result;
            if (res.IsSuccessStatusCode)
            {
                json = res.Content.ReadAsStringAsync().Result;
                var cr = JsonConvert.DeserializeObject<CallResult>(json);
                Assert.AreEqual(200, cr.Code, cr.Msg);
            }
            else
            {
                Assert.IsTrue(res.IsSuccessStatusCode, $"����ʧ�ܣ�״̬�룺{res.StatusCode}");
            }
        }
    }
}