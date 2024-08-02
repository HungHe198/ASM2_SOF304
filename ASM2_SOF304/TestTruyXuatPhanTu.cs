using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2_SOF304
{
    public class TestTruyXuatPhanTu
    {
        [Test]
        [TestCase(new double[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 0, 0)]
        [TestCase(new double[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 1, 1)]
        [TestCase(new double[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 2, 2)]
        [TestCase(new double[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 3, 3)]
        [TestCase(new double[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 4, 4)]
        [TestCase(new double[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 5, 5)]
        [TestCase(new double[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 6, 6)]
        [TestCase(new double[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 7, 7)]
        [TestCase(new double[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 8, 8)]
        [TestCase(new double[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 9, 8)]
        [TestCase(new double[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9.9 }, 9, 9.9)]
        [TestCase(new double[] { }, -1, -1)]
        public void Test_TruyXuatPhanTu(double[] doubles, int index, double ER)
        {
            if (doubles == null || doubles.Count() == 0)
            {
                Assert.Fail("Không được để mảng rỗng");
            }

            else
            {
                    Assert.That(doubles[index] == ER, "Kết quả đưa ra không hợp lí");
            }
        }
      

    }
}
