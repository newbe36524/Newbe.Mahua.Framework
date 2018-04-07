namespace Newbe.Mahua.Messages.Builders
{
    public interface ISFace : IMessageBuilder
    {
        /// <summary>
        /// 小表情
        /// </summary>
        /// <param name="id">小表情的ID</param>
        /// <returns></returns>
        void SFace(string id);
    }
}
