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
    public partial class Câu12 : Form
    {
        public Câu12()
        {
            InitializeComponent();
        }

        int dx, dy;
        bool BallStatus;
        int dxThanhNgang = 8;
        bool isGameOver;
        bool kiemtraVaCham;

        private void Câu12_Load(object sender, EventArgs e)
        {
            dx = 10;
            dy = 8;
            BallStatus = false;
            dxThanhNgang = 8;
            isGameOver = false;
            kiemtraVaCham = true;
        }
        private void DiChuyenThanhNgang(int giaTri)
        {
            if(btThanhNgang.Left > 0 && btThanhNgang.Right<ClientRectangle.Width)
            {
                btThanhNgang.Left += giaTri;
            }   
        }
        private void KiemTraVaCham()
        {
            if (kiemtraVaCham)
            {
                if (btThanhNgang.Bounds.IntersectsWith(picBall.Bounds))
                {
                    dy = -dy; //Trái bóng đang xuống tung độ âm sẽ dội lên thành tung độ dương
                    kiemtraVaCham = false;
                } 
            }
        }
        private void DiChuyenBanh()
        {
            if (!isGameOver) // = true
            {
                if (picBall.Left < 0 || picBall.Right > ClientRectangle.Width)
                {
                    dx = -dx;
                    kiemtraVaCham = true;
                }
                if (picBall.Top < 0 || picBall.Bottom > ClientRectangle.Height)
                {
                    dy = -dy;
                    kiemtraVaCham = true;
                }
                picBall.Left += dx;
                picBall.Top += dy;
                
                if (picBall.Bottom > btThanhNgang.Bottom)
                {
                    isGameOver = true; //gán isGameOver = true, nếu nhảy lên if trên thì sẽ thành false
                                       //và sẽ nhảy vào else dưới của if trên => dừng hoạt động
                }
            }
            else
            {
                timer1.Stop();
                timer1.Enabled = false;
                //timer1.Dispose(); Khi nào không muốn chơi nữa thì hủy timer
                MessageBox.Show("KẾT THÚC, YOU LOSE!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DiChuyenBanh();
            KiemTraVaCham();
        }
        

        protected override bool ProcessDialogKey(Keys keyData) //sử dụng phím để điều khiển
        {
            switch(keyData)
            {
                case Keys.Space:
                    if (!isGameOver)
                    {
                        BallStatus = !BallStatus; //hoạt động sang không hoạt động và ngược lại
                        if (BallStatus)// = true
                        {
                            timer1.Enabled = BallStatus;
                            timer1.Start();
                        }
                        else // = false
                        {
                            timer1.Stop();
                            timer1.Enabled = BallStatus;
                        } 
                    }
                    //Vì timer đang mặc định là false (trái banh không hoạt đông)
                    //timer1.Enabled = BallStatus; nên khi gọi sự kiện khi nhấn phím space thì trái banh sẽ di chuyển
                    return true;
                case Keys.Left:
                    if (btThanhNgang.Left > 0) //Nếu thanh ngang nằm trong khoảng từ 0
                    {
                        btThanhNgang.Left -= dxThanhNgang;
                    }
                    //btThanhNgang.Left -= 8; //qua trái thì hoành độ -8 dần đều
                    return true;
                case Keys.Right:
                    if (btThanhNgang.Right < ClientRectangle.Width) //Nếu thanh ngang nằm trong khoảng bé hơn chiều rộng của winform
                    {
                        btThanhNgang.Left += dxThanhNgang;
                    }
                    //btThanhNgang.Left += 8; //qua phải thì hoành độ +8 dần đều
                    return true;

            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
