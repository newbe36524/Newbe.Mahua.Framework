using Newbe.Mahua.Messages.Builders;
using Newbe.Mahua.Messages.Steps;

namespace Newbe.Mahua.Messages
{
    public interface IPrivateMessageStep :
        IShakeStep<IPrivateMessageDone>,
        INormalMessageStep<IPrivateMessageStep2>
    {
    }
}
