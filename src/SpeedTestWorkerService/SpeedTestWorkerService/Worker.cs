using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SpeedTest;
using SpeedTest.Models;

namespace SpeedTestWorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                
                SpeedTestClient speedTestClient = new SpeedTestClient();
                Settings settings = speedTestClient.GetSettings();
                Server bestServer = settings.Servers[0];
                _logger.LogInformation("Server name: " + bestServer.Name);
                double downloadSpeed = speedTestClient.TestDownloadSpeed(bestServer);
                _logger.LogInformation("Download speed (kbps): " + downloadSpeed);
                await Task.Delay(60000, stoppingToken);
            }
        }
    }
}