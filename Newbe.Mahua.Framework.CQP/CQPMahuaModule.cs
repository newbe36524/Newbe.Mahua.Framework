using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Newbe.Mahua.Framework.CQP.CommandHandlers;
using Newbe.Mahua.Framework.CQP.Commands;

namespace Newbe.Mahua.Framework.CQP
{
    // ReSharper disable once InconsistentNaming
    public class CQPMahuaModule : IMahuaModule
    {
        Module[] IMahuaModule.GetModules()
        {
            return new Module[] {new CqpModule(), new CommandModule(), new CommandHandlersModule()};
        }

        private class CommandModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<AppInfoCommand>().As<MahuaCommand>();
                builder.RegisterType<InitializeCommand>().As<MahuaCommand>();
                builder.RegisterType<EnabledCommand>().As<MahuaCommand>();
            }
        }

        private class CommandHandlersModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<AppInfoCommandHandler>().As<IResultCommandHandler>();
                builder.RegisterType<InitializeCommandHandler>().As<IVoidCommandHandler>();
                builder.RegisterType<EnabledCommandHandler>().As<IVoidCommandHandler>();
            }
        }

        private class CqpModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<CoolQApi>().As<ICoolQApi>().SingleInstance();
                builder.RegisterType<MahuaApi>().As<IMahuaApi>().SingleInstance();
            }
        }
    }
}