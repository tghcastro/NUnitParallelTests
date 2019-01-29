using NUnit.Framework;
using System;

namespace Project1
{
    public class TestHelper
    {
        public static void print(string text)
        {
            TestContext.Out.WriteLine(DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + " " + text);
        }

        public static void executeDummyTestCode(string testName)
        {
            TestHelper.print($"Running test {testName}");
            System.Threading.Thread.Sleep(1000);
        }
    }
}