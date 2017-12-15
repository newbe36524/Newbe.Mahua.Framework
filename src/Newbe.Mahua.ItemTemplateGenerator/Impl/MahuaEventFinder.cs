using System;
using System.Linq;

namespace Newbe.Mahua.ItemTemplateGenerator.Impl
{
    internal class MahuaEventFinder : IMahuaEventFinder
    {
        public Type[] FindAll()
        {
            var re = typeof(IMahuaEvent).Assembly.GetTypes()
                .Where(x => x != typeof(IMahuaEvent))
                .Where(x => typeof(IMahuaEvent).IsAssignableFrom(x))
                .Where(x => x.IsInterface)
                .ToArray();
            return re;
        }
    }
}
