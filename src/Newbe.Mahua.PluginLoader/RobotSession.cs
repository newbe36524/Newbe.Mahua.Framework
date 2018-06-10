using Autofac;
using System;

namespace Newbe.Mahua
{
    internal class RobotSession : IRobotSession
    {
        public RobotSession(
            ILifetimeScope lifetimeScope)
        {
            LifetimeScope = lifetimeScope;
        }

        public void Init(string qq)
        {
            var qqSession = LifetimeScope.Resolve<IRobotSessionContext>();
            qqSession.CurrentQq = qq;
        }

        public void Init(Func<string> qqfunc)
        {
            var qqSession = LifetimeScope.Resolve<IRobotSessionContext>();
            qqSession.CurrentQqProvider = qqfunc;
        }

        #region IDisposable Support
        private bool _disposedValue; // 要检测冗余调用
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    LifetimeScope?.Dispose();
                }
                _disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion

        public IMahuaApi MahuaApi => LifetimeScope.Resolve<IMahuaApi>();
        public ILifetimeScope LifetimeScope { get; }
    }
}
