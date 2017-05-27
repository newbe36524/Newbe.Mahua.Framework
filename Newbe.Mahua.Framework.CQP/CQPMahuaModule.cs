using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace Newbe.Mahua.Framework.CQP
{
    // ReSharper disable once InconsistentNaming
    public class CQPMahuaModule : IMahuaModule
    {
        Module[] IMahuaModule.GetModules()
        {
            return new Module[] {new CQPModule(),};
        }


        // ReSharper disable once InconsistentNaming
        class CQPModule : Autofac.Module
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