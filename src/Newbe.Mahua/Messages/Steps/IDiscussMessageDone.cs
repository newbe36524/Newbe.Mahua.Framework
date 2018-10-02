using Newbe.Mahua.Messages.CancelMessage;

namespace Newbe.Mahua.Messages.Steps
{
    public interface IDiscussMessageDone : IMessageBuildStep
    {
        /// <summary>
        /// 完成发送
        /// </summary>
        void Done();
        
        /// <summary>
        /// 完成发送并返回用于撤回消息的Token
        /// </summary>
        /// <returns></returns>
        IMessageCancelToken DoneWithToken();
    }
}
