namespace Newbe.Mahua.Messages.Builders
{
    public interface IText : IMessageBuilder
    {
        /// <summary>
        /// 文本信息
        /// </summary>
        /// <param name="text"></param>
        void Text(string text);

        /// <summary>
        /// 换行
        /// </summary>
        void Newline();
    }
}
