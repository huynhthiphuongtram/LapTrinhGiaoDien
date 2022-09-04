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
    public partial class Câu2 : Form
    {
        public Câu2()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            string giatriN = "";
            giatriN = txtGiaTriN.Text;
            int songuyenN = Convert.ToInt32(giatriN);
            int tongS = 0;
            for(int i=1;i<=songuyenN;i++)
            {
                tongS = tongS + i;
            }
            txtGiaTriTong.Text = tongS.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtGiaTriN.Text = "";
            txtGiaTriTong.Text = "";
        }

        private void Câu2_Load(object sender, EventArgs e)
        {

        }
    }
}
