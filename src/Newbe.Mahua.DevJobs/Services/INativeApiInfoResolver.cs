namespace Newbe.Mahua.NativeApiClassfy.Services
{
    public interface INativeApiInfoResolver
    {
        NativeApiInfo GetMahuaApiInfo(string mahuaApiSourceCode);
    }
}