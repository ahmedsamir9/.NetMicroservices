using Catlog.Api.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Catlog.Api.Data
{

    public class CatlogContext : ICatlogContext
    {
        private static IMongoDatabase _database { get; set; }

        public IMongoCollection<Product> Products { get; }
        private readonly IConfiguration _configuration;
        public CatlogContext(IConfiguration configuration) {
            _configuration = configuration;
        var client = new MongoClient(_configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
        _database = client.GetDatabase(_configuration.GetValue<string>("DatabaseSettings:DatabaseName"));
            Products = _database.GetCollection<Product>(configuration.GetValue<string>("DatabaseSettings:CollectionName"));
            CatalogContextSeed.SeedData(Products);
        }
   
    }
}
