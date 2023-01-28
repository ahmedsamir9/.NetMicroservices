using Catlog.Api.Entities;
using MongoDB.Driver;

namespace Catlog.Api.Data
{
    public interface ICatlogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
