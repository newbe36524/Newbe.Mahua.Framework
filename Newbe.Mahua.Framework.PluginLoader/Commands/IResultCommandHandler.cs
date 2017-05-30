namespace Newbe.Mahua.Framework.Commands
{
    public interface IResultCommandHandler : ICommandHandler
    {
        object Handle(object command);
    }
}