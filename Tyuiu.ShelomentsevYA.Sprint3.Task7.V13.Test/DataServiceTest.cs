using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShelomentsevYA.Sprint3.Task7.V13.Lib;
using System;

namespace Tyuiu.ShelomentsevYA.Sprint3.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetMassFunction()
        {
            DataService ds = new DataService();

            double[] expected = ds.GetMassFunction(-5, 5);

            Assert.AreEqual(2, expected[5]); 
        }
    }
}
