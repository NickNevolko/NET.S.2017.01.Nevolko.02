using System;
using static Tasks3.Task2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTasks2
{
    [TestClass]
    public class TasksTest
    {
            public TestContext TestContext { get; set; }

        [DataSource(
        "Microsoft.VisualStudio.TestTools.DataSource.XML",
        "|DataDirectory|\\Numbers.xml",
        "TestCase",
        DataAccessMethod.Sequential)]
        [DeploymentItem("DDT.UnitTestTasks2\\Numbers.xml")]
        [TestMethod]
        public void InserIntToInt_TestMethod()
        {

            var expected = Convert.ToString(TestContext.DataRow["ExpectedResult"]);

            var actual = Convert.ToString(InsertIntToInt(
                Convert.ToInt32(TestContext.DataRow["number1"]),
                Convert.ToInt32(TestContext.DataRow["number2"]),
                Convert.ToByte(TestContext.DataRow["i"]),
                Convert.ToByte(TestContext.DataRow["j"])));

            Assert.AreEqual(expected, actual);
        }
    }
}