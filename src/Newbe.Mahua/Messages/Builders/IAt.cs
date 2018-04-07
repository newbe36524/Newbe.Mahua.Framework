namespace Newbe.Mahua.Messages.Builders
{
    public interface IAt : IMessageBuilder
    {
        /// <summary>
        /// @某人
        /// </summary>
        /// <param name="qq">被@的群成员QQ</param>
        /// <returns></returns>
        void At(string qq);
    }
}
