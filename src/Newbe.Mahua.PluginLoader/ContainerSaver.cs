using Autofac;

namespace Newbe.Mahua
{
    internal class ContainerSaver : IContainerSaver
    {
        private ILifetimeScope _lifetimeScope;
        private IContainer _container;

        public void SetContainer(ILifetimeScope container)
        {
            SetLifetimeScope(container);
        }

        public ILifetimeScope GetLifetimeScope()
        {
            return _lifetimeScope;
        }

        public void SetLifetimeScope(ILifetimeScope container)
        {
            _lifetimeScope = container;
        }

        public IContainer GetSourceContainer()
        {
            return _container;
        }

        public void SetSourceContainer(IContainer container)
        {
            _container = container;
        }
    }
}
