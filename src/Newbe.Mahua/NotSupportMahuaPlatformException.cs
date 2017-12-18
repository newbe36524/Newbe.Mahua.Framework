using System;
using System.Runtime.Serialization;

namespace Newbe.Mahua
{
    /// <summary>
    /// 不受支持的机器人平台
    /// </summary>
    [Serializable]
    public class NotSupportMahuaPlatformException : Exception
    {
        public NotSupportMahuaPlatformException()
        {
        }

        public NotSupportMahuaPlatformException(string message) : base(message)
        {
        }

        public NotSupportMahuaPlatformException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotSupportMahuaPlatformException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
