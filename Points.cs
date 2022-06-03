using System;
using System.Collections;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace CustomerPointCalculation.Tests
{
    public class UserPoints
    {
        public string UserID { get; set; }

        public Hashtable MonthlyPoints { get; set; }

        public int TotalPoints { get; set; }

        public string GetJsonString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
