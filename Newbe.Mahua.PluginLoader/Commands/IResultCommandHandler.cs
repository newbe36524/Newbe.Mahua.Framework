namespace Newbe.Mahua.Commands
{
    public interface IResultCommandHandler : ICommandHandler
    {
        object Handle(object command);
    }
}