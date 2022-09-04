using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom2HuynhThiPhuongTram1951052208.LopLienQuan;

namespace Nhom2HuynhThiPhuongTram1951052208
{
    public partial class Câu10 : Form
    {
        public Câu10()
        {
            InitializeComponent();
        }

        //Khai báo biến toàn cục
        PhanSo p1, p2, p3, p4, p5, ketQua;
        private void btCong_Click(object sender, EventArgs e)
        {
            //đưa dấu toán tử trong button lên form tính toán
            if (txtToanTu.Text != "")
            {
                txtToanTu.Text = txtToanTu.Text.Substring(0, txtToanTu.Text.Length - 1);
            }
            txtToanTu.Text += "+";

            int tu, mau;

            p1 = new PhanSo(); //Tạo đối tượng cách 1
            p1.TuSo = int.Parse(txtTuso1.Text);
            p1.MauSo = int.Parse(txtMauso1.Text);

            tu = int.Parse(txtTuso2.Text);
            mau = int.Parse(txtMauso2.Text);

            p2 = new PhanSo(tu, mau); //Tạo đối tượng cách 2
            ketQua = p1.Cong(p2);

            txtTuso3.Text = ketQua.TuSo.ToString();
            txtMauso3.Text = ketQua.MauSo.ToString();
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            //đưa dấu toán tử trong button lên form tính toán
            if (txtToanTu.Text != "")
            {
                txtToanTu.Text = txtToanTu.Text.Substring(0, txtToanTu.Text.Length - 1);
            }
            txtToanTu.Text += "-";

            int tu, mau;

            p1 = new PhanSo(); //Tạo đối tượng cách 1
            p1.TuSo = int.Parse(txtTuso1.Text);
            p1.MauSo = int.Parse(txtMauso1.Text);

            tu = int.Parse(txtTuso2.Text);
            mau = int.Parse(txtMauso2.Text);

            p3 = new PhanSo(tu, mau); //Tạo đối tượng cách 2
            ketQua = p1.Tru(p3);

            txtTuso3.Text = ketQua.TuSo.ToString();
            txtMauso3.Text = ketQua.MauSo.ToString();
        }
        private void btNhan_Click(object sender, EventArgs e)
        {
            //đưa dấu toán tử trong button lên form tính toán
            if (txtToanTu.Text != "")
            {
                txtToanTu.Text = txtToanTu.Text.Substring(0, txtToanTu.Text.Length - 1);
            }
            txtToanTu.Text += "*";

            int tu, mau;

            p1 = new PhanSo(); //Tạo đối tượng cách 1
            p1.TuSo = int.Parse(txtTuso1.Text);
            p1.MauSo = int.Parse(txtMauso1.Text);

            tu = int.Parse(txtTuso2.Text);
            mau = int.Parse(txtMauso2.Text);

            p4 = new PhanSo(tu, mau); //Tạo đối tượng cách 2
            ketQua = p1.Nhan(p4);

            txtTuso3.Text = ketQua.TuSo.ToString();
            txtMauso3.Text = ketQua.MauSo.ToString();
        }
        private void btChia_Click(object sender, EventArgs e)
        {
            //đưa dấu toán tử trong button lên form tính toán
            if (txtToanTu.Text != "")
            {
                txtToanTu.Text = txtToanTu.Text.Substring(0, txtToanTu.Text.Length - 1);
            }
            txtToanTu.Text += "/";

            int tu, mau;

            p1 = new PhanSo(); //Tạo đối tượng cách 1
            p1.TuSo = int.Parse(txtTuso1.Text);
            p1.MauSo = int.Parse(txtMauso1.Text);

            tu = int.Parse(txtTuso2.Text);
            mau = int.Parse(txtMauso2.Text);

            p5 = new PhanSo(tu, mau); //Tạo đối tượng cách 2
            ketQua = p1.Chia(p5);

            txtTuso3.Text = ketQua.TuSo.ToString();
            txtMauso3.Text = ketQua.MauSo.ToString();
        }
    }
}
