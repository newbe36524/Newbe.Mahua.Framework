using Newbe.Mahua.Messages;
using Newbe.Mahua.NativeApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newbe.Mahua.CQP.Messages
{
    public class MessageCancelToken : IMessageCancelToken
    {
        private readonly IMahuaApi _mahuaApi;

        private long _messageId = -1;
        private string _targetId = "";
        private int _messagetype = 0;

        public delegate MessageCancelToken Factory();
        public long MessageId { get => _messageId; set => _messageId = value; }
        public string TargetId { get => _targetId; set => _targetId = value; }
        public int MessageType { get => _messagetype; set => _messagetype = value; }

        public MessageCancelToken(IMahuaApi mahuaApi)
        {
            _mahuaApi = mahuaApi;
        }

        public void Cancel()
        {
            _mahuaApi.DeleteMessage(MessageId, TargetId, MessageType);
        }
    }
}
