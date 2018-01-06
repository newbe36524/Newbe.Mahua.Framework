using System;

namespace Newbe.Mahua.ItemTemplateGenerator
{
    public interface IMahuaApiCommandDesciptorResolver
    {
        MahuaApiCommandDesciptor Resolve(Type cmdType);
    }
}
