using Autofac;
using System;

namespace Newbe.Mahua
{
    /// <summary>
    /// 机器人会话，开启操作QQ机器人的桥梁
    /// </summary>
    public interface IRobotSession : IDisposable
    {
        IMahuaApi MahuaApi { get; }
        ILifetimeScope LifetimeScope { get; }
    }
}
