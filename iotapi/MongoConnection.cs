using MongoDB.Driver;

namespace iotapi
{
    public class MongoConnection
    {
        protected static IMongoDatabase _database;

        public static IMongoDatabase GetDatabase()
        {
            // Cloud server for storage
            //MongoClient _client = new MongoClient("mongodb+srv://iotuser:KYm2GHCtQb4T5IQ8@iotcluster.hxcbh.mongodb.net/iotdatabase?retryWrites=true&w=majority");

            // Local docker container for storage
            MongoClient _client = new MongoClient("mongodb://iot:secret@localhost:27017/iotdatabase");

            _database = _client.GetDatabase("iotdatabase");
            return _database;
        }
    }
}
