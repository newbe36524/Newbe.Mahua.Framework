using System;

namespace Newbe.Mahua.Samples.OkexRobot.Common
{
    public class LocalCache<T> where T : class
    {
        private DateTime _lastTime = DateTime.MinValue;
        private T _data = default(T);

        public T Get(int seconds, Func<T> getter)
        {
            var now = DateTime.UtcNow;
            if (_lastTime.Add(TimeSpan.FromSeconds(seconds)) < now)
            {
                _data = getter();
                _lastTime = now;
            }

            return _data;
        }
    }
}
