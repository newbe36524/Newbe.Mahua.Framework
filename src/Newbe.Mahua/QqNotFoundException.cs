using System;
using System.Runtime.Serialization;

namespace Newbe.Mahua
{
    public class QqNotFoundException : Exception
    {
        public QqNotFoundException(string qq)
        {
            Qq = qq;
        }

        public QqNotFoundException(string message, string qq) : base(message)
        {
            Qq = qq;
        }

        public QqNotFoundException(string message, Exception innerException, string qq) : base(message, innerException)
        {
            Qq = qq;
        }

        protected QqNotFoundException(SerializationInfo info, StreamingContext context, string qq) : base(info, context)
        {
            Qq = qq;
        }

        public string Qq { get; }
    }
}