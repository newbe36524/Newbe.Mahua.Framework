using Newbe.Mahua.Messages.CancelMessage;

namespace Newbe.Mahua.MPQ.Messages.CancelMessage
{
    public class MpqCancelMessageToken : IMessageCancelToken
    {
        protected MpqCancelMessageToken()
        {
        }

        public static IMessageCancelToken EmptyActionToken = new MpqCancelMessageToken();

        public void Cancel()
        {
            // MPQ 不支持撤回
        }
    }
}