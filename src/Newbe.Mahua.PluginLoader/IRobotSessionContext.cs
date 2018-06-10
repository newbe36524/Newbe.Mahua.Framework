using System;
using System.ComponentModel;

namespace Newbe.Mahua
{
    public interface IRobotSessionContext
    {
        string CurrentQq { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        Func<string> CurrentQqProvider { get; set; }
    }
}
