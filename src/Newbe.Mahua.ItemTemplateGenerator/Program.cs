using Autofac;

namespace Newbe.Mahua.ItemTemplateGenerator
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var cb = new ContainerBuilder();
            cb.RegisterAssemblyTypes(typeof(Program).Assembly).AsImplementedInterfaces();
            var container = cb.Build();
            var mahuaItemTemplateGenerator = container.Resolve<IMahuaItemTemplateGenerator>();
            mahuaItemTemplateGenerator.Generate();
        }
    }
}
