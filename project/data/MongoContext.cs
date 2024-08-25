using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using project.Models;

namespace project.Data
{
    public class MongoContext
    {
        private readonly IMongoDatabase _database;

        public MongoContext(IConfiguration config)
        {
            var connectionString = config["MongoDB:ConnectionString"];
            var databaseName = config["MongoDB:DatabaseName"];

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException(nameof(connectionString), "Connection string cannot be null or empty.");
            }

            if (string.IsNullOrEmpty(databaseName))
            {
                throw new ArgumentNullException(nameof(databaseName), "Database name cannot be null or empty.");
            }

            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);
        }

        public IMongoCollection<User> Users
        {
            get
            {
                return _database.GetCollection<User>("Users");
            }
        }
    }
}
