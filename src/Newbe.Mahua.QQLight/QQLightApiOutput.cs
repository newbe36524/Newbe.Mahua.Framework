using System;

namespace Newbe.Mahua.QQLight
{
    public abstract class QQLightApiOutput : IApiOutput
    {
        public MahuaPlatform Platform { get; } = MahuaPlatform.QQLight;
        public abstract string TypeCode { get; }
        public DateTimeOffset CreateTime { get; } = DateTimeOffset.UtcNow;
    }
}