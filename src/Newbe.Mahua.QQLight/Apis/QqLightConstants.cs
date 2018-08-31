namespace Newbe.Mahua.QQLight.Apis
{
    internal static class QqLightConstants
    {
#pragma warning disable S125 // Sections of code should not be "commented out"
        internal static readonly int MsgType好友消息 = 1;

        internal static readonly int MsgType群消息 = 2;

        //// todo _msgType群临时消息3;
        internal static readonly int MsgType讨论组消息 = 4;

        //// todo _msgType讨论组临时消息5;
        internal static readonly int Operation同意 = 1;

        internal static readonly int Operation拒绝 = 2;
        //// todo _operation忽略3;
#pragma warning restore S125 // Sections of code should not be "commented out"
    }
}
