using Amazon.DynamoDBv2.DataModel;

namespace FrequentWordFinderAPI.Controllers
{
    [DynamoDBTable("WordRankerTable")]

    public class DynamoDBItem
    {
        [DynamoDBHashKey]
        public string Id { get; set; }
        [DynamoDBRangeKey]
        public string result { get; set; }
    }
}