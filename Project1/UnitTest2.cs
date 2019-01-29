using NUnit.Framework;
using Project1;

namespace ParallelTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    public class UnitTest2
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

        [Test]
        public void TestMethod15()
        {
            TestHelper.executeDummyTestCode(TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void TestMethod16()
        {
            TestHelper.executeDummyTestCode(TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void TestMethod17()
        {
            TestHelper.executeDummyTestCode(TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void TestMethod18()
        {
            TestHelper.executeDummyTestCode(TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void TestMethod19()
        {
            TestHelper.executeDummyTestCode(TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void TestMethod20()
        {
            TestHelper.executeDummyTestCode(TestContext.CurrentContext.Test.Name);
        }

        [Test]
        [NonParallelizable]
        public void NotParallel()
        {
            TestHelper.executeDummyTestCode(TestContext.CurrentContext.Test.Name);
        }
    }
}
