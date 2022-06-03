using System;


using System.Text.Json;
using System.Net.Http;

namespace CustomerPointCalculation.Tests
{
    public class APIStatusTest : ITest
    {
        public void Run()
        {
            HttpClient client = new HttpClient();

            string response = null;

            string APIStatusJson = null;

            try
            {
                response = client.GetStringAsync(TestTools.ApiURL).Result; // GET request to the default end point.

                Console.WriteLine(response);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
        }
    }
}
