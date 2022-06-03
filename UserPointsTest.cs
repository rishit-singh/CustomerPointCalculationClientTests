using System;

using System.Text.Json;
using System.Net.Http;

using Newtonsoft.Json;

namespace CustomerPointCalculation.Tests
{
    public class UserPointsTest : ITest
    {
        public void Run()
        {
            HttpClient client = new HttpClient();

            Response<UserPoints> response = null;

            string APIStatusJson = null;

            try
            {
                Console.WriteLine(APIStatusJson = client.GetStringAsync($"{TestTools.ApiURL}/GetPoints/{TestTools.GetRandomUserID()}").Result); // GET request to the default end point.

                response = JsonConvert.DeserializeObject<Response<UserPoints>>(APIStatusJson = client.GetStringAsync($"{TestTools.ApiURL}/GetPoints/{TestTools.GetRandomUserID()}").Result); // GET request to the default end point.

                Console.WriteLine(response.Payload.GetJsonString());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
        }
    }
}
