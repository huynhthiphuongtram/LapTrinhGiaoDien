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
    public partial class Câu1 : Form
    {
        public Câu1()
        {
            InitializeComponent();
        }

        private void buttonTinh_Click(object sender, EventArgs e)
        {
            string giatriA = "";
            string giatriB = "";
            giatriA = txtSoA.Text;
            giatriB = txtSoB.Text;
            int soA = Convert.ToInt32(giatriA);
            int soB = Convert.ToInt32(giatriB);

            if(soA>soB)
            {
                txtKetQua.Text = soA.ToString();
            }
            else
            {
                txtKetQua.Text = soB.ToString();
            }
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            txtSoA.Text = "";
            txtSoB.Text = "";
            txtKetQua.Text = "";
        }

        private void Câu1cs_Load(object sender, EventArgs e)
        {

        }
    }
}
