using System.Collections.Generic;

namespace Newbe.Mahua.NativeApiClassfy.Services
{
    public class NativeApiInfo
    {
        public string Name { get; set; }
        public IEnumerable<NativeApiMethod> Methods { get; set; }
    }
}