namespace Newbe.Mahua.Messages.Steps
{
    public interface ISFaceStep<out T>
        : IMessageBuildStep
        where T : IMessageBuildStep
    {
        /// <summary>
        /// 小表情
        /// </summary>
        /// <param name="id">小表情的ID</param>
        /// <returns></returns>
        T SFace(string id);
    }
}
