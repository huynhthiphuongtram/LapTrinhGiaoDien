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
    public partial class Câu14 : Form
    {
        public Câu14()
        {
            InitializeComponent();
        }

        private void Câu14_Load(object sender, EventArgs e)
        {
            listBoxA.SelectionMode = SelectionMode.MultiSimple;
            listBoxB.SelectionMode = SelectionMode.MultiSimple;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Update()
        {
            //Chuyển chuỗi được nhập vào list
            if (txtHoTen.Text != " ")
            {
                listBoxA.Items.Add(txtHoTen.Text);
                txtHoTen.Text = " ";
                txtHoTen.Focus();
            }
            else
                MessageBox.Show("Dữ liệu chưa được nhập!");

            //listBoxA.SelectedIndex = listBoxA.Items.Count - 1;
        }
        private void btUpdate_Click(object sender, EventArgs e)
        {
            Update();
            btUpdate.Focus();
        }

        private void btLeftToRight_Click(object sender, EventArgs e)
        {
            ////1. Lấy các dữ liệu được chọn
            ////2. Thêm các dữ liệu qua phải
            ////3. Xóa các dữ liệu ở bên trái
            //ListBox.SelectedObjectCollection list = listBoxA.SelectedItems; //danh sách tất cả các phần tử được chọn
            //ListBox.SelectedIndexCollection list2 = listBoxA.SelectedIndices; //danh sách các phần tử được chọn theo vị trí
            //foreach(string item in list) //duyệt từng phần tử để add qua listbox bên phải
            //{
            //    listBoxB.Items.Add(item);
            //}
            //for(int i = list2.Count - 1; i >= 0; i--) //duyệt từng phần tử để xóa phần tử từ dưới xóa lên khỏi listbox bên trái
            //{
            //    listBoxA.Items.RemoveAt(list2[i]);
            //}


            while (listBoxA.SelectedIndices.Count > 0)
            {
                listBoxB.Items.Add(listBoxA.Items[listBoxA.SelectedIndices[0]]);
                listBoxA.Items.RemoveAt(listBoxA.SelectedIndices[0]);
            }
        }

        private void btRightToLeft_Click(object sender, EventArgs e)
        {
            ////1.Lấy các dữ liệu được chọn
            ////2.Thêm các dữ liệu qua trái
            ////3.Xóa các dữ liệu ở bên phải
            //ListBox.SelectedObjectCollection list3 = listBoxB.SelectedItems; //danh sách tất cả các phần tử được chọn
            //ListBox.SelectedIndexCollection list4 = listBoxB.SelectedIndices; //danh sách các phần tử được chọn theo vị trí
            //foreach (string item in list3) //duyệt từng phần tử để add qua listbox bên trái
            //{
            //    listBoxA.Items.Add(item);
            //}
            //for (int i = list4.Count - 1; i >= 0; i--) //duyệt từng phần tử để xóa phần tử từ dưới xóa lên khỏi listbox bên trái
            //{
            //    listBoxB.Items.RemoveAt(list4[i]);
            //}


            while (listBoxB.SelectedIndices.Count > 0)
            {
                listBoxA.Items.Add(listBoxB.Items[listBoxB.SelectedIndices[0]]);
                listBoxB.Items.RemoveAt(listBoxB.SelectedIndices[0]);
            }
        }

        private void btLeftToRightAll_Click(object sender, EventArgs e)
        {
            listBoxB.Items.AddRange(listBoxA.Items);
            listBoxA.Items.Clear();
        }

        private void btRightToLeftAll_Click(object sender, EventArgs e)
        {
            listBoxA.Items.AddRange(listBoxB.Items);
            listBoxB.Items.Clear();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            listBoxA.Items.Clear();
            listBoxB.Items.Clear();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch(keyData)
            {
                case Keys.Enter:
                    Update();
                    txtHoTen.Focus();
                    return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
