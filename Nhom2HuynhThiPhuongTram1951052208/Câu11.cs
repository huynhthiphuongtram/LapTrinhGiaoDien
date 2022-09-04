using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom2HuynhThiPhuongTram1951052208
{
    public partial class Câu11 : Form
    {
        public Câu11()
        {
            InitializeComponent();
        }
        //1. Các số trong phép toán và dấu phép toán sẽ được sinh ra ngẫu nhiên
        Random rand;
        int so1, so2, so3, so4;
        int viTri;

        private void Câu11_Load(object sender, EventArgs e)
        {
            KhoiTao();
        }

        string[] toanTu = { " + ", " - ", " * ", " / " }; //Mảng giá trị toán tử
        private void KhoiTao()
        {
            Random rand;
            rand = new Random();
            so1 = rand.Next(0, 9);
            so2 = rand.Next(0, 9);
            so3 = rand.Next(0, 9);
            so4 = rand.Next(0, 9);

            lbTuSo1.Text = so1.ToString();
            lbMauSo1.Text = so2.ToString();
            lbTuSo2.Text = so3.ToString();
            lbMauSo2.Text = so4.ToString();
            lbPhepToan.Text = toanTu[viTri];
        }
        //2. Người dùng nhập vào kết quả và kết quả sẽ được kiểm tra đúng hay sai
        private void Check()
        {
            double ketQuaTS = 0;
            double ketQuaMS = 0;
            double tamTS = 0;
            double tamMS = 0;
            string KQTS, KQMS = " ";
            switch (viTri)
            {
                case 0:
                    ketQuaTS = so1 * so4 + so3 * so2;
                    ketQuaMS = so2 * so4;
                    break;
                case 1:
                    ketQuaTS = so1 * so4 - so3 * so2;
                    ketQuaMS = so2 * so4;
                    break;
                case 2:
                    ketQuaTS = so1 * so3;
                    ketQuaMS = so2 * so4;
                    break;
                case 3:
                    ketQuaTS = so1 * so2 + so3 * so4;
                    ketQuaMS = so2 * so3;
                    break;
            }
            KQTS = String.Format("{0:0.00}", ketQuaTS);
            KQMS = String.Format("{0:0.00}", ketQuaMS);
            tamTS = double.Parse(txtKQTuSo.Text);
            tamMS = double.Parse(txtKQMauSo.Text);
            txtKQTuSo.Text = String.Format("{0:0.00}", tamTS);
            txtKQMauSo.Text = String.Format("{0:0.00}", tamMS);

            if(txtKQTuSo.Text == KQTS && txtKQMauSo.Text == KQMS)
            {
                lbDungSai.Text = "ĐÚNG ĐÁP ÁN!";
                //3. Đúng thì +1 điểm
                int total = 0; 
                int Bonus = total + 1;
                lbBonus.Text = "+" + Bonus.ToString();
            }
            else
            {
                lbDungSai.Text = "SAI ĐÁP ÁN! KẾT QUẢ LÀ: " + KQTS + "/" + KQMS;
                //3. Sai thì -1 điểm
                int total = 0;
                double Bonus = total - 1;
                lbBonus.Text = Bonus.ToString();
            }
        }

        private void btKiemTra_Click(object sender, EventArgs e)
        {
            Check();
        }

    }
}
