namespace Newbe.Mahua
{
    public interface IOutputSenderFactoryHandler
    {
        IOutputSender Create(MahuaOutputConfig config);
    }
}