using Newbe.Mahua.ItemTemplateGenerator.Impl;
using System;

namespace Newbe.Mahua.ItemTemplateGenerator
{
    public interface IMahuaEventInfoResolver
    {
        MahuaEventInfo Resolve(Type mahuaEventType);
    }
}
