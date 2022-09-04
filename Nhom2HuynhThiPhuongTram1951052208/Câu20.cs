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
    public partial class Câu20 : Form
    {
        public Câu20()
        {
            InitializeComponent();
        }
        #region Biến toàn cục
        string[] Table = new string[] {"B1", "B2", "B3", "B4"};
        DataTable tbOrder; //làm quen việc tạo bảng dữ liệu
        #endregion

        private void Câu20_Load(object sender, EventArgs e)
        {
            comboBoxTable.Items.AddRange(Table);

            tbOrder = new DataTable();
            //Table có 2 cột
            tbOrder.Columns.Add("Món ăn");
            tbOrder.Columns.Add("Số lượng");

            //Add table vào DataGridView tên là tbOrder
            dataGridView1.DataSource = tbOrder;

            //Định dạng 2 cột
            dataGridView1.Columns[0].Width = (int)(dataGridView1.Width * 0.5);
            dataGridView1.Columns[1].Width = (int)(dataGridView1.Width * 0.5);
        }

        private void comboBoxTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBoxTable.SelectedItem.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow row;
            bool co = true; //Biến cờ hiển thị cho việc giá trị đang có tồn tại hay không
            Button b = (Button)sender;
            //Thêm mới 1 dòng vào DataTable
            row = tbOrder.NewRow();

            foreach(DataRow item in tbOrder.Rows) //Duyệt từng dòng trong datatable
            {
                if(item[0].ToString()==b.Text) // Nếu các dòng liên tiếp đang được kiểm duyệt có cùng giá trị với giá trị của button
                {
                    co = false; //không tạo mới giá trị (món ăn) đã tồn tại 
                    item[1] = int.Parse(item[1].ToString()) + 1;
                    break;
                }
                // item[0] là cột 1 (món ăn); item[1] là cột 2 (số lượng)
            }

            if (co) //Nếu món ăn chưa có giá trị (chưa được thêm vào) thì tạo mới món ăn vào datatable
            {
                //Gán giá trị cho dòng mới
                row[0] = b.Text;
                row[1] = 1;
                //Add vào datatable
                tbOrder.Rows.Add(row); 
            }

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            tbOrder.Rows.Clear();
        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter;
            SaveFileDialog saveFileDialog;
            string fileName = "";
            //Ghi ra file text
            //1. Chọn file lưu
            saveFileDialog = new SaveFileDialog();
            //2. Có thì lưu trên file đó (save as)
            if(saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
            }
            //3. Không có thì lưu trên file mặc định
            else
            {
                fileName = @"C:\Users\Kyoya\source\repos\Nhom2HuynhThiPhuongTram1951052208\Lịch sử đặt món (câu 20).txt";
            }

            // Lưu
            if (!File.Exists(fileName)) //chưa có file
            {
                streamWriter = new StreamWriter(fileName);

                //cột 1 cách 10 ký tự, cột 2 cách 30 ký tự, cột 3 cách 20 ký tự
                streamWriter.WriteLine(String.Format("{0,-10} {1,-30} {2,-20}", "Bàn",dataGridView1.Columns[0].HeaderText,"Số lượng"));

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    streamWriter.WriteLine(String.Format("{0,-10} {1,-30} {2,-20}", comboBoxTable.SelectedItem.ToString(),
                        dataGridView1.Rows[i].Cells[0].Value,
                        dataGridView1.Rows[i].Cells[1].Value));

                    //streamWriter.WriteLine(dataGridView1.Rows[i].Cells[0].Value.ToString() + " " +
                    //                       dataGridView1.Rows[i].Cells[1].Value.ToString());
                }
                streamWriter.Close(); 
            }
            else
            {
                streamWriter = File.AppendText(fileName);

                //cột 1 cách 10 ký tự, cột 2 cách 30 ký tự, cột 3 cách 20 ký tự
                streamWriter.WriteLine(String.Format("{0,-10}", "Bàn") +
                    String.Format("{0,-30}", dataGridView1.Columns[0].HeaderText) +
                    String.Format("{0,-20}", dataGridView1.Columns[1].HeaderText));

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    
                    streamWriter.WriteLine(String.Format("{0,-10}", comboBoxTable.SelectedItem.ToString()) + " " +
                    String.Format("{0,-30}", dataGridView1.Rows[i].Cells[0].Value) +
                    String.Format("{0,-20}", dataGridView1.Rows[i].Cells[1].Value));

                    //streamWriter.WriteLine(dataGridView1.Rows[i].Cells[0].Value.ToString() + " " +
                    //                       dataGridView1.Rows[i].Cells[1].Value.ToString());
                }
                streamWriter.Close();
            }
        }
    }
}
