

namespace ASM2_SOF304
{
    public class TestTichHaiSoNguyen
    {
        [Test]
        [TestCase(1, 2, 2)]
        [TestCase(12, 2, 24)]
        [TestCase(1.1, 1.3, 1.43)]
        [TestCase(1.1, 1.3, 1)]
        [TestCase(12, 12, 144)]
        [TestCase(-2, 2.3, -4.6)]
        [TestCase(1, 12, 12)]
        [TestCase(1.32, 1, 1.32)]
        [TestCase(int.MinValue, 0, 0)]
        [TestCase(int.MaxValue,0, 0)]
        [TestCase(int.MaxValue, 1, int.MaxValue)]
        [TestCase(int.MinValue,1,int.MinValue)]
        public void TestTichHaiSo(double a, double b, double ER)
        {
            Assert.Multiple(() =>
            {
                Assert.That(TichHaiSo(a, b) == ER, "Kết quả Sai lệch");
                Assert.That(IsInt(a) == true, "a không phải số nguyên");
                Assert.That(IsInt(b) == true, "b không phải số nguyên");

            });
        }
        public double TichHaiSo(double a, double b)
        {
            return a * b;
        }
        public bool IsInt(double a)
        {
            return a % 1 == 0;
        }

    }
}
