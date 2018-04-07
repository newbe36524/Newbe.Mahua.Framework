using Newbe.Mahua.Messages.Steps;

namespace Newbe.Mahua.Messages
{
    public interface IGroupMessageStep :
        IAtAllStep<IGroupMessageStep2>,
        IAtStep<IGroupMessageStep2>,
        INormalMessageStep<IGroupMessageStep2>
    {
    }
}
