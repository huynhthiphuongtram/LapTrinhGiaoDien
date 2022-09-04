using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom2HuynhThiPhuongTram1951052208_NETFramework
{
    public partial class Câu17 : Form
    {
        public Câu17()
        {
            InitializeComponent();
        }

        private void Câu17_Load(object sender, EventArgs e)
        {
            lbRealTime.Text = "Hôm nay là " + DateTime.Now.ToString("dd / MM / yyyy")
                + " Bây giờ là " + DateTime.Now.ToString("hh:mm:ss");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Chọn và mở file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //Lọc các định dạng muốn mở
            openFileDialog.Filter = "AVI file|*.avi|WAV|*.wav|MP4 file|*.mp4";
            //Gọi phương thức Open
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog.FileName;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Đóng form?", "Bạn đang thoát form", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                return;
            }
        }
    }
}
