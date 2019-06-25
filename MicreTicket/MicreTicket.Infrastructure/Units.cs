using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Text;

namespace MicreTicket.Infrastructure
{
    public class Units
    {
        public static string ToJson(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static T FromJson<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static string GetMd5(string data)
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            MD5 md5 = new MD5CryptoServiceProvider();
            dataBytes = md5.ComputeHash(dataBytes);
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in dataBytes)
            {
                stringBuilder.Append(item.ToString("x2"));
            }
            return stringBuilder.ToString();
        }
    }
}
