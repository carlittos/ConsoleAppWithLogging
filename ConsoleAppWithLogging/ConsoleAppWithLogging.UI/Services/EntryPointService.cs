using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWithLogging.UI.Services
{
    public class EntryPointService
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<EntryPointService> _logger;

        public EntryPointService(IConfiguration configuration, ILogger<EntryPointService> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public async Task Run()
        {
            _logger.LogInformation("Process started at {Time}", DateTimeOffset.Now);
            await Task.Delay(1000);
            _logger.LogInformation("Process stopped at {Time}", DateTimeOffset.Now);
        }
    }
}
