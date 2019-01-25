using System;

namespace Newbe.Mahua.MPQ
{
    public abstract class MpqApiOutput : IApiOutput
    {
        public MahuaPlatform Platform { get; } = MahuaPlatform.Mpq;
        public abstract string TypeCode { get; }
        public DateTimeOffset CreateTime { get; } = DateTimeOffset.UtcNow;
    }
}