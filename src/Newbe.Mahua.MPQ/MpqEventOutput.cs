using System;

namespace Newbe.Mahua.MPQ
{
    public abstract class MpqEventOutput : IEventOutput
    {
        public MahuaPlatform Platform { get; } = MahuaPlatform.Mpq;
        public abstract string TypeCode { get; }
        public DateTimeOffset CreateTime { get; } = DateTimeOffset.UtcNow;
    }
}