using Newbe.Mahua.Messages;

namespace Newbe.Mahua.CleverQQ.Messages
{
    public class GroupMessageFlowFactory : IGroupMessageFlowFactory
    {
        private readonly IGroupMessageStep _groupMessageStep;
        private readonly ICleverQQMessage _message;

        public GroupMessageFlowFactory(
            IGroupMessageStep groupMessageStep,
            ICleverQQMessage message)
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
