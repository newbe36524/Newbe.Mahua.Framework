using Newbe.Mahua.Samples.OkexRobot.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Refit;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace Newbe.Mahua.Samples.OkexRobot.OkexApi
{
    public interface IOkexInput
    {
        [AliasAs("api_key")]
        [JsonProperty("api_key")]
        string ApiKey { get; set; }
        [AliasAs("sign")]
        [JsonProperty("api_key")]
        string Sign { get; set; }
    }

    public class OkexInput : IOkexInput
    {
        [AliasAs("api_key")]
        [JsonProperty("api_key")]
        public string ApiKey { get; set; }
        [AliasAs("sign")]
        [JsonProperty("sign")]
        public string Sign { get; set; }
    }

    public static class OkexInputExtensions
    {
        private static readonly JsonSerializerSettings Settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
        public static T WithSign<T>(this T input) where T : IOkexInput
        {
            var systemOptions = SystemOptions.Instance;
            input.ApiKey = systemOptions.ApiKey;
            var data = JsonConvert.SerializeObject(input, Settings);
            var dic = JsonConvert.DeserializeObject<Dictionary<string, string>>(data);
            dic.Remove("sign");
            var kvs = dic.OrderBy(x => x.Key).Select(x => $"{x.Key}={WebUtility.UrlEncode(x.Value)}").ToArray();
            var str = string.Join("&", kvs);
            var sign = CreateMd5Hash($"{str}&secret_key={systemOptions.SecretKey}");
            input.Sign = sign;
            return input;
        }
        public static string CreateMd5Hash(string input)
        {
            // Use input string to calculate MD5 hash
            var inputBytes = Encoding.Default.GetBytes(input);
            var md = new MD5CryptoServiceProvider();
            var hashBytes = md.ComputeHash(inputBytes);

            // Convert the byte array to hexadecimal string
            var sb = new StringBuilder();
            foreach (var b in hashBytes)
            {
                sb.Append(b.ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
