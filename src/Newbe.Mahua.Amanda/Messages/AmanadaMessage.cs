using System.Text;

namespace Newbe.Mahua.Amanda.Messages
{
    internal class AmanadaMessage : IAmandaMessage
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
    }
}
