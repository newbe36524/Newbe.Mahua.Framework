namespace Newbe.Mahua.Messages.Steps
{
    public interface IAtAllStep<out T>
        : IMessageBuildStep
        where T : IMessageBuildStep
    {
        /// <summary>
        /// @全体成员
        /// </summary>
        /// <returns></returns>
        T AtlAll();
    }
}
