
namespace Nhom2HuynhThiPhuongTram1951052208
{
    partial class Câu25
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeFolder = new System.Windows.Forms.TreeView();
            this.picView = new System.Windows.Forms.PictureBox();
            this.flowThum = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picView)).BeginInit();
            this.SuspendLayout();
            // 
            // treeFolder
            // 
            this.treeFolder.Location = new System.Drawing.Point(4, 3);
            this.treeFolder.Name = "treeFolder";
            this.treeFolder.Size = new System.Drawing.Size(280, 530);
            this.treeFolder.TabIndex = 0;
            this.treeFolder.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeFolder_BeforeExpand);
            this.treeFolder.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeFolder_AfterSelect);
            // 
            // picView
            // 
            this.picView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picView.Location = new System.Drawing.Point(290, 3);
            this.picView.Name = "picView";
            this.picView.Size = new System.Drawing.Size(509, 279);
            this.picView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picView.TabIndex = 1;
            this.picView.TabStop = false;
            // 
            // flowThum
            // 
            this.flowThum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowThum.Location = new System.Drawing.Point(292, 296);
            this.flowThum.Name = "flowThum";
            this.flowThum.Size = new System.Drawing.Size(506, 236);
            this.flowThum.TabIndex = 2;
            // 
            // Câu25
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.flowThum);
            this.Controls.Add(this.picView);
            this.Controls.Add(this.treeFolder);
            this.Name = "Câu25";
            this.Text = "Câu25";
            this.Load += new System.EventHandler(this.Câu25_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeFolder;
        private System.Windows.Forms.PictureBox picView;
        private System.Windows.Forms.FlowLayoutPanel flowThum;
    }
}