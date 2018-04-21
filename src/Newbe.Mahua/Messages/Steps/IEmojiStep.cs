namespace Newbe.Mahua.Messages.Steps
{
    public interface IEmojiStep<out T>
        : IMessageBuildStep
        where T : IMessageBuildStep
    {
        /// <summary>
        /// emoji表情
        /// </summary>
        /// <param name="id">emoji字符的unicode编号</param>
        /// <returns></returns>
        T Emoji(string id);
    }
}
