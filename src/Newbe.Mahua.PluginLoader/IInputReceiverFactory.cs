using System.Collections.Generic;

namespace Newbe.Mahua
{
    public interface IInputReceiverFactory
    {
        IEnumerable<IInputReceiver> Create();
    }
}