using System;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace LiteArch.Lab.Apps.Api
{
    public class SeedService : ISeedService
    {
        private readonly IConnectionMultiplexer _connectionMultiplexer;
        private readonly IDatabase _database;

        public SeedService(IConnectionMultiplexer connectionMultiplexer)
        {
            _connectionMultiplexer = connectionMultiplexer;
            _database = _connectionMultiplexer.GetDatabase();
        }
        public async Task Seed(string key)
        {
            Console.WriteLine($"Seeding: {Environment.MachineName} --> {_database.StringGet(key)}");
            _database.StringIncrement(key);
        }
    }
}