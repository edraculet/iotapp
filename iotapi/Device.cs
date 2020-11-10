using System;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace iotapi
{
    public class Device : MongoConnection
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public bool Locked { get; set; }

        public static Device GetDevice(DeviceToken deviceToken)
        {
            IMongoCollection<Device> DevicesCollection = GetDatabase().GetCollection<Device>("devices");

            return DevicesCollection.Find(d => d.Id == deviceToken.DeviceId).FirstOrDefault();
        }

        public static Device ChangeLock(Device device)
        {
            IMongoCollection<Device> DevicesCollection = GetDatabase().GetCollection<Device>("devices");
            var filter = Builders<Device>.Filter.Eq(s => s.Id, device.Id);
            var result = DevicesCollection.ReplaceOneAsync(filter, device);

            // log action into logs collection
            IMongoCollection<Log> LogsCollection = GetDatabase().GetCollection<Log>("logs");
            
            LogsCollection.InsertOneAsync(
                new Log {
                    Date = DateTime.Now,
                    Locked = device.Locked,
                    DeviceID = device.Id
                });
            return device;
        }
    }
}