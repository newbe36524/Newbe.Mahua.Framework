using Newbe.Mahua.Messages;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Newbe.Mahua.CleverQQ.Messages
{
    public interface ICleverQQMessage : IMessage
    {
        bool Shake { get; set; }

    }
    }
}
