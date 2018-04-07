using Newbe.Mahua.Messages;
using System.Text;

namespace Newbe.Mahua.CQP.Messages
{
    internal class Message : IMessage
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
