namespace Newbe.Mahua.Messages.Steps
{
    public interface IAtStep<out T> : IMessageBuildStep
        where T : IMessageBuildStep
    {
        /// <summary>
        /// @某人
        /// </summary>
        /// <param name="qq">被@的群成员QQ</param>
        /// <returns></returns>
        T At(string qq);
    }
}
