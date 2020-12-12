using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HighestPower.Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        [DataRow(90, 81, 2)]
        [DataRow(6, 4, 1)]
        [DataRow(65, 64, 3)]
        [DataRow(3, 1, -1)]
        [DataRow(1, 0, -1)]
        [DataRow(81, 64, 3)]
        [DataRow(29, 27, 1)]
        [DataRow(4, 1, -1)]
        public void CalculateTest(int def, int expected1 , int expected2)
        {
            
            Tuple<int, int> actual = HighestPowerOccurrences.Calculate(def);

            Assert.AreEqual(new Tuple<int, int>(expected1, expected2), actual);
        }
    }
}
