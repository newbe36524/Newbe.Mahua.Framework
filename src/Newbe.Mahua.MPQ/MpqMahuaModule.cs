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
                builder.RegisterType<ConfigurationManagerCommandHandler>().AsImplementedInterfaces();
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
                builder.RegisterType<EventFun1>().AsImplementedInterfaces().Keyed<IEventFun>(1);
                builder.RegisterType<EventFun2>().AsImplementedInterfaces().Keyed<IEventFun>(2);
                builder.RegisterType<EventFun3>().AsImplementedInterfaces().Keyed<IEventFun>(3);
                builder.RegisterType<EventFun4>().AsImplementedInterfaces().Keyed<IEventFun>(4);
                builder.RegisterType<EventFun5>().AsImplementedInterfaces().Keyed<IEventFun>(5);
                builder.RegisterType<EventFun1000>().AsImplementedInterfaces().Keyed<IEventFun>(1000);
                builder.RegisterType<EventFun1001>().AsImplementedInterfaces().Keyed<IEventFun>(1001);
                builder.RegisterType<EventFun1002>().AsImplementedInterfaces().Keyed<IEventFun>(1002);
                builder.RegisterType<EventFun1003>().AsImplementedInterfaces().Keyed<IEventFun>(1003);
                builder.RegisterType<EventFun1004>().AsImplementedInterfaces().Keyed<IEventFun>(1004);
                builder.RegisterType<EventFun1005>().AsImplementedInterfaces().Keyed<IEventFun>(1005);
                builder.RegisterType<EventFun1006>().AsImplementedInterfaces().Keyed<IEventFun>(1006);
                builder.RegisterType<EventFun1007>().AsImplementedInterfaces().Keyed<IEventFun>(1007);
                builder.RegisterType<EventFun1008>().AsImplementedInterfaces().Keyed<IEventFun>(1008);
                builder.RegisterType<EventFun2001>().AsImplementedInterfaces().Keyed<IEventFun>(2001);
                builder.RegisterType<EventFun2002>().AsImplementedInterfaces().Keyed<IEventFun>(2002);
                builder.RegisterType<EventFun2003>().AsImplementedInterfaces().Keyed<IEventFun>(2003);
                builder.RegisterType<EventFun2005>().AsImplementedInterfaces().Keyed<IEventFun>(2005);
                builder.RegisterType<EventFun2006>().AsImplementedInterfaces().Keyed<IEventFun>(2006);
                builder.RegisterType<EventFun2007>().AsImplementedInterfaces().Keyed<IEventFun>(2007);
                builder.RegisterType<EventFun2008>().AsImplementedInterfaces().Keyed<IEventFun>(2008);
                builder.RegisterType<EventFun2009>().AsImplementedInterfaces().Keyed<IEventFun>(2009);
                builder.RegisterType<EventFun2010>().AsImplementedInterfaces().Keyed<IEventFun>(2010);
                builder.RegisterType<EventFun2011>().AsImplementedInterfaces().Keyed<IEventFun>(2011);
                builder.RegisterType<EventFun2012>().AsImplementedInterfaces().Keyed<IEventFun>(2012);
                builder.RegisterType<EventFun2013>().AsImplementedInterfaces().Keyed<IEventFun>(2013);
                builder.RegisterType<EventFun2014>().AsImplementedInterfaces().Keyed<IEventFun>(2014);
                builder.RegisterType<EventFun2015>().AsImplementedInterfaces().Keyed<IEventFun>(2015);
                builder.RegisterType<EventFun2016>().AsImplementedInterfaces().Keyed<IEventFun>(2016);
                builder.RegisterType<EventFun2017>().AsImplementedInterfaces().Keyed<IEventFun>(2017);
                builder.RegisterType<EventFun2018>().AsImplementedInterfaces().Keyed<IEventFun>(2018);
                builder.RegisterType<EventFun2019>().AsImplementedInterfaces().Keyed<IEventFun>(2019);
                builder.RegisterType<EventFun10000>().AsImplementedInterfaces().Keyed<IEventFun>(10000);
                builder.RegisterType<EventFun10001>().AsImplementedInterfaces().Keyed<IEventFun>(10001);
                builder.RegisterType<EventFun11000>().AsImplementedInterfaces().Keyed<IEventFun>(11000);
                builder.RegisterType<EventFun11001>().AsImplementedInterfaces().Keyed<IEventFun>(11001);
                builder.RegisterType<EventFun11002>().AsImplementedInterfaces().Keyed<IEventFun>(11002);
                builder.RegisterType<EventFun11003>().AsImplementedInterfaces().Keyed<IEventFun>(11003);
                builder.RegisterType<EventFun11004>().AsImplementedInterfaces().Keyed<IEventFun>(11004);
                builder.RegisterType<EventFun12000>().AsImplementedInterfaces().Keyed<IEventFun>(12000);
                builder.RegisterType<EventFun12001>().AsImplementedInterfaces().Keyed<IEventFun>(12001);
                builder.RegisterType<EventFun12002>().AsImplementedInterfaces().Keyed<IEventFun>(12002);
                builder.RegisterType<EventFun12003>().AsImplementedInterfaces().Keyed<IEventFun>(12003);
                builder.RegisterType<EventFun80001>().AsImplementedInterfaces().Keyed<IEventFun>(80001);
            }
        }
    }
}
