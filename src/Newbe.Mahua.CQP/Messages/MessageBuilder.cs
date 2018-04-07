using System.Text;
using Newbe.Mahua.Messages;

namespace Newbe.Mahua.CQP.Messages
{
    internal class MessageBuilder : IMessageBuilder
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
    }
}
