using Autofac;
using System.ComponentModel;
using IContainer = Autofac.IContainer;

namespace Newbe.Mahua
{
    internal class MahuaRobotManagerImpl : IMahuaRobotManager
    {
        private readonly IQqProvider _qqProvider;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public IContainer Container { get; }

        public MahuaRobotManagerImpl(
            IContainer container)
        {
            Container = container;
            _qqProvider = Container.Resolve<IQqProvider>();
        }

        public IRobotSession CreateSession()
        {
            var beginLifetimeScope = Container.BeginLifetimeScope(MahuaGlobal.LifeTimeScopes.RobotSession);
            var re = new RobotSession(beginLifetimeScope, Container);
            re.Init(_qqProvider.DefaultQqProvider);
            return re;
        }

        public IRobotSession CreateSession(string qq)
        {
            if (!_qqProvider.CheckQq(qq))
            {
                throw new QqNotFoundException(qq);
            }
            var beginLifetimeScope = Container.BeginLifetimeScope(MahuaGlobal.LifeTimeScopes.RobotSession);
            var re = new RobotSession(beginLifetimeScope, Container);
            re.Init(qq);
            return re;
        }
    }
}
