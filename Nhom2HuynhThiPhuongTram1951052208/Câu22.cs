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
    public partial class Câu22 : Form
    {
        public Câu22()
        {
            InitializeComponent();
        }

        private void Câu22_Load(object sender, EventArgs e)
        {
            lsvNhanVien.View = View.Details;
            lsvNhanVien.GridLines = true;
            lsvNhanVien.FullRowSelect = true;
        }

        private void lsvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        { //Đây là sự kiện chọn 1 dòng để thực hiện chức năng sửa , xóa (khi bấm sửa, xóa thì dữ liệu sẽ được đem lên thông tin chi tiết
            if(lsvNhanVien.SelectedItems.Count > 0)
            {
                txtHoTen.Text = lsvNhanVien.SelectedItems[0].SubItems[0].Text;
                dtpNgaySinh.Text = lsvNhanVien.SelectedItems[0].SubItems[1].Text;
                txtDienThoai.Text = lsvNhanVien.SelectedItems[0].SubItems[2].Text;
                txtDiaChi.Text = lsvNhanVien.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            ListViewItem item = lsvNhanVien.Items.Add(txtHoTen.Text);
            item.SubItems.Add(dtpNgaySinh.Value.ToShortDateString());
            item.SubItems.Add(txtDienThoai.Text);
            item.SubItems.Add(txtDiaChi.Text);

            //Sau khi đem dữ liệu vào list thì reset các textbox rỗng
            txtHoTen.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if(lsvNhanVien.SelectedItems.Count > 0)
            {
                lsvNhanVien.Items.Remove(lsvNhanVien.SelectedItems[0]); //Chọn dòng nào thì xóa dòng đó
            }
            else
            {
                MessageBox.Show("Phải chọn ít nhất một dòng");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedItems.Count > 0)
            {
                lsvNhanVien.SelectedItems[0].SubItems[0].Text = txtHoTen.Text;
                lsvNhanVien.SelectedItems[0].SubItems[1].Text = dtpNgaySinh.Value.ToShortDateString();
                lsvNhanVien.SelectedItems[0].SubItems[2].Text = txtDienThoai.Text;
                lsvNhanVien.SelectedItems[0].SubItems[3].Text = txtDiaChi.Text; 
            }
            else
            {
                MessageBox.Show("Phải chọn ít nhất một dòng");
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
