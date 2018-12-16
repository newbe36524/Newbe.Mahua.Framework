using System;
using System.Linq;

namespace Newbe.Mahua.ItemTemplateGenerator.Impl
{
    internal class MahuaItemTemplateGenerator : IMahuaItemTemplateGenerator
    {
        private readonly IMahuaEventFinder _mahuaEventFinder;
        private readonly IMahuaApiCommandFinder _mahuaApiCommandFinder;
        private readonly IMahuaEventInfoResolver _mahuaEventInfoResolver;
        private readonly IMahuaApiCommandInfoResolver _mahuaApiCommandInfoResolver;
        private readonly IMahuaEventItemTemplateGenerator _mahuaEventItemTemplateGenerator;
        private readonly IMahuaApiCommandHandlerItemTemplateGenerator _apiCommandHandlerItemTemplateGenerator;

        public MahuaItemTemplateGenerator(
            IMahuaEventFinder mahuaEventFinder,
            IMahuaApiCommandFinder mahuaApiCommandFinder,
            IMahuaEventInfoResolver mahuaEventInfoResolver,
            IMahuaApiCommandInfoResolver mahuaApiCommandInfoResolver,
            IMahuaEventItemTemplateGenerator mahuaEventItemTemplateGenerator,
            IMahuaApiCommandHandlerItemTemplateGenerator apiCommandHandlerItemTemplateGenerator)
        {
            _mahuaEventFinder = mahuaEventFinder;
            _mahuaApiCommandFinder = mahuaApiCommandFinder;
            _mahuaEventInfoResolver = mahuaEventInfoResolver;
            _mahuaApiCommandInfoResolver = mahuaApiCommandInfoResolver;
            _mahuaEventItemTemplateGenerator = mahuaEventItemTemplateGenerator;
            _apiCommandHandlerItemTemplateGenerator = apiCommandHandlerItemTemplateGenerator;
        }

        public void Generate()
        {
            var allApi = _mahuaApiCommandFinder.FindAll();
            var mahuaApiCommandInfos = allApi
                .Select(x => _mahuaApiCommandInfoResolver.Resolve(x))
                .ToArray();
            Console.WriteLine($"共找到{mahuaApiCommandInfos.Length}个ApiCommand");
            foreach (var mahuaApiCommandInfo in mahuaApiCommandInfos)
            {
                var fileName = _apiCommandHandlerItemTemplateGenerator.Generate(mahuaApiCommandInfo);
                Console.WriteLine($"成功生成项模板{mahuaApiCommandInfo.Summary}:{fileName}");
            }

            var allMahuaEvents = _mahuaEventFinder.FindAll();
            var mahuaEventInfos = allMahuaEvents
                .Select(x => _mahuaEventInfoResolver.Resolve(x))
                .ToArray();
            Console.WriteLine($"共找到{mahuaEventInfos.Length}个IMahuaEvent");
            foreach (var mahuaEventInfo in mahuaEventInfos)
            {
                var fileName = _mahuaEventItemTemplateGenerator.Generate(mahuaEventInfo);
                Console.WriteLine($"成功生成项模板{mahuaEventInfo.Summary}:{fileName}");
            }
        }
    }
}
