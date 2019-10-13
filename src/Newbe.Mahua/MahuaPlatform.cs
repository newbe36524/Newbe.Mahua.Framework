using System;

namespace Newbe.Mahua
{
    /// <summary>
    /// 机器人平台
    /// </summary>
    public enum MahuaPlatform
    {
        /// <summary>
        /// 酷Q
        /// </summary>
        Cqp,

        /// <summary>
        /// MyPCQQ
        /// </summary>
        Mpq,

        /// <summary>
        /// Amanda
        /// </summary>
        [Obsolete("已经不再支持该平台")]
        Amanda,

        /// <summary>
        /// CleverQQ
        /// </summary>
        [Obsolete("已经不再支持该平台")]
        CleverQQ,

        /// <summary>
        /// QqLight
        /// </summary>
        QQLight,

    }
}
