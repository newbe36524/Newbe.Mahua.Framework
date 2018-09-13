using System.Text;

namespace Newbe.Mahua.CleverQQ.Messages
{
    internal class CleverQQMessage : ICleverQQMessage
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
