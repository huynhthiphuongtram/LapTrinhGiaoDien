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
    public partial class Câu3 : Form
    {
        public Câu3()
        {
            InitializeComponent();
        }

        private void Câu3_Load(object sender, EventArgs e)
        {
            Form: Text = "Các phép tính";
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            //lấy giá trị nhập vào trong 2 textbox
            //chuyển về số và gán vào hai biến a,b
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);
            int c = a + b;
            //chuyển c thành chuỗi, gán vào thuộc tính Text
            //của label để hiển thị kết quả
            lbKetqua.Text = c.ToString();
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            //lấy giá trị nhập vào trong 2 textbox
            //chuyển về số và gán vào hai biến a,b
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);
            int c = a - b;
            //chuyển c thành chuỗi, gán vào thuộc tính Text
            //của label để hiển thị kết quả
            lbKetqua.Text = c.ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            //lấy giá trị nhập vào trong 2 textbox
            //chuyển về số và gán vào hai biến a,b
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);
            int c = a * b;
            //chuyển c thành chuỗi, gán vào thuộc tính Text
            //của label để hiển thị kết quả
            lbKetqua.Text = c.ToString();
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            //lấy giá trị nhập vào trong 2 textbox
            //chuyển về số và gán vào hai biến a,b
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);
            double c = (double) a / b;
            //chuyển c thành chuỗi, gán vào thuộc tính Text
            //của label để hiển thị kết quả
            lbKetqua.Text = c.ToString();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
