using System.Threading.Tasks;
using Autofac.Features.Indexed;

namespace Newbe.Mahua.Impl
{
    internal class InputHandler : IInputHandler
    {
        private readonly IIndex<MahuaPlatform, IPlatformMahuaApiHandler> _platformMahuaApiHandlers;

        public InputHandler(
            IIndex<MahuaPlatform, IPlatformMahuaApiHandler> platformMahuaApiHandlers)
        {
            _platformMahuaApiHandlers = platformMahuaApiHandlers;
        }

        public Task Handle(IInput input)
        {
            var platformMahuaApiHandler = _platformMahuaApiHandlers[input.MahuaPlatform];
            return platformMahuaApiHandler.Run(input.TypeCode, input.Data);
        }
    }
}