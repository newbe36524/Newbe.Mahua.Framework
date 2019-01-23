namespace Newbe.Mahua.Impl
{
    public class LoggingOutputSenderFactoryHandler : IOutputSenderFactoryHandler
    {
        public IOutputSender Create(MahuaOutputConfig config)
        {
            return new LoggingOutputSender();
        }
    }
}