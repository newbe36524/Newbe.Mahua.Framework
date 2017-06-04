using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Newbe.Mahua
{
    /// <summary>
    /// 用于标记在特定平台上不受支持的Api
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class NotSupportedMahuaApiAttribute : Attribute
    {
    }
}