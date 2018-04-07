namespace Newbe.Mahua.Messages.Builders
{
    public interface IEmoji : IMessageBuilder
    {
        /// <summary>
        /// emoji表情
        /// </summary>
        /// <param name="id">emoji字符的unicode编号</param>
        /// <returns></returns>
        void Emoji(string id);
    }
}
