using Newbe.Mahua.Messages;

namespace Newbe.Mahua
{
    /// <summary>
    /// 调用不受支持的MessageBuilder的行为
    /// </summary>
    public interface INotSupportedMessageBuilderConvertion
    {
        /// <summary>
        /// 处理
        /// </summary>
        void Handle<T>() where T : IMessageBuilder;
    }
}
