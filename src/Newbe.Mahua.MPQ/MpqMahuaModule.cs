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
                builder.RegisterType<EventFunHandler1>().AsImplementedInterfaces().Keyed<int>(1);
                builder.RegisterType<EventFunHandler2>().AsImplementedInterfaces().Keyed<int>(2);
                builder.RegisterType<EventFunHandler3>().AsImplementedInterfaces().Keyed<int>(3);
                builder.RegisterType<EventFunHandler4>().AsImplementedInterfaces().Keyed<int>(4);
                builder.RegisterType<EventFunHandler5>().AsImplementedInterfaces().Keyed<int>(5);
                builder.RegisterType<EventFunHandler1000>().AsImplementedInterfaces().Keyed<int>(1000);
                builder.RegisterType<EventFunHandler1001>().AsImplementedInterfaces().Keyed<int>(1001);
                builder.RegisterType<EventFunHandler1002>().AsImplementedInterfaces().Keyed<int>(1002);
                builder.RegisterType<EventFunHandler1003>().AsImplementedInterfaces().Keyed<int>(1003);
                builder.RegisterType<EventFunHandler1004>().AsImplementedInterfaces().Keyed<int>(1004);
                builder.RegisterType<EventFunHandler1005>().AsImplementedInterfaces().Keyed<int>(1005);
                builder.RegisterType<EventFunHandler1006>().AsImplementedInterfaces().Keyed<int>(1006);
                builder.RegisterType<EventFunHandler1007>().AsImplementedInterfaces().Keyed<int>(1007);
                builder.RegisterType<EventFunHandler1008>().AsImplementedInterfaces().Keyed<int>(1008);
                builder.RegisterType<EventFunHandler2001>().AsImplementedInterfaces().Keyed<int>(2001);
                builder.RegisterType<EventFunHandler2002>().AsImplementedInterfaces().Keyed<int>(2002);
                builder.RegisterType<EventFunHandler2003>().AsImplementedInterfaces().Keyed<int>(2003);
                builder.RegisterType<EventFunHandler2005>().AsImplementedInterfaces().Keyed<int>(2005);
                builder.RegisterType<EventFunHandler2006>().AsImplementedInterfaces().Keyed<int>(2006);
                builder.RegisterType<EventFunHandler2007>().AsImplementedInterfaces().Keyed<int>(2007);
                builder.RegisterType<EventFunHandler2008>().AsImplementedInterfaces().Keyed<int>(2008);
                builder.RegisterType<EventFunHandler2009>().AsImplementedInterfaces().Keyed<int>(2009);
                builder.RegisterType<EventFunHandler2010>().AsImplementedInterfaces().Keyed<int>(2010);
                builder.RegisterType<EventFunHandler2011>().AsImplementedInterfaces().Keyed<int>(2011);
                builder.RegisterType<EventFunHandler2012>().AsImplementedInterfaces().Keyed<int>(2012);
                builder.RegisterType<EventFunHandler2013>().AsImplementedInterfaces().Keyed<int>(2013);
                builder.RegisterType<EventFunHandler2014>().AsImplementedInterfaces().Keyed<int>(2014);
                builder.RegisterType<EventFunHandler2015>().AsImplementedInterfaces().Keyed<int>(2015);
                builder.RegisterType<EventFunHandler2016>().AsImplementedInterfaces().Keyed<int>(2016);
                builder.RegisterType<EventFunHandler2017>().AsImplementedInterfaces().Keyed<int>(2017);
                builder.RegisterType<EventFunHandler2018>().AsImplementedInterfaces().Keyed<int>(2018);
                builder.RegisterType<EventFunHandler2019>().AsImplementedInterfaces().Keyed<int>(2019);
                builder.RegisterType<EventFunHandler10000>().AsImplementedInterfaces().Keyed<int>(10000);
                builder.RegisterType<EventFunHandler10001>().AsImplementedInterfaces().Keyed<int>(10001);
                builder.RegisterType<EventFunHandler11000>().AsImplementedInterfaces().Keyed<int>(11000);
                builder.RegisterType<EventFunHandler11001>().AsImplementedInterfaces().Keyed<int>(11001);
                builder.RegisterType<EventFunHandler11002>().AsImplementedInterfaces().Keyed<int>(11002);
                builder.RegisterType<EventFunHandler11003>().AsImplementedInterfaces().Keyed<int>(11003);
                builder.RegisterType<EventFunHandler11004>().AsImplementedInterfaces().Keyed<int>(11004);
                builder.RegisterType<EventFunHandler12000>().AsImplementedInterfaces().Keyed<int>(12000);
                builder.RegisterType<EventFunHandler12001>().AsImplementedInterfaces().Keyed<int>(12001);
                builder.RegisterType<EventFunHandler12002>().AsImplementedInterfaces().Keyed<int>(12002);
                builder.RegisterType<EventFunHandler12003>().AsImplementedInterfaces().Keyed<int>(12003);
                builder.RegisterType<EventFunHandler80001>().AsImplementedInterfaces().Keyed<int>(80001);
            }
        }
    }
}
