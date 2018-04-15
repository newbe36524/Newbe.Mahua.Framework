using Newbe.Mahua.Messages;

namespace Newbe.Mahua.MPQ.Messages
{
    public class GroupMessageFlowFactory : IGroupMessageFlowFactory
    {
        private readonly IGroupMessageStep _groupMessageStep;
        private readonly IMpqMessage _message;

        public GroupMessageFlowFactory(
            IGroupMessageStep groupMessageStep,
            IMpqMessage message)
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
