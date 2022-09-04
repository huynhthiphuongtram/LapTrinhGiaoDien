using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom2HuynhThiPhuongTram1951052208
{
    public partial class Câu7 : Form
    {
        public Câu7()
        {
            InitializeComponent();
        }
        int[] ManggiaDV = {100000, 1200000, 200000, 80000};
        private void Câu7_Load(object sender, EventArgs e)
        {
            lbTaoVoi.Text = String.Format("{0:N}", ManggiaDV[0]);
            lbTayTrang.Text = String.Format("{0:N}", ManggiaDV[1]);
            lbChupHinhRang.Text = String.Format("{0:N}", ManggiaDV[2]);
            lbTramRang.Text = String.Format("{0:N}", ManggiaDV[3]);
            chkTaoVoi.Enabled = chkTayTrang.Enabled = chkChupHinhRang.Enabled = false;
            numbTramRang.Enabled = false;
            btTinhTien.Enabled = false;
            //lbTaoVoi.Text = ManggiaDV[0].ToString();
            //lbTayTrang.Text = ManggiaDV[1].ToString();
            //lbChupHinhRang.Text = ManggiaDV[2].ToString();
            //lbTramRang.Text = ManggiaDV[3].ToString();
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            if(txtTenKH.Text == "")
            {
                chkTaoVoi.Enabled = chkTayTrang.Enabled = chkChupHinhRang.Enabled = false;
                numbTramRang.Enabled = false;
                btTinhTien.Enabled = false;
            }
            else
            {
                chkTaoVoi.Enabled = chkTayTrang.Enabled = chkChupHinhRang.Enabled = true;
                numbTramRang.Enabled = true;
                btTinhTien.Enabled = true;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btTinhTien_Click(object sender, EventArgs e)
        {

            int tongtien = 0;
            if (chkTaoVoi.Checked)
            {
                tongtien += ManggiaDV[0];
            }
            if (chkTayTrang.Checked)
            {
                tongtien += ManggiaDV[1];
            }
            if (chkChupHinhRang.Checked)
            {
                tongtien += ManggiaDV[2];
            }
            //Trám răng
            tongtien += Convert.ToInt32(numbTramRang.Value) * ManggiaDV[3];
            txtTotal.Text = String.Format("{0:N}",tongtien);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ResetData()
        {
            txtTenKH.Text = txtTotal.Text = "";
            chkTaoVoi.Checked = chkTayTrang.Checked = chkChupHinhRang.Checked = false;
            numbTramRang.Value = 0;
        }

        private void btSavePayment_Click(object sender, EventArgs e)
        {
            //1. Lưu dữ liệu vào listbox và sẽ tự động chuyển qua tab khách hàng
            listboxInfo.Items.Add(txtTenKH.Text + " " + txtTotal.Text + " " + DateTime.Now.ToString("dd/MM/yyyy"));
            listboxInfo.SelectedIndex = listboxInfo.Items.Count - 1;
            ResetData();
            txtTenKH.Focus();

            tabControlPhongNha.SelectTab("tabInfoKH");
            //tabControlPhongNha.SelectedIndex = 1;
        }

        private void btSaveInfoKH_Click(object sender, EventArgs e)
        {
            string path;
            StreamWriter streamWriter;
            path = @"C:\Users\Kyoya\source\repos\Nhom2HuynhThiPhuongTram1951052208\Dữ liệu khách hàng sử dụng dịch vụ.txt";
            //1. Kiểm tra nếu tập tin chưa tồn tại thì tạo mới và ghi nội dung vào tập tin
            if (MessageBox.Show("Bạn có muốn lưu", "dữ liệu mới?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (!File.Exists(path))
                {
                    streamWriter = new StreamWriter(path); //tạo mới
                                                           //Duyệt từng dòng của listboxInfo -> ghi nội dung vào file
                    foreach (string item in listboxInfo.Items)
                    {
                        streamWriter.WriteLine(item);
                    }
                    streamWriter.Close();
                    MessageBox.Show("Tạo mới file thành công!");
                }
            //2. Tập tin đã tồn tại thì thêm dữ liệu vào tập tin
                else
                {
                    streamWriter = File.AppendText(path); //ghi đè 
                    foreach (string item in listboxInfo.Items)
                    {
                        streamWriter.WriteLine(item);
                    }
                    streamWriter.Close();
                    MessageBox.Show("Ghi đè file thành công!");
                }
                listboxInfo.Items.Clear();
            }
        }

        private void btOpenList_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Kyoya\source\repos\Nhom2HuynhThiPhuongTram1951052208\Dữ liệu khách hàng sử dụng dịch vụ.txt";
            try
            {
                using (StreamReader streamReader = new StreamReader(path))
                {
                    /*listboxInfo.Items.Add(streamReader.ReadToEnd());*/ //đọc từ đầu đến cuối không xuống dòng
                    while (streamReader.Peek() >= 0)
                    {
                        listboxInfo.Items.Add(streamReader.ReadLine()); //đọc từng dòng
                    } 
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
