using MongoDB.Driver;
using MongoDB.Bson;

namespace iotapi
{
    public class DeviceToken : MongoConnection
    {
        public ObjectId Id { get; set; }
        public string DeviceId { get; set; }
        public string Token { get; set; }
        public string Email { get; set; }

        public static DeviceToken GetToken(string token)
        {
            var TokensCollection = GetDatabase().GetCollection<DeviceToken>("tokens");

            return TokensCollection.Find(x => x.Token == token).FirstOrDefault();
        }
    }
}
