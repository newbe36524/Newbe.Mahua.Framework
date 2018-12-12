using Newbe.Mahua.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Newbe.Mahua.Commands.ExceptionHandles
{
    public class TargetInvocationExceptionHandleCommandCenter : ICommandCenter
    {
        private readonly ICommandCenter _commandCenter;
        private static readonly ILog Logger = LogProvider.GetLogger(typeof(PluginInstanceManager));

        public TargetInvocationExceptionHandleCommandCenter(ICommandCenter commandCenter)
        {
            _commandCenter = commandCenter;
        }

        void ICommandCenter.Handle<TCommand>(TCommand command)
        {
            try
            {
                _commandCenter.Handle(command);
            }
            catch (TargetInvocationException ex)
            {
                Logger.Error(ex.Message);
            }
            catch (Exception)
            {
                throw;
            }
        }

        TResult ICommandCenter.HandleWithResult<TCommand, TResult>(TCommand command)
        {
            try
            {
                return _commandCenter.HandleWithResult<TCommand, TResult>(command);
            }
            catch (TargetInvocationException ex)
            {
                Logger.Error(ex.Message);
                return new TResult();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
