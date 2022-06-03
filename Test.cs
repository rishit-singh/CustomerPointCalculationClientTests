using System;

namespace CustomerPointCalculation.Tests
{
    public interface ITest
    {
        void Run();
    }

    public class TestTools
    {
        public static string ApiURL = "http://localhost:5026";

        public static string[] UserIDs = new string[] {
           "efc0509e0aef7f2e5a2ad5dd46f3c2c6e4c237b58045df328dac9e937170408f",
           "ecec8027869cc30801cf8f8cf7c2e11c692dc2cd7cc9948327fe4d65818a714b",
           "282b7bcd8d65d31b62685fc8f903330b7fcef6b41c3a2d696f1f26c7cdf84019",
           "ffa4d7ec52c58f20da88aa17214c03af5c93f657a247f5ed1e3c5cf433b37117",
           "8d942a2867a52edce3205254aaadaa3fe3c668e1e128ed137570febcd6f7876a"
        };

        public static string GetRandomUserID()
        {
            Random rand = new Random();

            return TestTools.UserIDs[rand.Next(0, TestTools.UserIDs.Length)];
        }
    }
}
