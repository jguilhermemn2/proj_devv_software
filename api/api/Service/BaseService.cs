namespace api.Service
{
    using MongoDB.Driver;
    using MongoDB.Bson;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using api.Model;

    public class BaseService<T> where T : TEntity
    {
        private readonly IMongoCollection<T> _sCollection;

        public BaseService(string collectionName)
        {
            var client = new MongoClient("mongodb://admin:123@localhost:27017");  
            var database = client.GetDatabase("UserDatabase"); 
            _sCollection = database.GetCollection<T>(collectionName); 
        }

       
        public async Task CreateAsync(T obj)
        {
            await _sCollection.InsertOneAsync(obj); 
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

      
        public async Task UpdateAsync(Guid id, T obj)
        {
            var filter = Builders<T>.Filter.Eq(u => u.Id, id);
            await _sCollection.ReplaceOneAsync(filter, obj); 
        }

    
        public async Task DeleteAsync(Guid id)
        {
            var filter = Builders<T>.Filter.Eq(u => u.Id, id);
            await _sCollection.DeleteOneAsync(filter); 
        }
    }
}
