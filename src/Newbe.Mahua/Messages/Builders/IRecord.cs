namespace Newbe.Mahua.Messages.Builders
{
    public interface IRecord : IMessageBuilder
    {
        /// <summary>
        /// 发送语音
        /// </summary>
        /// <param name="file">音频文件名称</param>
        /// <returns></returns>
        void Record(string file);
    }
}
