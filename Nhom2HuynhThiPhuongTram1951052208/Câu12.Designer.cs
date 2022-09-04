
namespace Nhom2HuynhThiPhuongTram1951052208
{
    partial class Câu12
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Câu12));
            this.picBall = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btThanhNgang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            this.SuspendLayout();
            // 
            // picBall
            // 
            this.picBall.Image = ((System.Drawing.Image)(resources.GetObject("picBall.Image")));
            this.picBall.Location = new System.Drawing.Point(271, 127);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(114, 110);
            this.picBall.TabIndex = 0;
            this.picBall.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btThanhNgang
            // 
            this.btThanhNgang.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btThanhNgang.BackColor = System.Drawing.Color.Red;
            this.btThanhNgang.Location = new System.Drawing.Point(296, 397);
            this.btThanhNgang.Name = "btThanhNgang";
            this.btThanhNgang.Size = new System.Drawing.Size(237, 23);
            this.btThanhNgang.TabIndex = 1;
            this.btThanhNgang.UseVisualStyleBackColor = false;
            // 
            // Câu12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btThanhNgang);
            this.Controls.Add(this.picBall);
            this.Name = "Câu12";
            this.Text = "Câu12";
            this.Load += new System.EventHandler(this.Câu12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btThanhNgang;
    }
}