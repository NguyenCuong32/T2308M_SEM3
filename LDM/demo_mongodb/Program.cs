using Amazon.Runtime.Internal.Settings;
using MongoDB.Bson;
using MongoDB.Driver;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Connection to mongodb");
        string connection_string = "mongodb://root:123456@127.0.0.1:27017/";
        var client = new MongoClient(connection_string);
        var collection = client.GetDatabase("SystemInformationStudent").GetCollection<BsonDocument>("User");
        foreach (BsonDocument doc in collection.Aggregate<BsonDocument>().ToList())
        {
            System.Console.WriteLine(String.Format("{0} - {1}", "User name: ", doc["username"].ToString()));
            System.Console.WriteLine(String.Format("{0} - {1}", "Full name: ", doc["fullname"].ToString()));
        }
    }
}