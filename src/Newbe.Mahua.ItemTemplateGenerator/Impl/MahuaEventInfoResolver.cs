using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Newbe.Mahua.ItemTemplateGenerator.Impl
{
    internal class MahuaEventInfoResolver : IMahuaEventInfoResolver
    {
        public MahuaEventInfo Resolve(Type mahuaEventType)
        {
            var method = mahuaEventType.GetMethods().Single();
            var contextType = method.GetParameters().Single().ParameterType;
            var re = new MahuaEventInfo
            {
                Name = mahuaEventType.Name,
                Summary = ((DescriptionAttribute)mahuaEventType.GetCustomAttributes(typeof(DescriptionAttribute))
                        .First())
                    .Description,
                Type = mahuaEventType,
                MethodName = method.Name,
                MethodContextName = contextType.Name,
                MethodContextType = contextType
            };
            return re;
        }
    }
}
