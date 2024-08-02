using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2_SOF304.TestCRUD
{
    public class TestCreate
    {
        [SetUp]
        public void SetUp()
        {

        }
        SinhVienPoly _db = new SinhVienPoly();
        [Test]
        [TestCase("SV1", "Lê Văn Hùng", "L1", "Lớp 1", "PH45911")]
        [TestCase("SV02", "", "", "Lớp 1", "PH45911")]
        [TestCase("SV03", "", null, null, "PH45914")]
        [TestCase("SV04", "Nguyễn Thị Mai", "L2", "Lớp 2", "PH45912")]
        [TestCase("", "Trần Văn An", "L3", "", "PH45913")]
        [TestCase("SV06", "Phạm Thị Lan", "L4", "Lớp 4", "PH45915")]
        [TestCase("SV07", "Hoàng Văn Bình", "L5", "Lớp @# 5", "PH45916")]
        [TestCase("SV08", "Ngô Thị Thu", "", "Lớp 6", "PH45917")]
        [TestCase("SV09", "", "L7", "Lớp 7", "PH45918")]
        [TestCase("SV10", "Trần Thị Hà", null, null, "PH45919")]

        public void Test_Create(string Id, string hoTen, string maLop, string tenLop, string maSV)
        {
            Assert.Multiple(() =>
            {
                Assert.That(!string.IsNullOrEmpty(Id), "không được để trống ID");
                Assert.That(!string.IsNullOrEmpty(hoTen), "không được để trống Họ tên");
                Assert.That(!string.IsNullOrEmpty(maLop), "không được để trống Mã lớp");
                Assert.That(!string.IsNullOrEmpty(tenLop), "không được để trống Tên lớp");
                Assert.That(!string.IsNullOrEmpty(maSV), "không được để trống Mã sinh viên");
                Assert.That(_db.CheckExit(Id), "Mã sinh viên trùng");
                Assert.That(_db.CheckTenLop(tenLop) != false, "Tên lớp không được chứa kí tự đặc biệt");

            }
            );



            SinhVien sinhVien = new SinhVien()
            {
                Id = Id,
                HoTen = hoTen,
                MaLop = maLop,
                TenLop = tenLop,
                MaSV = maSV
            };
            Assert.That(_db.AddList(sinhVien), "Không thể thêm đối tượng");






        }

    }
}
