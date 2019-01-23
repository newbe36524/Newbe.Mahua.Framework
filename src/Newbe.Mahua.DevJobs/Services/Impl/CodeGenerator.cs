using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Newbe.Mahua.NativeApiClassfy.Services.Impl
{
    internal class CodeGenerator : ICodeGenerator
    {
        private readonly IEnumerable<IJob> _jobs;

        public CodeGenerator(
            IEnumerable<IJob> jobs)
        {
            _jobs = jobs;
        }

        public Task Generate()
        {
            return Task.WhenAll(_jobs.Select(RunCore));

            async Task RunCore(IJob job)
            {
                var type = job.GetType();
                Console.WriteLine($"start {type.FullName}");
                await job.Run();
                Console.WriteLine($"finished {type.FullName}");
            }
        }
    }
}