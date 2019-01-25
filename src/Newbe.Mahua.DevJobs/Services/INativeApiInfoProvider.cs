namespace Newbe.Mahua.NativeApiClassfy.Services
{
    public interface INativeApiInfoProvider
    {
        NativeApiInfo Get(MahuaPlatform mahuaPlatform);
    }
}