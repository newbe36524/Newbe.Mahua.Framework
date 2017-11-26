using MessagePack;
using System;
using System.Linq;
using System.Reflection;

namespace Newbe.Mahua.Internals
{
    internal class MessagePackerCrossDoaminSerializer : ICrossDoaminSerializer
    {
        private readonly MethodInfo _messagePackSerializerDeserializeMethod =
            typeof(MessagePackSerializer)
                .GetMethod(nameof(MessagePackSerializer.Deserialize), new[] { typeof(byte[]) });

        object ICrossDoaminSerializer.Deserialize(byte[] source, Type type)
        {
            return _messagePackSerializerDeserializeMethod.MakeGenericMethod(type).Invoke(null, new object[] { source });
        }

        private readonly MethodInfo _serializeMethod = typeof(MessagePackSerializer).GetMethods().First(x =>
            x.Name == nameof(MessagePackSerializer.Serialize) && x.GetParameters().Length == 1);

        byte[] ICrossDoaminSerializer.Serialize(object source, Type type)
        {
            var bytes = (byte[])_serializeMethod.MakeGenericMethod(type).Invoke(null, new[] { source });
            return bytes;
        }
    }
}
