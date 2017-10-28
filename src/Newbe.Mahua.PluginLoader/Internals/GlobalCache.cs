namespace Newbe.Mahua.Internals
{
    internal static class GlobalCache
    {
        public static ICrossDoaminSerializer CrossDoaminSerializer = new MessagePackerCrossDoaminSerializer();
    }
}
