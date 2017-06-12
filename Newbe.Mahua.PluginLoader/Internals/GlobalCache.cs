using System.Web.Script.Serialization;

namespace Newbe.Mahua.Internals
{
    internal static class GlobalCache
    {
        public static readonly JavaScriptSerializer JavaScriptSerializer = new JavaScriptSerializer();
    }
}