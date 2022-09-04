using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom2HuynhThiPhuongTram1951052208
{
    public partial class Câu26 : Form
    {
        private object color;
        public Câu26()
        {
            InitializeComponent();
        }
        private void FCau26_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            SolidBrush solidBrush;
            HatchBrush hatchBrush;
            LinearGradientBrush linearGradientBrush;
            TextureBrush textureBrush;
            Image image;
            StringFormat stringFormat = new StringFormat();

            string chuoi = "HELLO";
            Font font = new Font("Arial", 50, FontStyle.Bold);

            solidBrush = new SolidBrush(Color.Green);
            hatchBrush = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.Yellow, Color.Red);
            linearGradientBrush = new LinearGradientBrush(new Rectangle(10, 10, 10, 10), Color.Blue, Color.White, LinearGradientMode.Horizontal);

            image = Image.FromFile(@"C:\Users\Kyoya\source\repos\Nhom2HuynhThiPhuongTram1951052208\Vẽ.png");
            textureBrush = new TextureBrush(image);

            //vẽ
            //2
            stringFormat.Alignment = StringAlignment.Far;

            g.DrawString(chuoi, font, solidBrush, ClientRectangle, stringFormat);
            //4
            stringFormat.Alignment = StringAlignment.Near;
            stringFormat.LineAlignment = StringAlignment.Far;
            g.DrawString(chuoi, font, textureBrush, ClientRectangle, stringFormat);
            //1
            stringFormat.FormatFlags = StringFormatFlags.DirectionVertical;
            stringFormat.Alignment = StringAlignment.Near;
            stringFormat.LineAlignment = StringAlignment.Near;

            g.DrawString(chuoi, font, hatchBrush, ClientRectangle, stringFormat);

            //3
            stringFormat.Alignment = StringAlignment.Far;
            stringFormat.LineAlignment = StringAlignment.Far;
            stringFormat.FormatFlags = StringFormatFlags.DirectionVertical;

            g.DrawString(chuoi, font, linearGradientBrush, ClientRectangle, stringFormat);


        }

        private void Câu26_Load(object sender, EventArgs e)
        {

        }
    }
}
