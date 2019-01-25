using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Newbe.Mahua.Impl
{
    internal class OutputHandler : IOutputHandler
    {
        private readonly BufferBlock<IOutput> _beginBlock;

        public OutputHandler(
            IOutputSenderFactory outputSenderFactory)
        {
            var broadcastBlock = new BroadcastBlock<IOutput>(output => output);
            var actionBlocks = outputSenderFactory.Create()
                .Select(handler => new ActionBlock<IOutput>(handler.Handle));
            foreach (var actionBlock in actionBlocks)
            {
                broadcastBlock.LinkTo(actionBlock);
            }

            _beginBlock = new BufferBlock<IOutput>();
            _beginBlock.LinkTo(broadcastBlock);
        }


        public Task Handle(IOutput output)
        {
            return _beginBlock.SendAsync(output);
        }
    }
}