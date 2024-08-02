namespace ASM2_SOF304
{
    public class TestTongHaiSoNguyen
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1, 2, 3)]
        [TestCase(1, 2.4, 3.4)]
        [TestCase(int.MaxValue, int.MinValue, -1)]
        [TestCase(11, 10, 21)]
        [TestCase(int.MinValue, int.MaxValue, -1)]
        [TestCase(1.2, 1.3, 1.5)]
        [TestCase(1.2, 2, 3.2)]
        [TestCase(19.8, 31.7, 51.5)]
        [TestCase(19, 31, 50)]
        [TestCase(7, 8, 15)]
        public void TestTongHaiSo(double a, double b, double ER)
        {

            Assert.Multiple(() =>
            {
                Assert.That(TongHaiSo(a, b) == ER, "Kết quả có sai lệch");
                Assert.That(IsInt(a) == true, "a không phải số nguyên");
                Assert.That(IsInt(b) == true, "b không phải số nguyên");

            });

            //Assert.Pass();
        }

        public double TongHaiSo(double a, double b)
        {
            return a + b;

        }
        public bool IsInt(double a)
        {
            return a % 1 == 0;
        }

    }
}