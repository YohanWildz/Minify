using System.Collections.Generic;
using Minify.Interfaces;
using Minify.Model;
using MongoDB.Driver;

namespace Minify{
    public class MongoRepository : IRepository
    {
        private IMongoCollection<MinifyData> database;
        public MongoRepository(){
            var client = new MongoClient(
                "mongodb+srv://EpsiEleve:TvxreYSXYCg89lz1@cluster0-b8srw.azure.mongodb.net/test?retryWrites=true&w=majority"
                            );
            database = client.GetDatabase("Epsi").GetCollection<MinifyData>("YohanWidogue");
        }

        public void Add(MinifyData minifyData)
        {
            database.InsertOne(minifyData);
        }

        public void Delete(string key)
        {
            var filter = Builders<MinifyData>.Filter.Eq("Key", key);
            database.DeleteOne(filter);
        }

        public IEnumerable<MinifyData> Get()
        {
            return database.AsQueryable().ToList();
        }

        public MinifyData Get(string key)
        {
            var filter = Builders<MinifyData>.Filter.Eq("Key", key);
            return database.Find(filter).FirstOrDefault();
        }
    }
}