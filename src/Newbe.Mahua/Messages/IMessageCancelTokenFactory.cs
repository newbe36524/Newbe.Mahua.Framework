using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newbe.Mahua.Messages
{
    public interface IMessageCancelTokenFactory
    {
        IMessageCancelToken CreateToken();
    }
}
