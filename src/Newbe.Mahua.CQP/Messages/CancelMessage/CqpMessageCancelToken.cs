using System.Runtime.Serialization;
using Newbe.Mahua.Messages.CancelMessage;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CQP.Messages.CancelMessage
{
    [DataContract]
    public class CqpMessageCancelToken : IMessageCancelToken
    {
        public delegate CqpMessageCancelToken Factory(long messageId);

        private readonly ICoolQApi _coolQApi;
        private readonly ICqpAuthCodeContainer _cqpAuthCodeContainer;

        public CqpMessageCancelToken(
            long messageId,
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
        {
            MessageId = messageId;
            _coolQApi = coolQApi;
            _cqpAuthCodeContainer = cqpAuthCodeContainer;
        }

        [DataMember] public long MessageId { get; set; }

        public void Cancel()
        {
            _coolQApi.CQ_deleteMsg(_cqpAuthCodeContainer.AuthCode, MessageId);
        }
    }
}