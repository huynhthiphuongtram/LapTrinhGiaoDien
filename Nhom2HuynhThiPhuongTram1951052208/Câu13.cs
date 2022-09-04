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
    public partial class Câu13 : Form
    {
        public Câu13()
        {
            InitializeComponent();
        }
        #region Biến toàn cục
        string path;
        int soNguoiChoiChon;
        int solanChoi;
        //label 1, label2
        int solanThang, solanThua;
        #endregion

        private void KhoiTao()
        {
            soNguoiChoiChon = 1;
            solanChoi = 0;
            picChoose.Image = Image.FromFile(path + soNguoiChoiChon + ".bmp");
            picResult.Image = null; //bắt đầu thì không có hình
            solanThang = solanThua = 0;

            lbWin.Text = lbLose.Text = lbCount.Text = " ";
            listResult.Items.Clear(); //Bảng listResult không có phần tử nào hết
        }
        private void Câu13_Load(object sender, EventArgs e)
        {
            path = Application.StartupPath + @"\HinhXucXac\";
            KhoiTao();
        }
        private void Play()
        {
            Random rand = new Random();
            int soCuaMay;
            string ketQua = "";
            soCuaMay = rand.Next(1, 6); //random xúc xắc từ 1 đến 6
            solanChoi++;
            picResult.Image = Image.FromFile(path + soCuaMay + ".bmp");

            if (soCuaMay == soNguoiChoiChon)
            {
                ketQua = "Đúng";
                solanThang++;
            }
            else
            {
                ketQua = "Sai";
                solanThua++;
            }
            listResult.Items.Add(String.Format("{0}. {1} (Đoán {2} ra {3})", solanChoi, ketQua, soNguoiChoiChon, soCuaMay));
            // 0 = số lần chơi ; 1 = kết quả đúng hay sai ; 2 = số xúc xắc người chơi chọn ; 3 = số xúc xắc của máy 

            listResult.SelectedIndex = listResult.Items.Count - 1; //sự kiện cho phép chọn dòng trong listResult

            //THỐNG KÊ
            lbCount.Text = String.Format("Lần đoán: {0}", solanChoi); //đếm số lần chơi
            lbWin.Text = String.Format("Lần đúng: {0} ({1:0.00} % )", solanThang, (double)solanThang * 100 / solanChoi);
            lbLose.Text = String.Format("Lần sai: {0} ({1:0.00} % )", solanThua, (double)solanThua * 100 / solanChoi);
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            Play();
            btPlay.Focus();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            KhoiTao();
            btReset.Focus();
        }

        private void ClickButton(Button bt)
        {
            picChoose.Image = Image.FromFile(path + bt.Text + ".bmp");
            bt.Focus();
        }
        private void bt1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            ClickButton(bt);
            soNguoiChoiChon = int.Parse(bt.Text);
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    Play();
                    btPlay.Focus();
                    return true;
                case Keys.Escape:
                    KhoiTao();
                    return true;
                case Keys.D1:
                    ClickButton(button1);
                    return true;
                case Keys.D2:
                    ClickButton(button2);
                    return true;
                case Keys.D3:
                    ClickButton(button3);
                    return true;
                case Keys.D4:
                    ClickButton(button4);
                    return true;
                case Keys.D5:
                    ClickButton(button5);
                    return true;
                case Keys.D6:
                    ClickButton(button6);
                    return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
