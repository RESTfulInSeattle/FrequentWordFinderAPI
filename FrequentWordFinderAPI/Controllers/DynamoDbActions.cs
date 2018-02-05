using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;

namespace FrequentWordFinderAPI.Controllers
{
    public class DynamoDbActions
    {
        public string RetrieveItem(string url)
        {
            try
            {
                var client = new AmazonDynamoDBClient();
                var context = new DynamoDBContext(client);
                var item = context.Load<DynamoDBItem>(url, "result");

                return item.result;
            }
            catch (AmazonDynamoDBException e)
            {
                return "";
            }
        }

        public bool AddItem(string url, string result)
        {
            try
            {
                var client = new AmazonDynamoDBClient();
                var context = new DynamoDBContext(client);
                var item = new DynamoDBItem
                {
                    Id = url,
                    result = "Fish"
                };

                context.Save(item);
            }
            catch (AmazonDynamoDBException e)
            {
                return false;
            }

            return true;


        }
    }
}