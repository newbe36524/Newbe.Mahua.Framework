using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using Newbe.Mahua.Amanda;
using Newbe.Mahua.Commands;
using Newbe.Mahua.CQP;
using Newbe.Mahua.MPQ;

namespace Newbe.Mahua.MarkdownGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var cqpMahuaEventsUsedInAssembly = GetMahuaEventsUsedInAssembly(typeof(CqpMahuaModule).Assembly);
            var mpqMahuaEventsUsedInAssembly = GetMahuaEventsUsedInAssembly(typeof(MpqMahuaModule).Assembly);
            var amdMahuaEventsUsedInAssembly = GetMahuaEventsUsedInAssembly(typeof(AmandaMahuaModule).Assembly);
            var mahuaEventDescptions = GetAllMahuaEvents().OrderBy(x => x.MahuaEventInterfaceName).ToArray();
            var platformNames = new[] {"CQP", "MPQ", "Amanda"};
            var mahuaApiTemplate = new MahuaEventTemplate
            {
                Session = new Dictionary<string, object>
                {
                    ["table"] = new MahuaEventSupportedTable
                    {
                        MahuaEventDescptions = mahuaEventDescptions,
                        PlatformNames = platformNames,
                        SupportState =
                            mahuaEventDescptions.ToDictionary(x => x,
                                x => new Dictionary<string, bool>
                                {
                                    ["CQP"] = cqpMahuaEventsUsedInAssembly.Contains(x.MahuaEventType),
                                    ["MPQ"] = mpqMahuaEventsUsedInAssembly.Contains(x.MahuaEventType),
                                    ["Amanda"] = amdMahuaEventsUsedInAssembly.Contains(x.MahuaEventType),
                                })
                    }
                }
            };
            mahuaApiTemplate.Initialize();
            var re = mahuaApiTemplate.TransformText();
            Console.WriteLine(re);
            File.WriteAllText("MahuaEvents.md", re);

            var apis = GetAllMahuaApis().OrderBy(x => x.Name).ToArray();
            var cqpApi = GetApiSupportedState(typeof(CqpMahuaModule).Assembly);
            var mpqApi = GetApiSupportedState(typeof(MpqMahuaModule).Assembly);
            var amdApi = GetApiSupportedState(typeof(AmandaMahuaModule).Assembly);
            var mahuaApiSupportedTable = new MahuaApiSupportedTable
            {
                MahuaApiDescriptions = apis,
                PlatformNames = platformNames,
                SupportState = apis.ToDictionary(x => x, x =>
                {
                    var r = new Dictionary<string, SupportStatus>
                    {
                        ["CQP"] = cqpApi[x.Name],
                        ["MPQ"] = mpqApi[x.Name],
                        ["Amanda"] = amdApi[x.Name],
                    };
                    return r;
                })
            };
            var apiTemplate = new MahuaApiTemplate
            {
                Session = new Dictionary<string, object>
                {
                    ["table"] = mahuaApiSupportedTable
                }
            };
            apiTemplate.Initialize();
            var apiMd = apiTemplate.TransformText();
            Console.WriteLine(apiMd);
            File.WriteAllText("MahuaApi.md", apiMd);
        }

        private static Dictionary<string, SupportStatus> GetApiSupportedState(Assembly assembly)
        {
            var apiImpl = assembly.GetTypes().Single(x => x.IsClass && typeof(IMahuaApi).IsAssignableFrom(x));
            var methods = apiImpl.GetMethods()
                .Select(x => new
                {
                    MethodName = x.Name,
                    Supported = x.GetCustomAttribute<NotSupportedMahuaApiAttribute>() == null,
                    Offical = x.GetCustomAttribute<NotOfficialMahuaApiAttribute>() == null,
                })
                .ToDictionary(x => x.MethodName, x => new SupportStatus
                {
                    IsOfficial = x.Offical,
                    IsSupport = x.Supported,
                });
            return methods;
        }

        /// <summary>
        /// 获取程序集中被引用的<see cref="IMahuaEvent"/>
        /// </summary>
        /// <param name="assembly"></param>
        /// <returns></returns>
        private static IEnumerable<Type> GetMahuaEventsUsedInAssembly(Assembly assembly)
        {
            var handlerInterfaceType = typeof(ICommandHandler);
            var handlers = assembly.GetTypes()
                .Where(x => !x.IsAbstract && x.IsClass && handlerInterfaceType.IsAssignableFrom(x)).ToList();
            var arguments = handlers
                .SelectMany(x => x.GetConstructors()
                    .SelectMany(a => a.GetParameters()))
                .Select(x =>
                {
                    var argParameterType = x.ParameterType;
                    if (argParameterType.IsConstructedGenericType)
                    {
                        return argParameterType.GenericTypeArguments.First();
                    }
                    return argParameterType;
                })
                .Where(x => typeof(IMahuaEvent).IsAssignableFrom(x))
                .Distinct()
                .ToList();
            return arguments;
        }

        private static IEnumerable<MahuaApiDescription> GetAllMahuaApis()
        {
            var apiType = typeof(IMahuaApi);
            var re = apiType.GetMethods().Select(x => new MahuaApiDescription(x)).ToList();
            return re;
        }

        /// <summary>
        /// 获取所有MahuaEvents
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<MahuaEventDescption> GetAllMahuaEvents()
        {
            var mahuaEventType = typeof(IMahuaEvent);
            var allMahuaEvents = mahuaEventType.Assembly.GetTypes()
                .Where(x => x.IsInterface && x != mahuaEventType && mahuaEventType.IsAssignableFrom(x)).ToList();
            var mahuaEventDescptions = allMahuaEvents.Select(x => new MahuaEventDescption(x)).ToList();
            return mahuaEventDescptions;
        }
    }

    public class MahuaEventSupportedTable
    {
        public string[] PlatformNames { get; set; }
        public MahuaEventDescption[] MahuaEventDescptions { get; set; }
        public Dictionary<MahuaEventDescption, Dictionary<string, bool>> SupportState { get; set; }
    }

    public class MahuaApiSupportedTable
    {
        public string[] PlatformNames { get; set; }
        public MahuaApiDescription[] MahuaApiDescriptions { get; set; }
        public Dictionary<MahuaApiDescription, Dictionary<string, SupportStatus>> SupportState { get; set; }
    }

    public class SupportStatus
    {
        public bool IsSupport { get; set; }
        public bool IsOfficial { get; set; }
    }

    public class MahuaEventDescption
    {
        public MahuaEventDescption(Type type)
        {
            if (!typeof(IMahuaEvent).IsAssignableFrom(type))
            {
                throw new ArgumentOutOfRangeException(nameof(type), $"给定的类型不是继承自{typeof(IMahuaEvent).FullName}");
            }
            MahuaEventType = type;
            MahuaEventInterfaceName = type.Name;
            MahuaEventDescription = type.GetCustomAttribute<DescriptionAttribute>().Description;
        }

        public Type MahuaEventType { get; set; }

        /// <summary>
        /// 事件描述
        /// </summary>
        public string MahuaEventDescription { get; set; }

        /// <summary>
        /// 事件接口名称
        /// </summary>
        public string MahuaEventInterfaceName { get; set; }
    }

    public class MahuaApiDescription
    {
        public MahuaApiDescription(MethodInfo methodInfo)
        {
            MethodInfo = methodInfo;
            Name = methodInfo.Name;
            Description = methodInfo.GetCustomAttribute<DescriptionAttribute>().Description;
        }

        public MethodInfo MethodInfo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}