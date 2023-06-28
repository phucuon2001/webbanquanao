using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webbanhangnhom8.Appcode
{
    public class dstaikhoan
    {
        private string taikhoan;
        private string matkhau;
        private string fullname;
        private string gioitinh;
        private string quyen;

        public string Taikhoan { get => taikhoan; set => taikhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Quyen { get => quyen; set => quyen = value; }
        public dstaikhoan(string taikhoan, string matkhau, string fullname, string gioitinh, string quyen)
        {
            Taikhoan = taikhoan;
            Matkhau = matkhau;
            Fullname = fullname;
            Gioitinh = gioitinh;
            Quyen = quyen;
        }
    }
}