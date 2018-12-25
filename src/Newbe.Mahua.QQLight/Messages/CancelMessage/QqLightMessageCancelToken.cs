using Newbe.Mahua.Messages.CancelMessage;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Messages.CancelMessage
{
    public class QqLightMessageCancelToken : IMessageCancelToken
    {
        public delegate QqLightMessageCancelToken Factory(string qqGroup, string messageId);

        public static readonly IMessageCancelToken EmptyActionToken = new EmptyCancelToken();

        private readonly IQqLightApi _qqLightApi;

        public QqLightMessageCancelToken(
            string qqGroup,
            string messageId,
            IQqLightApi qqLightApi)
        {
            QqGroup = qqGroup;
            MessageId = messageId;
            _qqLightApi = qqLightApi;
        }

        public string QqGroup { get; }
        public string MessageId { get; }

        public void Cancel()
        {
            _qqLightApi.Api_DeleteMsg(QqGroup, MessageId);
        }

        private class EmptyCancelToken : IMessageCancelToken
        {
            public void Cancel()
            {
                // 不支持发出消息的撤回 
            }
        }
    }
}