using Newbe.Mahua.Messages;

namespace Newbe.Mahua.QQLight.Messages
{
    public class GroupMessageFlowFactory : IGroupMessageFlowFactory
    {
        private readonly IGroupMessageStep _groupMessageStep;
        private readonly IQqLightMessage _message;

        public GroupMessageFlowFactory(
            IGroupMessageStep groupMessageStep,
            IQqLightMessage message)
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
