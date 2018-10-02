using Newbe.Mahua.Messages.Builders;
using Newbe.Mahua.Messages.Steps;

namespace Newbe.Mahua.Messages
{
    public interface IPrivateMessageStep2 :
        INormalMessageStep<IPrivateMessageStep2>,
        IPrivateMessageDone, IMessageBuildStep
    {
    }
}
