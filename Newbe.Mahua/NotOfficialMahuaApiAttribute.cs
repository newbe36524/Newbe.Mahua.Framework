using System;

namespace Newbe.Mahua
{
    /// <summary>
    /// 用于标记非调用官方接口的Api
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class NotOfficialMahuaApiAttribute : Attribute
    {
    }
}