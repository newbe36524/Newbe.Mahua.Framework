namespace Newbe.Mahua.Internals
{
    internal interface IPlatformResolver
    {
        MahuaPlatform MahuaPlatform { get; }

        bool IsThis();
    }
}