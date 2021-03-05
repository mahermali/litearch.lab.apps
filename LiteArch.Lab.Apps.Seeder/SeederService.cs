using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace LiteArch.Lab.Apps.Seeder
{
    public class SeederService:IHostedService
    {
        private readonly IConfiguration _configuration;
        private static int _lastId = 0;
        private Random _random = new Random(Environment.TickCount);

        public SeederService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task StartAsync(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                Console.WriteLine($"Seeding: {++_lastId}");
                await Task.Delay(_random.Next(500, 3000), cancellationToken);
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}