using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ASM2_SOF304.TestCRUD
{
    public class SinhVienPoly
    {
        List<SinhVien> _lstSinhVienPoly = new List<SinhVien>();
        public bool CheckExit(string Id)
        {
            var CheckSinhVien = _lstSinhVienPoly.FirstOrDefault(x => x.Id == Id);
            if (CheckSinhVien != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool CheckTenLop(string tenLop)
        {
            if (string.IsNullOrEmpty(tenLop))
            {
                return false; 
            }

           
            string specialCharacters = @"!@#$%^&*()_+-=[]{}|;':"",.<>?/`~";
  
            foreach (char c in tenLop)
            {
                if (specialCharacters.Contains(c))
                {
                    return false; 
                }
            }

            return true;
        }

        public bool AddList(SinhVien sinhVien)
        {
            if (sinhVien == null)
            {
                return false;
            }


            else
            {
                _lstSinhVienPoly.Add(sinhVien);
                return true;
            }



        }
        public SinhVien FindByMaSV(string maSV)
        {
            return _lstSinhVienPoly.FirstOrDefault(x=>x.MaSV == maSV);
        }

    }
}
