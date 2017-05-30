namespace Newbe.Mahua.Framework.Commands
{
    public interface ICommandCenter
    {
        void Handle(MahuaCommand command);
        void Handle(MahuaCommand command, out MahuaCommandResult mahuaCommandResult);
    }
}