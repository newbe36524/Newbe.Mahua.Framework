using Newbe.Mahua.Messages.Builders;
using Newbe.Mahua.Messages.Steps;

namespace Newbe.Mahua.Messages
{
    public interface IDiscussMessageStep2 :
        IAtStep<IDiscussMessageStep2>,
        INormalMessageStep<IDiscussMessageStep2>,
        IDiscussMessageDone, IMessageBuildStep
    {
    }
}
