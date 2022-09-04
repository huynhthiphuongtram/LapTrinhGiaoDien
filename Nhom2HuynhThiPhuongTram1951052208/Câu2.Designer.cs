
namespace Nhom2HuynhThiPhuongTram1951052208
{
    partial class Câu2
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
            this.lbTextNhapN = new System.Windows.Forms.Label();
            this.txtGiaTriN = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbTong = new System.Windows.Forms.Label();
            this.txtGiaTriTong = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTextNhapN
            // 
            this.lbTextNhapN.AutoSize = true;
            this.lbTextNhapN.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTextNhapN.Location = new System.Drawing.Point(94, 67);
            this.lbTextNhapN.Name = "lbTextNhapN";
            this.lbTextNhapN.Size = new System.Drawing.Size(96, 30);
            this.lbTextNhapN.TabIndex = 0;
            this.lbTextNhapN.Text = "Nhập N:";
            // 
            // txtGiaTriN
            // 
            this.txtGiaTriN.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGiaTriN.Location = new System.Drawing.Point(209, 67);
            this.txtGiaTriN.Multiline = true;
            this.txtGiaTriN.Name = "txtGiaTriN";
            this.txtGiaTriN.Size = new System.Drawing.Size(339, 30);
            this.txtGiaTriN.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(144, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tính tổng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTong.Location = new System.Drawing.Point(103, 116);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(64, 30);
            this.lbTong.TabIndex = 3;
            this.lbTong.Text = "Tổng";
            // 
            // txtGiaTriTong
            // 
            this.txtGiaTriTong.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGiaTriTong.Location = new System.Drawing.Point(209, 116);
            this.txtGiaTriTong.Multiline = true;
            this.txtGiaTriTong.Name = "txtGiaTriTong";
            this.txtGiaTriTong.Size = new System.Drawing.Size(339, 30);
            this.txtGiaTriTong.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(371, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // Câu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 322);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtGiaTriTong);
            this.Controls.Add(this.lbTong);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtGiaTriN);
            this.Controls.Add(this.lbTextNhapN);
            this.Name = "Câu2";
            this.Text = "Câu2 Tính tổng S";
            this.Load += new System.EventHandler(this.Câu2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTextNhapN;
        private System.Windows.Forms.TextBox txtGiaTriN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.TextBox txtGiaTriTong;
        private System.Windows.Forms.Button button2;
    }
}