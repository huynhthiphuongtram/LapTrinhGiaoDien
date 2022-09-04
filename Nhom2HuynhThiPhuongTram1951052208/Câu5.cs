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
    public partial class Câu5 : Form
    {
        public Câu5()
        {
            InitializeComponent();
        }

        private void Câu5_Load(object sender, EventArgs e)
        {
            rd3.Checked = true;
            rd3.Appearance = Appearance.Button;
            rd11.Appearance = Appearance.Button;
        }
        private void btRoll_Click(object sender, EventArgs e)
        {
            int so1 = int.Parse(lbSo1.Text);
            int so2 = int.Parse(lbSo2.Text);
            int so3 = int.Parse(lbSo3.Text);
            Random rand = new Random();
            so1 = rand.Next(0, 9);
            so2 = rand.Next(0, 9);
            so3 = rand.Next(0, 9);
            int total = so1 + so2 + so3;
            lbSo1.Text = so1.ToString();
            lbSo2.Text = so2.ToString();
            lbSo3.Text = so3.ToString();
            if (rd3.Checked == true)
            {
                if (total >= 3 && total <= 10)
                {
                    total = 0;
                    int Bonus = total + 10;
                    lbDiem.Text = "+" + Bonus.ToString();
                }
                else
                {
                    total = 0;
                    double Bonus = total - 10;
                    lbDiem.Text = Bonus.ToString();
                }
            }
            else
            {
                if (total >= 11 && total <= 18)
                {
                    total = 0;
                    int Bonus = total + 10;
                    lbDiem.Text = "+" + Bonus.ToString();
                }
                else
                {
                    total = 0;
                    double Bonus = total - 10;
                    lbDiem.Text = Bonus.ToString();
                }
            }
        }
    }
}
