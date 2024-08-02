using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2_SOF304.TestCRUD
{
    public class TestTimTheoMaSV
    {
        SinhVienPoly _db = new SinhVienPoly();

        [SetUp]
        public void SetUp()
        {
            // Khởi tạo dữ liệu cho 10 đối tượng sinh viên


            _db.AddList(new SinhVien { Id = "SV01", HoTen = "Nguyễn Văn A", MaLop = "L1", TenLop = "Lớp 1", MaSV = "PH45910" });
            _db.AddList(new SinhVien { Id = "SV02", HoTen = "Trần Thị B", MaLop = "L2", TenLop = "Lớp 2", MaSV = "PH45911" });
            _db.AddList(new SinhVien { Id = "SV03", HoTen = "Lê Văn C", MaLop = "L3", TenLop = "Lớp 3", MaSV = "PH45912" });
            _db.AddList(new SinhVien { Id = "SV04", HoTen = "Phạm Thị D", MaLop = "L4", TenLop = "Lớp 4", MaSV = "PH45913" });
            _db.AddList(new SinhVien { Id = "SV05", HoTen = "Hoàng Văn E", MaLop = "L5", TenLop = "Lớp 5", MaSV = "PH45914" });
            _db.AddList(new SinhVien { Id = "SV06", HoTen = "Nguyễn Thị F", MaLop = "L6", TenLop = "Lớp 6", MaSV = "PH45915" });
            _db.AddList(new SinhVien { Id = "SV07", HoTen = "Trần Văn G", MaLop = "L7", TenLop = "Lớp 7", MaSV = "PH45916" });
            _db.AddList(new SinhVien { Id = "SV08", HoTen = "Lê Thị H", MaLop = "L8", TenLop = "Lớp 8", MaSV = "PH45917" });
            _db.AddList(new SinhVien { Id = "SV09", HoTen = "Phạm Văn I", MaLop = "L9", TenLop = "Lớp 9", MaSV = "PH45918" });
            _db.AddList(new SinhVien { Id = "SV10", HoTen = "Nguyễn Văn J", MaLop = "L10", TenLop = "Lớp 10", MaSV = "PH45919" });
        }
        [Test]
        [TestCase("PH45910", "SV01")]
        [TestCase("PH45911", "SV02")]
        [TestCase("PH45912", "SV03")]
        [TestCase("PH45913", "SV04")]
        [TestCase("PH45914", "SV05")]
        [TestCase("PH45915", "SV06")]
        [TestCase("PH45916", "SV07")]
        [TestCase("PH45917", "SV08")]
        [TestCase("PH45918", "SV09")]
        [TestCase("PH45919", "SV10")]
        [TestCase("PH11111", null)]
        [TestCase("", null)]
        [TestCase(null, null)]
        public void TestFindByMaSV(string maSV, string ER_ID)
        {
            //Assert.That(_db.FindByMaSV(maSV).Id == ER_ID, "Mã sinh viên bị sai lệch hoặc sinh viên không tồn tại");


            var sinhVien = _db.FindByMaSV(maSV);

            Assert.Multiple(() =>
            {
                if (string.IsNullOrEmpty(maSV))
                {
                    Assert.Fail("Không được để trống mã sinh viên");
                }
                else if (sinhVien == null)
                {
                    Assert.That(!string.IsNullOrEmpty(ER_ID), "Sinh viên không tồn tại");
                }
                else
                {
                    Assert.That(sinhVien.Id == ER_ID, "Mã sinh viên bị sai lệch.");
                }
            });
        }



    }
}
