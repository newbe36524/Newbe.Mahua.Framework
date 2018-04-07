namespace Newbe.Mahua.Messages.Steps
{
    public interface ITextStep<out T> : IMessageBuildStep
        where T : IMessageBuildStep
    {
        /// <summary>
        /// 文本信息
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        T Text(string text);

        /// <summary>
        /// 换行
        /// </summary>
        /// <returns></returns>
        T Newline();
    }
}
