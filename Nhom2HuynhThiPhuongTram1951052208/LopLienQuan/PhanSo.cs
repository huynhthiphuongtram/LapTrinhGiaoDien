using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom2HuynhThiPhuongTram1951052208.LopLienQuan
{
    class PhanSo
    {
        //Biến thành viên
        private int tuSo, mauSo;
        //Thuộc tính
        public int TuSo
        {
            get { return tuSo; }
            set { tuSo = value; }
        }
        public int MauSo
        {
            get { return mauSo; }
            set { mauSo = value; }
        }
        //Phương thức khởi tạo
        public PhanSo()
        {
            tuSo = 0;
            mauSo = 1;
        }
        public PhanSo(int tu, int mau)
        {
            tuSo = tu;
            mauSo = mau;
        }
        public PhanSo(PhanSo p)
        {
            tuSo = p.tuSo;
            mauSo = p.mauSo;
        }
        //Phương thức Thường
        public PhanSo Cong(PhanSo p2)
        {
            PhanSo ketQua = new PhanSo();
            ketQua.tuSo = tuSo * p2.mauSo + p2.tuSo * mauSo;
            ketQua.mauSo = mauSo * p2.mauSo;
            //chưa rút gọn
            ketQua.RutGon();
            return ketQua;
        }

        public PhanSo Tru(PhanSo p3)
        {
            PhanSo ketQua = new PhanSo();
            ketQua.tuSo = tuSo * p3.mauSo - p3.tuSo * mauSo;
            ketQua.mauSo = mauSo * p3.mauSo;
            //chưa rút gọn
            ketQua.RutGon();
            return ketQua;
        }

        public PhanSo Nhan(PhanSo p4)
        {
            PhanSo ketQua = new PhanSo();
            ketQua.tuSo = tuSo * p4.tuSo;
            ketQua.mauSo = mauSo * p4.mauSo;
            //chưa rút gọn
            ketQua.RutGon();
            return ketQua;
        }
        public PhanSo Chia(PhanSo p5)
        {
            PhanSo ketQua = new PhanSo();
            ketQua.tuSo = tuSo * p5.mauSo;
            ketQua.mauSo = mauSo * p5.tuSo;
            //chưa rút gọn
            ketQua.RutGon();
            return ketQua;
        }
        public void RutGon()
        {
            int us;
            //CacCongThucToanHoc tam = new CacCongThucToanHoc();
            //us = tam.UCLN(tuSo, mauSo);
            us = CacCongThucToanHoc.UCLN(tuSo, mauSo);
            tuSo = tuSo / us;
            mauSo = mauSo / us;
        }
        //1/2 - 3/4
    }
}
