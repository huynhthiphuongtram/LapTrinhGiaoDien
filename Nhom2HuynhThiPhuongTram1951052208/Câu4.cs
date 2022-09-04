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
    public partial class Câu4 : Form
    {
        public Câu4()
        {
            InitializeComponent();
        }

        private void Câu4_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void btTotal_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                try
                {
                    int a = int.Parse(txtNumber1.Text);
                    int b = int.Parse(txtNumber2.Text);
                    int c = a + b;
                    lbResult.Text = c.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR");
                }
            }
            else
                if (radioButton2.Checked == true)
            {
                try
                {
                    int a = int.Parse(txtNumber1.Text);
                    int b = int.Parse(txtNumber2.Text);
                    int c = a - b;
                    lbResult.Text = c.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR");
                }
            }
            else
                    if (radioButton3.Checked == true)
            {
                try
                {
                    int a = int.Parse(txtNumber1.Text);
                    int b = int.Parse(txtNumber2.Text);
                    int c = a * b;
                    lbResult.Text = c.ToString();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Bạn phải nhập 2 dữ liệu!");
                }
            }
            else
                        if (radioButton4.Checked == true)
            {
                try
                {
                    int a = int.Parse(txtNumber1.Text);
                    int b = int.Parse(txtNumber2.Text);
                    int c = a / b;
                    lbResult.Text = c.ToString();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Bạn phải nhập 2 dữ liệu!");
                }
                catch (DivideByZeroException ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi chia cho 0");
                }
            }
            else
                            if (radioButton5.Checked == true)
            {
                try
                {
                    int a = int.Parse(txtNumber1.Text);
                    int b = int.Parse(txtNumber2.Text);
                    int c = a % b;
                    lbResult.Text = c.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR");
                }
            }

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
