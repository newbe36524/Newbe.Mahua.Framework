using System.Collections.ObjectModel;

namespace Newbe.Mahua.InputReceivers.HttpApi.Services.Controllers
{
    public class HttpInput : IInput
    {
        public string TypeCode { get; set; }
        public MahuaPlatform MahuaPlatform { get; set; }
        public ReadOnlyDictionary<string, object> Data { get; set; }
    }
}