using System;

namespace Newbe.Mahua.Msbuild.Packers
{
    internal class MahuaPluginPackerFactory : IMahuaPluginPackerFactory
    {
        public IMahuaPluginPacker Create(MahuaPlatform mahuaPlatform)
        {
            switch (mahuaPlatform)
            {
                case MahuaPlatform.Cqp:
                    return new CqpMahuaPluginPacker();
                case MahuaPlatform.Mpq:
                    break;
                case MahuaPlatform.Amanda:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(mahuaPlatform), mahuaPlatform, null);
            }
            throw new ArgumentOutOfRangeException(nameof(mahuaPlatform), mahuaPlatform, null);
        }
    }
}