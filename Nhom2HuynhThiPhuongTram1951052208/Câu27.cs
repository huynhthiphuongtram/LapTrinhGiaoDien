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
    public partial class Câu27 : Form
    {
        public Câu27()
        {
            InitializeComponent();
        }

        Bitmap bitmap;
        Point oldLoc;
        Color penColor;

        private void Câu27_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(ClientRectangle.Width, ClientRectangle.Height, CreateGraphics());

            oldLoc = new Point();

            penColor = Color.Red;
        }

        private void Câu27_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(bitmap,0,0);
        }

        private void Câu27_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics graphics;
                Pen p;

                graphics = Graphics.FromImage(bitmap);
                p = new Pen(penColor, 1);

                //phương thức vẽ
                graphics.DrawLine(p, oldLoc, e.Location);
                oldLoc = e.Location;

                //Vẽ lên form
                Invalidate(); 
            }
        }

        private void Câu27_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Câu27_MouseDown(object sender, MouseEventArgs e)
        {
            oldLoc = e.Location;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch(keyData)
            {
                case Keys.R:
                    penColor = Color.Red;
                    return true;
                case Keys.G:
                    penColor = Color.Green;
                    return true;
                case Keys.B:
                    penColor = Color.Blue;
                    return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
