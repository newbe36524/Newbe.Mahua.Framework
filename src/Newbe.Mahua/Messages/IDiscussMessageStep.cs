using Newbe.Mahua.Messages.Steps;

namespace Newbe.Mahua.Messages
{
    public interface IDiscussMessageStep :
        IAtStep<IDiscussMessageStep2>,
        INormalMessageStep<IDiscussMessageStep2>

    {
    }
}
