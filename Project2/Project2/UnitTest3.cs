﻿using NUnit.Framework;
using Project1;

namespace ParallelTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class UnitTest3
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
        public void TestMethod21()
        {
            TestHelper.executeDummyTestCode(TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void TestMethod22()
        {
            TestHelper.executeDummyTestCode(TestContext.CurrentContext.Test.Name);
        }
        [Test]
        public void TestMethod23()
        {
            TestHelper.executeDummyTestCode(TestContext.CurrentContext.Test.Name);
        }
        [Test]
        public void TestMethod24()
        {
            TestHelper.executeDummyTestCode(TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void TestMethod25()
        {
            TestHelper.executeDummyTestCode(TestContext.CurrentContext.Test.Name);
        }
        [Test]
        public void TestMethod26()
        {
            TestHelper.executeDummyTestCode(TestContext.CurrentContext.Test.Name);
        }
        [Test]
        public void TestMethod27()
        {
            TestHelper.executeDummyTestCode(TestContext.CurrentContext.Test.Name);
        }
        [Test]
        public void TestMethod28()
        {
            TestHelper.executeDummyTestCode(TestContext.CurrentContext.Test.Name);
        }
        [Test]
        public void TestMethod29()
        {
            TestHelper.executeDummyTestCode(TestContext.CurrentContext.Test.Name);
        }
        [Test]
        public void TestMethod30()
        {
            TestHelper.executeDummyTestCode(TestContext.CurrentContext.Test.Name);
        }
    }
}
