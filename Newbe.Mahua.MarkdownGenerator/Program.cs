using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
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
            var mahuaApiTemplate = new MahuaApiTemplate();
            var mahuaEventDescptions = GetAllMahuaEvents().OrderBy(x => x.MahuaEventInterfaceName).ToArray();
            mahuaApiTemplate.Session = new Dictionary<string, object>
            {
                ["table"] = new MahuaEventSupportedTable
                {
                    MahuaEventDescptions = mahuaEventDescptions,
                    PlatformNames = new[] {"CQP", "MPQ"},
                    SupportState =
                        mahuaEventDescptions.ToDictionary(x => x,
                            x => new Dictionary<string, bool>
                            {
                                ["CQP"] = cqpMahuaEventsUsedInAssembly.Contains(x.MahuaEventType),
                                ["MPQ"] = mpqMahuaEventsUsedInAssembly.Contains(x.MahuaEventType),
                            })
                }
            };
            mahuaApiTemplate.Initialize();
            var re = mahuaApiTemplate.TransformText();
            Console.WriteLine(re);
            File.WriteAllText("MahuaEvents.md", re);
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

        /// <summary>
        /// 获取所有MahuaEvents
        /// </summary>
        /// <returns></returns>
        private static List<MahuaEventDescption> GetAllMahuaEvents()
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
}