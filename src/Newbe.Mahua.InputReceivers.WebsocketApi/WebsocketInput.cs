using System.Collections.ObjectModel;

namespace Newbe.Mahua.InputReceivers.WebsocketApi
{
    public class WebsocketInput : IInput
    {
        public string TypeCode { get; set; }
        public MahuaPlatform MahuaPlatform { get; set; }
        public ReadOnlyDictionary<string, object> Data { get; set; }
    }
}