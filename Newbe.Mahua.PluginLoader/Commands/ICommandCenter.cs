namespace Newbe.Mahua.Commands
{
    public interface ICommandCenter
    {
        MahuaCommandResult Handle(MahuaCommand command);
    }
}
