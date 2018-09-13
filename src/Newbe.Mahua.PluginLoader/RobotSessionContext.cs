using System;

namespace Newbe.Mahua
{
    internal class RobotSessionContext : IRobotSessionContext
    {
        private string _currentQq;

        public string CurrentQq
        {
            get { return _currentQq ?? (_currentQq = CurrentQqProvider()); }
            set { _currentQq = value; }
        }

        public Func<string> CurrentQqProvider { get; set; }
    }
}
