using Newbe.Mahua.Messages.Builders;
using Newbe.Mahua.Messages.Steps;

namespace Newbe.Mahua.Messages
{
    public interface IGroupMessageStep2 :
        IAtAllStep<IGroupMessageStep2>,
        IAtStep<IGroupMessageStep2>,
        INormalMessageStep<IGroupMessageStep2>,
        IGroupMessageDone
    {
    }
}
