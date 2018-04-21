namespace Newbe.Mahua.Messages.Steps
{
    public interface IImageStep<out T>
        : IMessageBuildStep
        where T : IMessageBuildStep
    {
        /// <summary>
        /// 发送自定义图片
        /// </summary>
        /// <returns></returns>
        T Image(string file);
    }
}
