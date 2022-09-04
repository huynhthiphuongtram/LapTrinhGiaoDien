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
    public partial class Câu18 : Form
    {
        public Câu18()
        {
            InitializeComponent();
        }

        #region BienToanCuc
        Point vitriBanDau;
        string path;
        PictureBox picImage;
        int soLuong;
        int dis;
        #endregion

        private void Câu18_Load(object sender, EventArgs e)
        {

            path = Application.StartupPath + @"\HinhXucXac\";

            soLuong = 0;
            dis = 8;
            AddImage();
        }

        private void AddImage()
        {
            Random random = new Random();

            soLuong++;

            picImage = new PictureBox();

            picImage.Name = "pic" + soLuong;

            picImage.Width = picImage.Height = 100;
            picImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picImage.Image = Image.FromFile(path + random.Next(1, 6) + ".jpg");

            picImage.MouseDown += picImage_MouseDown;
            picImage.MouseMove += picImage_MouseMove;
            picImage.MouseUp += picImage_MouseUp;

            this.Controls.Add(picImage);
            picImage.BringToFront();


            lbSoLuong.Text = "Số lượng ảnh được tạo : " + soLuong;
        }
        private void picImage_MouseDown(object sender, MouseEventArgs e)
        {
            vitriBanDau = e.Location;
        }

        private void picImage_MouseMove(object sender, MouseEventArgs e)
        {
            int dx, dy;
            if (e.Button == MouseButtons.Left)
            {
                dx = e.X - vitriBanDau.X;
                dy = e.Y - vitriBanDau.Y;
                picImage.Left += dx;
                picImage.Top += dy;
                //vitriBanDau = e.Location;
            }
        }

        private void picImage_MouseUp(object sender, MouseEventArgs e)
        {
            if (flowLayoutPanel2.Bounds.Contains(picImage.Bounds))
            {
                flowLayoutPanel2.Controls.Add(picImage);
                AddImage();
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            PictureBox pic;
            Control[] ctrl = this.Controls.Find("pic" + soLuong, false);
            pic = (PictureBox)ctrl[0];
            switch (keyData)
            {
                case Keys.Up:
                    if (pic.Top > 0)
                    {
                        pic.Top -= dis;
                        if (flowLayoutPanel2.Bounds.Contains(picImage.Bounds))
                        {
                            flowLayoutPanel2.Controls.Add(picImage);
                            AddImage();
                        }
                    }
                    return true;
                case Keys.Down:
                    if (pic.Bottom < ClientRectangle.Height)
                    {
                        pic.Top += dis;
                        if (flowLayoutPanel2.Bounds.Contains(picImage.Bounds))
                        {
                            flowLayoutPanel2.Controls.Add(picImage);
                            AddImage();
                        }
                    }
                    return true;
                case Keys.Left:
                    if (pic.Left > 0)
                    {
                        pic.Left -= dis;
                        if (flowLayoutPanel2.Bounds.Contains(picImage.Bounds))
                        {
                            flowLayoutPanel2.Controls.Add(picImage);
                            AddImage();
                        }
                    }
                    return true;
                case Keys.Right:
                    if (pic.Right < ClientRectangle.Width)
                    {
                        pic.Left += dis;
                        if (flowLayoutPanel2.Bounds.Contains(picImage.Bounds))
                        {
                            flowLayoutPanel2.Controls.Add(picImage);
                            AddImage();
                        }
                    }
                    return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
