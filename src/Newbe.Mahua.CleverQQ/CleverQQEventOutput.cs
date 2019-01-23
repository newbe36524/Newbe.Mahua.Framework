using System;

namespace Newbe.Mahua.CleverQQ
{
    public abstract class CleverQQEventOutput : IEventOutput
    {
        public MahuaPlatform Platform { get; } = MahuaPlatform.CleverQQ;
        public abstract string TypeCode { get; }
        public DateTimeOffset CreateTime { get; } = DateTimeOffset.UtcNow;
    }
}