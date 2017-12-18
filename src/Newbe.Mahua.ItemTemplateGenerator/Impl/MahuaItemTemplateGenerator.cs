using System;
using System.Linq;

namespace Newbe.Mahua.ItemTemplateGenerator.Impl
{
    internal class MahuaItemTemplateGenerator : IMahuaItemTemplateGenerator
    {
        private readonly IMahuaEventFinder _mahuaEventFinder;
        private readonly IMahuaEventDesciptorResolver _mahuaEventDesciptorResolver;
        private readonly IMahuaEventItemTemplateGenerator _mahuaEventItemTemplateGenerator;

        public MahuaItemTemplateGenerator(
            IMahuaEventFinder mahuaEventFinder,
            IMahuaEventDesciptorResolver mahuaEventDesciptorResolver,
            IMahuaEventItemTemplateGenerator mahuaEventItemTemplateGenerator)
        {
            _mahuaEventFinder = mahuaEventFinder;
            _mahuaEventDesciptorResolver = mahuaEventDesciptorResolver;
            _mahuaEventItemTemplateGenerator = mahuaEventItemTemplateGenerator;
        }

        public void Generate()
        {
            var allMahuaEvents = _mahuaEventFinder.FindAll();
            var mahuaEventDesciptors = allMahuaEvents
                .Select(x => _mahuaEventDesciptorResolver.Resolve(x))
                .ToArray();
            Console.WriteLine($"共找到{mahuaEventDesciptors.Length}个IMahuaEvent");
            foreach (var mahuaEventDesciptor in mahuaEventDesciptors)
            {
                var fileName = _mahuaEventItemTemplateGenerator.Generate(mahuaEventDesciptor);
                Console.WriteLine($"成功生成项模板{mahuaEventDesciptor.Summary}:{fileName}");
            }
        }
    }
}
