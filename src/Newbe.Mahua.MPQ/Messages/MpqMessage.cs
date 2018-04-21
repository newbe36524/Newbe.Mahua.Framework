using System.Text;

namespace Newbe.Mahua.MPQ.Messages
{
    internal class MpqMessage : IMpqMessage
    {
        private readonly StringBuilder _sb = new StringBuilder();
        public string Target { get; set; }

        public void Append(string msg)
        {
            _sb.Append(msg);
        }

        public string GetMessage()
        {
            return _sb.ToString();
        }

        public bool Shake { get; set; }
        public ImageCollection Images { get; } = new ImageCollection();
    }
}
