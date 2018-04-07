namespace Newbe.Mahua.Messages.Steps
{
    public interface IShakeStep<out T> : IMessageBuildStep
        where T : IMessageBuildStep
    {
        /// <summary>
        /// 戳一戳
        /// </summary>
        /// <returns></returns>
        T Shake();
    }
}
