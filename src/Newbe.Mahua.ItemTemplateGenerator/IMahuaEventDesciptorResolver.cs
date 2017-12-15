using Newbe.Mahua.ItemTemplateGenerator.Impl;
using System;

namespace Newbe.Mahua.ItemTemplateGenerator
{
    public interface IMahuaEventDesciptorResolver
    {
        MahuaEventDesciptor Resolve(Type mahuaEventType);
    }
}
