namespace ASM2_SOF304
{
    public class TestHieuHaiSoNguyen
    {
        [Test]

        [TestCase(10, 5, 5)]        
        [TestCase(3, 2, 1)]         
        [TestCase(0, 0, 0)]         
        [TestCase(100, 50, 50)]     
        [TestCase(-5, -3, -2)]      
        [TestCase(10.5, 5.5, 5)]    
        [TestCase(4.2, 2.1, 2.1)]   
        [TestCase(7, 3, 4.5)]       
        [TestCase(15, 10, 6)]       
        [TestCase(-2, -2, 0)]
        public void TestHieuHaiSo(double a, double b, double ER)
        {
            
            Assert.Multiple(() =>
            {
                Assert.That(HieuHaiSo(a,b) == ER, "Kết quả có sai lệch");
                Assert.That(IsInt(a) == true, "a không phải số nguyên");
                Assert.That(IsInt(b) == true, "b không phải số nguyên");
            });
        }
        public double HieuHaiSo(double a, double b)
        {

            return a - b;
        }
        public bool IsInt(double a)
        {
            return a % 1 == 0;
        }
    }
}
