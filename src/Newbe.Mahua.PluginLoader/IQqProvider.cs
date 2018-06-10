using System;

namespace Newbe.Mahua
{
    public interface IQqProvider
    {
        Func<string> DefaultQqProvider { get; }
        bool CheckQq(string qq);
    }
}
