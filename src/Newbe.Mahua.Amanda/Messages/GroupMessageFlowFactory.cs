using Newbe.Mahua.Messages;

namespace Newbe.Mahua.Amanda.Messages
{
    public class GroupMessageFlowFactory : IGroupMessageFlowFactory
    {
        private readonly IGroupMessageStep _groupMessageStep;
        private readonly IAmandaMessage _message;

        public GroupMessageFlowFactory(
            IGroupMessageStep groupMessageStep,
            IAmandaMessage message)
        {
            _groupMessageStep = groupMessageStep;
            _message = message;
        }

        public IGroupMessageStep Begin(string @group)
        {
            _message.Target = group;
            return _groupMessageStep;
        }
    }
}
