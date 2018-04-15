using System;
using System.IO;

namespace Newbe.Mahua.CQP.Messages
{
    public static class CqpDirectories
    {
        public static readonly string Image = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "image");
        public static readonly string Record = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "record");
    }
}
