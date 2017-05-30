using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Newbe.Mahua.Framework.Commands;
using Newbe.Mahua.Framework.Commands.Impl;

namespace Newbe.Mahua.Framework
{
    class PluginLoaderMahuaModule : IMahuaModule
    {
        Module[] IMahuaModule.GetModules()
        {
            return new Module[] {new PluginLoaderModule(),};
        }

        public class PluginLoaderModule : Autofac.Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<CommandCenter>().As<ICommandCenter>();
            }
        }
    }
}