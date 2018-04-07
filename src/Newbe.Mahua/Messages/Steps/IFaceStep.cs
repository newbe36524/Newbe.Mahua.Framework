namespace Newbe.Mahua.Messages.Steps
{
    public interface IFaceStep<out T>
        : IMessageBuildStep
        where T : IMessageBuildStep
    {
        /// <summary>
        ///  QQ表情
        /// </summary>
        /// <param name="id">0-170的数字</param>
        /// <returns></returns>
        T Face(string id);
    }
}
