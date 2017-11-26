using System;

namespace Newbe.Mahua.Internals
{
    internal interface ICrossDoaminSerializer
    {
        byte[] Serialize(object source, Type type);
        object Deserialize(byte[] source, Type type);
    }
}
