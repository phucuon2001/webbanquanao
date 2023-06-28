using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webbanhangnhom8.Appcode
{
    public class khohang
    {
        private string mahang;
        private string tenhang;
        private string ncc;
        private int soluong;
        private int dongianhap;
        private int dongiaban;
        private string chitiet;
        private string hinhanh;

        public string Mahang { get => mahang; set => mahang = value; }
        public string Tenhang { get => tenhang; set => tenhang = value; }
        public string Ncc { get => ncc; set => ncc = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Dongianhap { get => dongianhap; set => dongianhap = value; }
        public int Dongiaban { get => dongiaban; set => dongiaban = value; }
        public string Chitiet { get => chitiet; set => chitiet = value; }
        public string Hinhanh { get => hinhanh; set => hinhanh = value; }
        public khohang(string mahang, string tenhang, string ncc, int soluong, int dongianhap, int dongiaban, string chitiet, string hinhanh)
        {
            Mahang = mahang;
            Tenhang = tenhang;
            Ncc = ncc;
            Soluong = soluong;
            Dongianhap = dongianhap;
            Dongiaban = dongiaban;
            Chitiet = chitiet;
            Hinhanh = hinhanh;
        }
    }
}