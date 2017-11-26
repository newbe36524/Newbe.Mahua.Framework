namespace Newbe.Mahua.Internals
{
    internal static class GlobalCache
    {
        public static readonly ICrossDoaminSerializer CrossDoaminSerializer = new MessagePackerCrossDoaminSerializer();
    }
}
