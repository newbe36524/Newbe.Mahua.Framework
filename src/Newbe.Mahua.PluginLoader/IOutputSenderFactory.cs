using System.Collections.Generic;

namespace Newbe.Mahua
{
    public interface IOutputSenderFactory
    {
        IEnumerable<IOutputSender> Create();
    }
}