using System;
using System.Runtime.Serialization;

namespace Newbe.Mahua.Messages.Exceptions
{
    /// <summary>
    /// 不支持的消息发送形式
    /// </summary>
    [Serializable]
    public class NotSupportedMessageBuilderException : Exception
    {
        public NotSupportedMessageBuilderException()
        {
        }

        public NotSupportedMessageBuilderException(string message) : base(message)
        {
        }

        public NotSupportedMessageBuilderException(string message, Exception innerException) : base(message,
            innerException)
        {
        }

        protected NotSupportedMessageBuilderException(SerializationInfo info, StreamingContext context) : base(info,
            context)
        {
        }
    }
}
