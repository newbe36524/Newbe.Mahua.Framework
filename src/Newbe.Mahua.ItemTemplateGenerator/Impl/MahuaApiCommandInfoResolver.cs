using Newbe.Mahua.Apis;
using System;
using System.ComponentModel;
using System.Reflection;

namespace Newbe.Mahua.ItemTemplateGenerator.Impl
{
    internal class MahuaApiCommandInfoResolver : IMahuaApiCommandInfoResolver
    {
        public MahuaApiCommandInfo Resolve(Type cmdType)
        {
            var description = ((DescriptionAttribute)cmdType.GetCustomAttribute(typeof(DescriptionAttribute))).Description;
            var re = new MahuaApiCommandInfo
            {
                Summary = description,
                CommandName = cmdType.Name,
                CommandResultName = typeof(ApiMahuaCommand).IsAssignableFrom(cmdType) ? string.Empty : $"{cmdType.Name}Result",
                CommandHandlerName = $"{cmdType.Name}Handler"
            };
            return re;
        }
    }
}
