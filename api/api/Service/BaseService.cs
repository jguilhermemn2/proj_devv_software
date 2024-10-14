namespace api.Service
{
    using MongoDB.Driver;
    using MongoDB.Bson;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using api.Model;
    using api.Controllers;

    public class BaseService<T> where T : TEntity
    {
        private readonly IMongoCollection<T> _sCollection;
        private MongoClient _client;
        private readonly IMongoDatabase _database;

        public BaseService(string collectionName)
        {
            _client = new MongoClient("mongodb://admin:123@mongo_container:27017");
           // _client = new MongoClient("mongodb://admin:123@localhost:27017");
            _database = _client.GetDatabase("UserDatabase");
            _sCollection = _database.GetCollection<T>(collectionName);
        }


        public void Create(T obj)
        {
            _sCollection.InsertOne(obj);
        }

        public async Task<List<T>> GetsAsync()
        {
            return await _sCollection.Find<T>(new BsonDocument()).ToListAsync();
        }


        public async Task<T> GetByIdAsync(Guid id)
        {
            var filter = Builders<T>.Filter.Eq(u => u.Id, id);
            return await _sCollection.Find(filter).FirstOrDefaultAsync();
        }


        public void Update(Guid id, T obj)
        {
            var filter = Builders<T>.Filter.Eq(u => u.Id, id);
            _sCollection.ReplaceOne(filter, obj);
        }


        public async Task DeleteAsync(Guid id)
        {
            var filter = Builders<T>.Filter.Eq(u => u.Id, id);
            await _sCollection.DeleteOneAsync(filter);
        }

        internal List<T> GetAll()
        {
            return _sCollection.Find<T>(_ => true).ToList();
        }
    }
}
