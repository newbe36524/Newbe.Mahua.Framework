namespace Newbe.Mahua.Messages.Steps
{
    public interface IRecordStep<out T>
        : IMessageBuildStep
        where T : IMessageBuildStep
    {
        /// <summary>
        /// 发送语音
        /// </summary>
        /// <param name="file">音频文件名称</param>
        /// <param name="magic">是否为变声</param>
        /// <returns></returns>
        T Record(string file, bool magic);

        /// <summary>
        /// 发送语音
        /// </summary>
        /// <param name="file">音频文件名称</param>
        /// <returns></returns>
        T Record(string file);
    }
}
