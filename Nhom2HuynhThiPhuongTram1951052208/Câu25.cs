using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Nhom2HuynhThiPhuongTram1951052208
{
    public partial class Câu25 : Form
    {
        public Câu25()
        {
            InitializeComponent();
        }

        private void treeFolder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node;
            string[] tapTinAnh;

            picView.Image = null;

            node = e.Node;

            flowThum.Controls.Clear();

            tapTinAnh = Directory.GetFiles(node.FullPath);
            foreach (string item in tapTinAnh)
            {
                if (item.ToLower().EndsWith(".jpg") ||
                    item.ToLower().EndsWith(".png") ||
                    item.ToLower().EndsWith(".jpeg"))
                {
                    PictureBox pic = new PictureBox();

                    pic.Image = Image.FromFile(item);
                    pic.Height = flowThum.Height / 2;
                    pic.Width = flowThum.Height / 2;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Cursor = Cursors.Hand;

                    flowThum.Controls.Add(pic);
                    pic.Click += Pic_Click;
                }
            }
        }

        private void treeFolder_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node;
            string[] thuMucCon;

            node = e.Node;

            thuMucCon = Directory.GetDirectories(node.FullPath);
            node.Nodes.Clear();

            foreach (string item in thuMucCon)
            {
                TreeNode n = node.Nodes.Add(Path.GetFileName(item));
                n.Nodes.Add("Tam");
            }
        }

        private void Init()
        {
            string[] drivers;
            TreeNode node;
            drivers = Directory.GetLogicalDrives();

            foreach (string item in drivers)
            {
                //Tạo 1 treeNode
                node = new TreeNode(item);
                //Add 1 node trong treeview
                treeFolder.Nodes.Add(node);
                //Tạo 1 thư mục con để có dấu +
                node.Nodes.Add("Tam");
            }

        }
        private void Câu25_Load(object sender, EventArgs e)
        {
            Init();
        }
        private void Pic_Click(object sender, EventArgs e)
        {
            //lấy ảnh đó đưa lên picview
            picView.Image = ((PictureBox)sender).Image;
        }
    }
}
