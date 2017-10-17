using System;
using Microsoft.Build.Utilities;

namespace Newbe.Mahua.Msbuild
{
    internal interface ILog
    {
        void Debug(string message);
    }

    internal class TaskLog : ILog
    {
        private readonly TaskLoggingHelper _taskLoggingHelper;

        public TaskLog(TaskLoggingHelper taskLoggingHelper)
        {
            _taskLoggingHelper = taskLoggingHelper;
        }

        void ILog.Debug(string message)
        {
            _taskLoggingHelper.LogMessage(message);
        }
    }
}