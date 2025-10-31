using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShelomentsevYA.Sprint3.Task6.V12.Lib;
using System;

namespace Tyuiu.ShelomentsevYA.Sprint3.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetSumTheDivisors()
        {
            DataService ds = new DataService();

            
            int result = ds.GetSumTheDivisors(9, 18);

            int expected = 221;
            Assert.AreEqual(expected, result);
        }
    }
}
