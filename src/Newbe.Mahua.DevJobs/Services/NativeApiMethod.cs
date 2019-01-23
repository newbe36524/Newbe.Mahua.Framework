using System.Collections.Generic;

namespace Newbe.Mahua.NativeApiClassfy.Services
{
    public class NativeApiMethod
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<NativeApiArgument> Arguments { get; set; }
        public string ReturnType { get; set; }
    }
}