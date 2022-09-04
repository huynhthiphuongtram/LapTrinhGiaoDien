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
    public partial class Câu23 : Form
    {
        public static string tenDN = "";
        public Câu23()
        {
            Login f = new Login();
            f.ShowDialog();
            InitializeComponent();
        }

        private void Câu23_Load(object sender, EventArgs e)
        {
            txtTenDN.Text = tenDN;
            cbbQueQuan.Items.AddRange(new string[] { "Hà nội", "Đà Nẵng", "Hồ Chí Minh" });
            lsvNhanVien.Columns[0].Width = (int)(lsvNhanVien.Width * 0.4);
            lsvNhanVien.Columns[1].Width = (int)(lsvNhanVien.Width * 0.3);
            lsvNhanVien.Columns[2].Width = (int)(lsvNhanVien.Width * 0.2);
            lsvNhanVien.Columns[3].Width = (int)(lsvNhanVien.Width * 0.4);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            ListViewItem item;
            if (txtHoTen.Text != "")
            {
                item = new ListViewItem(txtHoTen.Text);
                item.SubItems.Add(dTPNgaySinh.Value.ToString("dd/MM/yyyy"));
                item.SubItems.Add(radNam.Checked ? "Nam" : "Nữ");
                item.SubItems.Add(cbbQueQuan.SelectedIndex.ToString());
                item.ImageIndex = (radNam.Checked ? 0 : 1);

                lsvNhanVien.Items.Add(item);
                txtHoTen.Text = "";
                txtHoTen.Focus();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lsvNhanVien.SelectedItems)
            {
                lsvNhanVien.Items.Remove(item);
            }
        }

        private void lsvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gioiTinh = "";
            if (lsvNhanVien.SelectedItems.Count > 0)
            {
                txtHoTen.Text = lsvNhanVien.SelectedItems[0].SubItems[0].Text;
                dTPNgaySinh.Text = lsvNhanVien.SelectedItems[0].SubItems[1].Text;
                gioiTinh = lsvNhanVien.SelectedItems[0].SubItems[2].Text;
                if (gioiTinh == "Nam")
                {
                    radNam.Checked = true;
                }
                else
                    radNu.Checked = true;
                cbbQueQuan.SelectedValue = lsvNhanVien.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            lsvNhanVien.SelectedItems[0].SubItems[0].Text = txtHoTen.Text;
            lsvNhanVien.SelectedItems[0].SubItems[1].Text = dTPNgaySinh.Value.ToString("dd/MM/yyyy");
            lsvNhanVien.SelectedItems[0].SubItems[2].Text = radNam.Checked ? "Nam" : "Nữ";
            lsvNhanVien.SelectedItems[0].SubItems[3].Text = cbbQueQuan.SelectedIndex.ToString();

            lsvNhanVien.SelectedItems[0].ImageIndex = (radNam.Checked ? 0 : 1);
        }
    }
}
