namespace Newbe.Mahua.Messages.Builders
{
    public interface IImage : IMessageBuilder
    {
        /// <summary>
        /// 发送自定义图片
        /// </summary>
        /// <returns></returns>
        void Image(string file);
    }
}
