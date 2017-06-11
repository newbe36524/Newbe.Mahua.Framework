using System;

namespace Newbe.Mahua.Msbuild.Packers
{
    internal class MahuaPluginPackerFactory : IMahuaPluginPackerFactory
    {
        private readonly ILog _log;

        public MahuaPluginPackerFactory(ILog log)
        {
            _log = log;
        }

        public IMahuaPluginPacker Create(MahuaPlatform mahuaPlatform)
        {
            switch (mahuaPlatform)
            {
                case MahuaPlatform.Cqp:
                    return new CqpMahuaPluginPacker(_log);
                case MahuaPlatform.Mpq:
                    break;
                case MahuaPlatform.Amanda:
                    return new AmandaMahuaPluginPacker(_log);
                default:
                    throw new ArgumentOutOfRangeException(nameof(mahuaPlatform), mahuaPlatform, null);
            }
            throw new ArgumentOutOfRangeException(nameof(mahuaPlatform), mahuaPlatform, null);
        }
    }
}