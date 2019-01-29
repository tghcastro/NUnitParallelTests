using NUnit.Framework;
using Project1;

namespace NonParallelTests
{
    [TestFixture]
    public class UnitTest1
    {
        [SetUp]
        public void SetUp()
        {
            TestHelper.print("Test setup");
        }


        [Test]
        public void TestMethod11()
        {
            TestHelper.executeDummyTestCode(TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void TestMethod12()
        {
            TestHelper.executeDummyTestCode(TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void TestMethod13()
        {
            TestHelper.executeDummyTestCode(TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void TestMethod14()
        {
            TestHelper.executeDummyTestCode(TestContext.CurrentContext.Test.Name);
        }
    }
}
