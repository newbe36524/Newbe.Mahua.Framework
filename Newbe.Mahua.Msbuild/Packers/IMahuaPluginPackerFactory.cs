namespace Newbe.Mahua.Msbuild.Packers
{
    public interface IMahuaPluginPackerFactory
    {
        IMahuaPluginPacker Create(MahuaPlatform mahuaPlatform);
    }
}