namespace Newbe.Mahua.Messages.Steps
{
    public interface IGroupMessageDone : IMessageBuildStep
    {
        /// <summary>
        /// 完成发送
        /// </summary>
        void Done();
    }
}
