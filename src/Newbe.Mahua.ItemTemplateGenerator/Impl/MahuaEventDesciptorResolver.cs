using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Newbe.Mahua.ItemTemplateGenerator.Impl
{
    internal class MahuaEventDesciptorResolver : IMahuaEventDesciptorResolver
    {
        public MahuaEventDesciptor Resolve(Type mahuaEventType)
        {
            var method = mahuaEventType.GetMethods().Single();
            var contextType = method.GetParameters().Single().ParameterType;
            var re = new MahuaEventDesciptor
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
