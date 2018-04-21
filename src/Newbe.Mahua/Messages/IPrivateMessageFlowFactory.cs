
namespace Newbe.Mahua.Messages
{
    public interface IPrivateMessageFlowFactory
    {
        IPrivateMessageStep Begin(string qq);
    }
}
