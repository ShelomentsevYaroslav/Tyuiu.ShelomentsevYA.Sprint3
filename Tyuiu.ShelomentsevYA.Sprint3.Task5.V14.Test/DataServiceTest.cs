using System;
using Tyuiu.ShelomentsevYA.Sprint3.Task5.V14.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint3.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 5;
            double result = ds.GetSumSumSeries(x, 1, 1, 3, 14);
            double expected = -31.275; 
            Assert.AreEqual(expected, result);
        }
    }
}
