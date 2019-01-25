namespace Newbe.Mahua
{
    public interface IInputReceiverFactoryHandler
    {
        IInputReceiver Create(MahuaInputConfig config);
    }
}