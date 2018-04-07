namespace Newbe.Mahua.Messages.Steps
{
    public interface IBFaceStep<out T>
        : IMessageBuildStep
        where T : IMessageBuildStep
    {
        /// <summary>
        /// 原创表情
        /// </summary>
        /// <param name="id">原创表情的ID</param>
        /// <returns></returns>
        T BFace(string id);
    }
}
