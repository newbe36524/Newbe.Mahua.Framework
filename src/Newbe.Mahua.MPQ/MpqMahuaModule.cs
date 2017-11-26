using Autofac;
using Newbe.Mahua.MPQ.Commands;
using Newbe.Mahua.MPQ.EventFuns;

namespace Newbe.Mahua.MPQ
{
    public class MpqMahuaModule : IMahuaModule
    {
        public Module[] GetModules()
        {
            return new Module[]
            {
                new MpqCommandHandlerModule(),
                new MpqApiModule(),
                new MpqEventFunModule()
            };
        }

        private class MpqCommandHandlerModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<AboutCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<EndCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<EventFunCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<GetInfoCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<SetCommandHandler>().AsImplementedInterfaces();
            }
        }

        private class MpqApiModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<MahuaApi>().As<IMahuaApi>().InstancePerLifetimeScope();
                builder.RegisterType<QqSession>().As<IQqSession>().InstancePerLifetimeScope();
                builder.RegisterType<EventFunOutput>().As<IEventFunOutput>().InstancePerLifetimeScope();
            }
        }

        private class MpqEventFunModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<EventFunHandler1>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler2>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler3>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler4>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler1000>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler1001>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler1002>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler1003>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler1004>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler1005>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler1006>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler1007>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler1008>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler2001>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler2002>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler2003>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler2005>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler2006>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler2007>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler2008>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler2009>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler2010>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler2011>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler2012>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler2013>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler2014>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler2015>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler2016>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler2017>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler2018>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler2019>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler10000>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler10001>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler11000>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler11001>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler11002>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler11003>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler11004>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler12000>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler12001>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler12002>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler12003>().AsImplementedInterfaces();
                builder.RegisterType<EventFunHandler80001>().AsImplementedInterfaces();
            }
        }
    }
}
