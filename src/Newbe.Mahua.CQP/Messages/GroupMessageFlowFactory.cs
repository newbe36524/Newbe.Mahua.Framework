using Newbe.Mahua.Messages;

namespace Newbe.Mahua.CQP.Messages
{
    public class GroupMessageFlowFactory : IGroupMessageFlowFactory
    {
        private readonly IGroupMessageStep _groupMessageStep;
        private readonly IMessageBuilder _messageBuilder;

        public GroupMessageFlowFactory(
            IGroupMessageStep groupMessageStep,
            IMessageBuilder messageBuilder)
        {
            _groupMessageStep = groupMessageStep;
            _messageBuilder = messageBuilder;
        }

        public IGroupMessageStep Begin(string @group)
        {
            _messageBuilder.Target = group;
            return _groupMessageStep;
        }
    }
}
