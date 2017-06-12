namespace Newbe.Mahua.Commands
{
    public interface ICommandCenter
    {
        void Handle(MahuaCommand command);
        void Handle(MahuaCommand command, out MahuaCommandResult mahuaCommandResult);
    }
}