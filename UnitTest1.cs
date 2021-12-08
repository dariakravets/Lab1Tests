using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyExcel;

namespace MyExcelTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSum()
        {
            double value1 = 5.5;
            double value2 = 6;
            double expected = 11.5;

            MyExcel.Parser parser = new Parser();
            double actual = parser.Evaluate((value1.ToString() + "+" + value2.ToString()), new Cell());

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPower()
        {
            double value1 = 5;
            double value2 = 2;
            double expected = 25;

            MyExcel.Parser parser = new Parser();
            double actual = parser.Evaluate((value1.ToString() + "^" + value2.ToString()), new Cell());

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEquals()
        {
            double value1 = 1;
            double value2 = 3;
            double expected = 0;

            MyExcel.Parser parser = new Parser();
            double actual = parser.Evaluate((value1.ToString() + "=" + value2.ToString()), new Cell());

            Assert.AreEqual(expected, actual);
        }
    }
}