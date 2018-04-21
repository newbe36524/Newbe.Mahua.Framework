using Newbe.Mahua.Messages.Steps;

namespace Newbe.Mahua.Amanda.Messages
{
    public class DiscussMessageDone : IDiscussMessageDone
    {
        private readonly IMahuaApi _mahuaApi;
        private readonly IAmandaMessage _message;

        public DiscussMessageDone(
            IMahuaApi mahuaApi,
            IAmandaMessage message)
        {
            _mahuaApi = mahuaApi;
            _message = message;
        }

        public void Done()
        {
            _mahuaApi.SendDiscussMessage(_message.Target, _message.GetMessage());
        }
    }
}
