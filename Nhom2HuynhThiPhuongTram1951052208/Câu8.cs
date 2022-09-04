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
    public partial class Câu8 : Form
    {
        public Câu8()
        {
            InitializeComponent();
        }

        private void txtSecurityCode_KeyDown(object sender, KeyEventArgs e)
        {
            string giaTri;
            if(e.KeyCode == Keys.Enter)
            {
                giaTri = txtSecurityCode.Text;
                string chuoiKQ;
                switch(giaTri)
                {
                    case "1645":
                    case "1689":
                        chuoiKQ = "Technicians";
                        break;
                    case "8345":
                        chuoiKQ = "Custodians";
                        break;
                    case "9998":
                    case "1006":
                    case "1007":
                    case "1008":
                        chuoiKQ = "Scientist";
                        break;
                    default:
                        chuoiKQ = "Restricted Access";
                        break;
                }
                listAccessLog.Items.Add(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss")+ " " + chuoiKQ);
                //listAccessLog.Items.Add(String.Format("{0: dd/MM/yyyy } {1}", DateTime.Now, chuoiKQ));
                txtSecurityCode.Text = "";
            }
        }

        private void btNumber_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtSecurityCode.Text += bt.Text;
            txtSecurityCode.Focus();
        }

        private void buttonDeleteNum_Click(object sender, EventArgs e)
        {
            if (txtSecurityCode.Text != "")
            {
                txtSecurityCode.Text = txtSecurityCode.Text.Substring(0, txtSecurityCode.Text.Length - 1);
            }
        }

        //CÂU 9
        private void btSave_Click(object sender, EventArgs e)
        {
            string path;
            StreamWriter streamWriter;
            //Lấy GT từ listbox lưu xuống file txt
            //1.Khai báo đường dẫn tập tin
            //2.Kiểm tra nếu tập tin chưa tồn tại thì tạo mới
            //và ghi nội dung vào tập tin
            //3. Tập tin đã tồn tại thì thêm dữ liệu vào tập tin

            //1. Khai báo đường dẫn tập tin
            path = @"C:\Users\Kyoya\source\repos\Nhom2HuynhThiPhuongTram1951052208\LuuDL.txt";
            //2. Kiểm tra nếu tập tin chưa tồn tại thì tạo mới
            //và ghi nội dung vào tập tin
            if (MessageBox.Show("Bạn có muốn lưu", "lịch sử đăng nhập?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (!File.Exists(path))
                {
                    streamWriter = new StreamWriter(path); //tạo mới
                                                           //Duyệt từng dòng của listbox -> ghi nội dung vào file
                    foreach (string item in listAccessLog.Items)
                    {
                        streamWriter.WriteLine(item);
                    }
                    streamWriter.Close();
                    MessageBox.Show("Tạo mới file thành công!");
                }
                //3. Tập tin đã tồn tại thì thêm dữ liệu vào tập tin
                else
                {
                    streamWriter = File.AppendText(path); //ghi đè 
                    foreach (string item in listAccessLog.Items)
                    {
                        streamWriter.WriteLine(item);
                    }
                    streamWriter.Close();
                    MessageBox.Show("Ghi đè file thành công!");
                } 
            }
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch(keyData)
            {
                case Keys.D1:
                    txtSecurityCode.Text += "1";
                    txtSecurityCode.Focus();
                    txtSecurityCode.SelectionStart = txtSecurityCode.Text.Length - 1;
                    return true;
                case Keys.D2:
                    txtSecurityCode.Text += "2";
                    txtSecurityCode.Focus();
                    txtSecurityCode.SelectionStart = txtSecurityCode.Text.Length - 1;
                    return true;
                case Keys.D3:
                    txtSecurityCode.Text += "3";
                    txtSecurityCode.Focus();
                    txtSecurityCode.SelectionStart = txtSecurityCode.Text.Length - 1;
                    return true;
                case Keys.D4:
                    txtSecurityCode.Text += "4";
                    txtSecurityCode.Focus();
                    txtSecurityCode.SelectionStart = txtSecurityCode.Text.Length - 1;
                    return true;
                case Keys.D5:
                    txtSecurityCode.Text += "5";
                    txtSecurityCode.Focus();
                    txtSecurityCode.SelectionStart = txtSecurityCode.Text.Length - 1;
                    return true;
                case Keys.D6:
                    txtSecurityCode.Text += "6";
                    txtSecurityCode.Focus();
                    txtSecurityCode.SelectionStart = txtSecurityCode.Text.Length - 1;
                    return true;
                case Keys.D7:
                    txtSecurityCode.Text += "7";
                    txtSecurityCode.Focus();
                    txtSecurityCode.SelectionStart = txtSecurityCode.Text.Length - 1;
                    return true;
                case Keys.D8:
                    txtSecurityCode.Text += "8";
                    txtSecurityCode.Focus();
                    txtSecurityCode.SelectionStart = txtSecurityCode.Text.Length - 1;
                    return true;
                case Keys.D9:
                    txtSecurityCode.Text += "9";
                    txtSecurityCode.Focus();
                    txtSecurityCode.SelectionStart = txtSecurityCode.Text.Length - 1;
                    return true;
                case Keys.D0:
                    txtSecurityCode.Text += "0";
                    txtSecurityCode.Focus();
                    txtSecurityCode.SelectionStart = txtSecurityCode.Text.Length - 1;
                    return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    
    }
}
