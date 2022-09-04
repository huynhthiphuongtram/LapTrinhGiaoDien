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
    public partial class Câu19 : Form
    {
        public Câu19()
        {
            InitializeComponent();
        }

        private void Câu19_Load(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            int viTri;
            viTri = Int32.Parse(txtLocation.Text);
            txtS1.Text = txtS1.Text.Insert(viTri, txtS2.Text);
            txtLocation.Text = " ";
        }
        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            if(txtLocation.Text == "") //nếu như textbox vị trí không có gì được nhập vào
            {
                btAdd.Enabled = false; //tắt chức năng phím chèn
            }
            else
            {
                btAdd.Enabled = true; //mở chức năng phím chèn
            }
        }

        private void btReplaceS2toS3_Click(object sender, EventArgs e)
        {
            txtS1.Text = txtS1.Text.Replace(txtS2.Text, txtS3.Text);
        }

        private void btChangeWordS1_Click(object sender, EventArgs e)
        {
            string[] mangTu;
            char[] token = {' ', ',', '\n', '\t' };
            // 1. Tách từng từ lưu vào mangTu
            mangTu = txtS1.Text.Split(token,StringSplitOptions.RemoveEmptyEntries); //RemoveEmptyEntries: bỏ qua các giá trị rỗng
            // 2. Duyệt cuối mảng
            txtS1.Text = "";
            for(int i = mangTu.Length-1; i>=0; i--)
            {
                txtS1.Text += mangTu[i] + " ";
            }
            txtS1.Text = txtS1.Text.TrimEnd(); //TrimEnd: xóa khoảng trắng cuối
        }

        private void btDeleteS2ofS1_Click(object sender, EventArgs e)
        {
            int viTri = -1;//Indexof
            //Tìm vị trí từ cần xóa
            viTri = txtS1.Text.IndexOf(txtS2.Text);

            //Xóa theo chiều dài của chuỗi
            while (viTri >= 0)
            {
                txtS1.Text = txtS1.Text.Remove(viTri, txtS2.Text.Length);

                //Tìm xem còn từ cần xóa không
                viTri = txtS1.Text.IndexOf(txtS2.Text); 
            }
        }

        private void btNormalize_Click(object sender, EventArgs e)
        {
            //vd: khoa => Khoa

            string[] mangTu; // mangTu = số ký tự (độ dài) của chuỗi
            char[] token = { ' ', ',', '\n', '\t' };
            // 1. Tách từng từ lưu vào mangTu
            mangTu = txtS1.Text.Split(token, StringSplitOptions.RemoveEmptyEntries); //RemoveEmptyEntries: bỏ qua các giá trị rỗng
            // 2. Duyệt từng từ, lấy ký tự đầu in hoa
            for(int i=0; i < mangTu.Length; i++)
            {
                string tu = mangTu[i];
                tu = tu.Substring(0, 1).ToUpper() + tu.Substring(1).ToLower();
                txtS1.Text += tu + " ";
            }
            txtS1.Text.TrimEnd(); //TrimEnd: xóa khoảng trắng cuối
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHeader.Text = lbHeader.Text.Substring(1) + lbHeader.Text.Substring(0, 1);
        }

        private void txtLocation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar)) //nếu như phím ký tự được gõ xuống không phải là số
            {
                e.Handled = true; //Mở chức năng không được nhập ký tự chữ
            }
        }

    }
}
