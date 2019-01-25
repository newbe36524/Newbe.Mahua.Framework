using System;

namespace Newbe.Mahua
{
    public interface IOutput
    {
        string TypeCode { get; }
        DateTimeOffset CreateTime { get; }
    }
}