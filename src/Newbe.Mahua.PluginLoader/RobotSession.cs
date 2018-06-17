using Autofac;
using System;

namespace Newbe.Mahua
{
    internal class RobotSession : IRobotSession
    {
        private readonly IContainer _container;

        public RobotSession(
            ILifetimeScope lifetimeScope,
            IContainer container)
        {
            _container = container;
            LifetimeScope = lifetimeScope;
        }

        public void Init(string qq)
        {
            var qqSession = LifetimeScope.Resolve<IRobotSessionContext>();
            qqSession.CurrentQq = qq;
            EnsureMahuaApiHasContainer();
        }

        public void Init(Func<string> qqfunc)
        {
            var qqSession = LifetimeScope.Resolve<IRobotSessionContext>();
            qqSession.CurrentQqProvider = qqfunc;
            EnsureMahuaApiHasContainer();
        }

        private void EnsureMahuaApiHasContainer()
        {
            var mahuaApi = LifetimeScope.Resolve<IMahuaApi>();
            mahuaApi.SetLifetimeScope(LifetimeScope);
            mahuaApi.SetSourceContainer(_container);
        }

        public IMahuaApi MahuaApi
        {
            get
            {
                var mahuaApi = LifetimeScope.Resolve<IMahuaApi>();
                return mahuaApi;
            }
        }

        public ILifetimeScope LifetimeScope { get; }

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
    }
}
