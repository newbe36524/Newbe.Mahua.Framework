using System;
using System.Collections.Generic;

namespace Newbe.Mahua.Commands
{
    public static class CommandHandlerExtensions
    {
        public static void Handle<TMahuaEvent>(this IEnumerable<TMahuaEvent> events, Action<TMahuaEvent> handler)
            where TMahuaEvent : IMahuaEvent
        {
            foreach (var mahuaEvent in events)
            {
                handler.Invoke(mahuaEvent);
            }
        }
    }
}