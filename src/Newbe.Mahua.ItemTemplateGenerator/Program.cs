using Autofac;
using Newbe.Mahua.ItemTemplateGenerator.Impl;
//using Newbe.Mahua.ItemTemplateGenerator.Impl.VsExtensions;
using Newbe.Mahua.ItemTemplateGenerator.Impl.DotnetNew;

namespace Newbe.Mahua.ItemTemplateGenerator
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var cb = new ContainerBuilder();
            cb.RegisterType<MahuaApiCommandFinder>().AsImplementedInterfaces();
            cb.RegisterType<MahuaApiCommandInfoResolver>().AsImplementedInterfaces();
            cb.RegisterType<MahuaEventFinder>().AsImplementedInterfaces();
            cb.RegisterType<MahuaEventInfoResolver>().AsImplementedInterfaces();

            cb.RegisterType<MahuaApiCommandHandlerItemTemplateGenerator>().AsImplementedInterfaces();
            cb.RegisterType<MahuaEventItemTemplateGenerator>().AsImplementedInterfaces();

            cb.RegisterType<MahuaItemTemplateGenerator>().AsImplementedInterfaces();
            var container = cb.Build();
            var mahuaItemTemplateGenerator = container.Resolve<IMahuaItemTemplateGenerator>();
            mahuaItemTemplateGenerator.Generate();
        }
    }
}