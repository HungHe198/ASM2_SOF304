using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2_SOF304
{
    public class TestAverage
    {

        [Test]
        [TestCase(new double[] { 1, 2, 3, 4, 5 }, 3)]
        [TestCase(new double[] { 5, 10, 15, 20, 25 }, 15)]
        [TestCase(new double[] { -1, -2, -3, -4, -5 }, -3)]
        [TestCase(new double[] { 100, 200, 300 }, 200)]
        [TestCase(new double[] { 1.2, 3.4, 5.6, 7.8 }, 4.5)]
        [TestCase(new double[] { 0.1, 0.2, 0.3 }, 0.2)]
        [TestCase(new double[] { 2, 4, 6, 8 }, 5)]
        [TestCase(new double[] { -10, 0, 10, 20 }, 5)]
        [TestCase(new double[] { 7.5, 8.5, 9.5 }, 8.5)]
        [TestCase(new double[] { 1, 2, 3, 4 }, 2.5)]
        [TestCase(new double[] { 0, 100, 200 }, 100)]
        [TestCase(new double[] { }, null)]

        public void Test_Average(double[] Numbers, dynamic ER)
        {
            //Assert.AreEqual(Average(Numbers.ToList()), ER,0.000001); 

            if (Numbers.Count() == 0 || Numbers == null)
            {
                Assert.Fail("Danh sách không chứa phần tử nào.");
            }
            else
            {
                Assert.AreEqual(ER, Average(Numbers.ToList()),0.0000001);
            }
        }

        public double Average(List<double> Numbers)
        {

            if (Numbers.Count() == 0 || Numbers == null)

            {
                throw new InvalidOperationException("Danh sách không chứa phần tử nào.");
            }
            return Numbers.Average();
        }

    }
}
