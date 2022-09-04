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
    public partial class Câu6 : Form
    {
        public Câu6()
        {
            InitializeComponent();
        }

        #region Biến toàn cục
        Random rand;
        bool co = false;
        int so1, so2, viTri;
        string[] toanTu = { " + ", " - ", " * ", " / " };
        #endregion

        private void btNumber_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (txtTraLoi.Text.Length == 0 && b.Text == "0")
            {
                ;
            }
            else
            {
                txtTraLoi.Text += b.Text; //chuỗi + chuỗi = chuỗi
            }
            //bấm số sẽ bị bôi đen toàn bộ nên sửa lại lỗi bôi đen toàn bộ mỗi khi nhấn button
            //VD: SelectionStart = 2 : bôi đen ký tự ở vị trí 2
            //    SelectionCount = 3 : bôi đen ở 3 ký tự
            txtTraLoi.Focus();
            txtTraLoi.SelectionStart = txtTraLoi.Text.Length;
        }

        private void btSoAm_Click(object sender, EventArgs e)
        {
            if (co)
            {
                txtTraLoi.Text = " - " + txtTraLoi.Text;
                co = false;
            }
            else
            {
                //-12345
                //12345
                txtTraLoi.Text = txtTraLoi.Text.Substring(1);
                co = true;
            }
        }
        private void btBack_Click(object sender, EventArgs e)
        {
            //1234
            //123
            //12
            //1
            //
            if (txtTraLoi.Text != "")
            {
                txtTraLoi.Text = txtTraLoi.Text.Substring(0, txtTraLoi.Text.Length - 1);
            }
        }

        private void btContinue_Click(object sender, EventArgs e)
        {
            KhoiTao();
        }

        private void Check()
        {
            double ketQua = 0;
            double tam = 0;
            string ketquaChuoi = " ";
            switch (viTri)
            {
                case 0:
                    ketQua = so1 + so2;
                    break;
                case 1:
                    ketQua = so1 - so2;
                    break;
                case 2:
                    ketQua = so1 * so2;
                    break;
                case 3:
                    ketQua = (double)so1 / so2; //định dạng
                    break;
            }
            //So sánh với trả lời của người chơi
            ketquaChuoi = String.Format("{0:0.00}", ketQua);
            //Định dạng trả lời của người chơi
            tam = double.Parse(txtTraLoi.Text);
            txtTraLoi.Text = String.Format("{0:0.00}", tam);

            if (txtTraLoi.Text == ketquaChuoi)
            {
                lbKetqua.Text = "Đúng";
            }
            else
            {
                lbKetqua.Text = "Sai, kết quả là: " + ketquaChuoi;
            }
        }
        private void btCheck_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void KhoiTao()
        {
            rand = new Random();
            //random 2 số và 1 phép toán
            so1 = rand.Next(0, 100); //0-99
            so2 = rand.Next(100);
            viTri = rand.Next(0, 4);

            if (viTri == 3 && so2 == 0) //vị trí dấu chia và so2 có bằng 0 hay không
            {
                so2 = 1; //đặt so2 = 1
            }
            //Hiển thị lên form
            lbSo1.Text = so1.ToString();
            lbSo2.Text = so2.ToString();
            lbPhepToan.Text = toanTu[viTri];

            txtTraLoi.Text = " ";
            lbKetqua.Text = " ";
            txtTraLoi.Focus();
        }

        private void Câu4_Load(object sender, EventArgs e)
        {
            KhoiTao();
        }
    }
}
