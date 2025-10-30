using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShelomentsevYA.Sprint3.Task4.V6.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint3.Task4.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            double result = ds.Calculate(-5, 5);
            double expected = 8.995;
            Assert.AreEqual(expected, result);
        }
    }
}
