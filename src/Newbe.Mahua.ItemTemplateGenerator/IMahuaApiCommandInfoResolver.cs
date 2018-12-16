using System;

namespace Newbe.Mahua.ItemTemplateGenerator
{
    public interface IMahuaApiCommandInfoResolver
    {
        MahuaApiCommandInfo Resolve(Type cmdType);
    }
}
