using Newbe.Mahua.Apis;
using System;
using System.Linq;

namespace Newbe.Mahua.ItemTemplateGenerator.Impl
{
    internal class MahuaApiCommandFinder : IMahuaApiCommandFinder
    {
        public Type[] FindAll()
        {
            var type = typeof(ApiMahuaCommand);
            var gertype = typeof(ApiMahuaCommand<>);
            var types = typeof(ApiMahuaCommand).Assembly.GetTypes();
            var list = types
                .Where(x => typeof(IApiMahuaCommand).IsAssignableFrom(x))
                .Where(x => x.IsClass && !x.IsAbstract)
                .Where(x => x != type)
                .Where(x => x != gertype)
                .ToList();
            return list.ToArray();
        }
    }
}
