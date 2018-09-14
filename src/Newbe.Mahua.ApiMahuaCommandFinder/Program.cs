using Autofac;
using Newbe.Mahua.Amanda;
using Newbe.Mahua.Apis;
using Newbe.Mahua.CQP;
using Newbe.Mahua.CQP.ApiExtensions;
using Newbe.Mahua.MPQ;
using Newbe.Mahua.CleverQQ;
using Newbe.Mahua.QQLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Newbe.Mahua.ApiMahuaCommandFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var plugins = new Dictionary<MahuaPlatform, Assembly>()
            {
                {MahuaPlatform.Cqp, typeof(CqpMahuaModule).Assembly},
                {MahuaPlatform.Mpq, typeof(MpqMahuaModule).Assembly},
                {MahuaPlatform.Amanda, typeof(AmandaMahuaModule).Assembly},
                {MahuaPlatform.CleverQQ, typeof(CleverQQMahuaModule).Assembly},
                {MahuaPlatform.QqLight, typeof(QqLightMahuaModule).Assembly},
            };

            var extensions = new Dictionary<MahuaPlatform, Assembly>
            {
                {MahuaPlatform.Cqp,typeof(CqpApiExtensionsModule).Assembly}
            };
            var all = GetAll();

            var apiTable = new ApiTable
            {
                All = all,
                Plugins = plugins.ToDictionary(x => x.Key, x => GetPluginApi(x.Value)),
                Extensions = extensions.ToDictionary(x => x.Key, x => GetPluginApi(x.Value)),
            };

            var titles = new string[] { "Api", "说明" }.Concat(apiTable.Plugins.Keys.Select(x => x.ToString()));
            Console.WriteLine(string.Join("|", titles));
            Console.WriteLine(string.Join("|", Enumerable.Range(0, 2 + apiTable.Plugins.Count).Select(x => "----")));
            foreach (var api in apiTable.All)
            {
                var line = new List<string>
                {
                    api.Name.Replace("ApiMahuaCommand",string.Empty),
                    api.Description
                };
                foreach (var apiTablePlugin in apiTable.Plugins)
                {
                    if (apiTablePlugin.Value.Any(a => a.Name == api.Name))
                    {
                        line.Add("√");
                    }
                    else
                    {
                        if (apiTable.Extensions.ContainsKey(apiTablePlugin.Key))
                        {
                            var ext = apiTable.Extensions[apiTablePlugin.Key];
                            line.Add(ext.Any(a => a.Name == api.Name) ? "√(ext)" : " ");
                        }
                        else
                        {
                            line.Add(" ");
                        }
                    }
                }
                Console.WriteLine(string.Join("|", line));
            }
        }

        private static IEnumerable<MahuaApiDescription> GetPluginApi(Assembly assembly)
        {
            var type = typeof(IApiCommandHandler);
            var types = assembly.GetTypes();
            var list = types.Where(x => type.IsAssignableFrom(x)).Where(x => x.IsClass && !x.IsAbstract).ToList();
            var re = new List<MahuaApiDescription>();
            foreach (var item in list)
            {
                var handlerType = item
                    .FindInterfaces(
                        (t, o) => t.GenericTypeArguments.Any(), null)
                    .First();
                var cmdType = handlerType.GenericTypeArguments[0];
                re.Add(CreateMahuaApiDescription(cmdType));
            }

            return re;
        }

        private static IEnumerable<MahuaApiDescription> GetAll()
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
            var re = list
                .Select(CreateMahuaApiDescription)
                .ToList();
            return re;
        }

        private static MahuaApiDescription CreateMahuaApiDescription(Type x)
        {
            return new MahuaApiDescription
            {
                Name = x.Name,
                Description = ((DescriptionAttribute)x.GetCustomAttribute(typeof(DescriptionAttribute)))
                    .Description,
            };
        }
    }

    public class ApiTable
    {
        public IEnumerable<MahuaApiDescription> All { get; set; }

        public IDictionary<MahuaPlatform, IEnumerable<MahuaApiDescription>> Plugins { get; set; }

        public IDictionary<MahuaPlatform, IEnumerable<MahuaApiDescription>> Extensions { get; set; }
    }

    public class MahuaApiDescription
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
