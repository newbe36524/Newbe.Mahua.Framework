using System;
using System.Linq;

namespace Newbe.Mahua.ItemTemplateGenerator.Impl
{
    internal class MahuaItemTemplateGenerator : IMahuaItemTemplateGenerator
    {
        private readonly IMahuaEventFinder _mahuaEventFinder;
        private readonly IMahuaApiCommandFinder _mahuaApiCommandFinder;
        private readonly IMahuaEventDesciptorResolver _mahuaEventDesciptorResolver;
        private readonly IMahuaApiCommandDesciptorResolver _mahuaApiCommandDesciptorResolver;
        private readonly IMahuaEventItemTemplateGenerator _mahuaEventItemTemplateGenerator;
        private readonly IMahuaApiCommandHandlerItemTemplateGernerator _apiCommandHandlerItemTemplateGernerator;

        public MahuaItemTemplateGenerator(
            IMahuaEventFinder mahuaEventFinder,
            IMahuaApiCommandFinder mahuaApiCommandFinder,
            IMahuaEventDesciptorResolver mahuaEventDesciptorResolver,
            IMahuaApiCommandDesciptorResolver mahuaApiCommandDesciptorResolver,
            IMahuaEventItemTemplateGenerator mahuaEventItemTemplateGenerator,
            IMahuaApiCommandHandlerItemTemplateGernerator apiCommandHandlerItemTemplateGernerator)
        {
            _mahuaEventFinder = mahuaEventFinder;
            _mahuaApiCommandFinder = mahuaApiCommandFinder;
            _mahuaEventDesciptorResolver = mahuaEventDesciptorResolver;
            _mahuaApiCommandDesciptorResolver = mahuaApiCommandDesciptorResolver;
            _mahuaEventItemTemplateGenerator = mahuaEventItemTemplateGenerator;
            _apiCommandHandlerItemTemplateGernerator = apiCommandHandlerItemTemplateGernerator;
        }

        public void Generate()
        {
            var allApi = _mahuaApiCommandFinder.FindAll();
            var apiCommandDesciptors = allApi
                .Select(x => _mahuaApiCommandDesciptorResolver.Resolve(x))
                .ToArray();
            Console.WriteLine($"共找到{apiCommandDesciptors.Length}个ApiCommand");
            foreach (var apiCommandDesciptor in apiCommandDesciptors)
            {
                var fileName = _apiCommandHandlerItemTemplateGernerator.Generate(apiCommandDesciptor);
                Console.WriteLine($"成功生成项模板{apiCommandDesciptor.Summary}:{fileName}");
            }

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
