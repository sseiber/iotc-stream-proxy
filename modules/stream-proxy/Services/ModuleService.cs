using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace stream_proxy.Services
{
    public class ModuleService : IModuleService
    {
        private readonly ILogger<ModuleService> logger;

        public ModuleService(ILogger<ModuleService> logger)
        {
            this.logger = logger;
        }

        public async Task<string> test()
        {
            this.logger.LogInformation("test");

            await Task.Delay(500);

            return "hello module service";
        }
    }
}
