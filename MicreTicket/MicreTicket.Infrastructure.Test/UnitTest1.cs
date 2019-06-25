using MicreTicket.Infrastructure;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string data = Units.GetMd5("111111");
            Assert.AreEqual("96e79218965eb72c92a549dd5a330112", data);
        }
    }
}