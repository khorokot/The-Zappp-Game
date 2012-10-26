using ZicZacZappp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    
    
    /// <summary>
    ///This is a test class for Bettle5Test and is intended
    ///to contain all Bettle5Test Unit Tests
    ///</summary>
    [TestClass()]
    public class Bettle5Test
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for CheckForWin
        ///</summary>
        [TestMethod()]
        public void CheckForWinTest()
        {
            string P1 = "P1"; // TODO: Initialize to an appropriate value
            string P2 = "P2"; // TODO: Initialize to an appropriate value
            int mode = 2; // TODO: Initialize to an appropriate value
            Bettle5 target = new Bettle5(P1, P2, mode); // TODO: Initialize to an appropriate value
            string[] array = { "x", "x", "x", "x", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" }; // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.CheckForWin(array);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void CheckForWinTest2()
        {
            string P1 = "P1"; // TODO: Initialize to an appropriate value
            string P2 = "P2"; // TODO: Initialize to an appropriate value
            int mode = 2; // TODO: Initialize to an appropriate value
            Bettle5 target = new Bettle5(P1, P2, mode); // TODO: Initialize to an appropriate value
            string[] array = { "x", "x", "o", "x", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" }; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.CheckForWin(array);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void CheckForWinTest3()
        {
            string P1 = "P1"; // TODO: Initialize to an appropriate value
            string P2 = "P2"; // TODO: Initialize to an appropriate value
            int mode = 2; // TODO: Initialize to an appropriate value
            Bettle5 target = new Bettle5(P1, P2, mode); // TODO: Initialize to an appropriate value
            string[] array = { "x", "x", "o", "x", "o", "o", "o", "o", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" }; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.CheckForWin(array);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void CheckForWinTest4()
        {
            string P1 = "P1"; // TODO: Initialize to an appropriate value
            string P2 = "P2"; // TODO: Initialize to an appropriate value
            int mode = 2; // TODO: Initialize to an appropriate value
            Bettle5 target = new Bettle5(P1, P2, mode); // TODO: Initialize to an appropriate value
            string[] array = { "x", "x", "o", "x", "o", "x", "x", "o", "0", "0", "x", "x", "0", "0", "0", "0", "x", "0", "0", "0", "0", "0", "0", "0", "0" }; // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.CheckForWin(array);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
