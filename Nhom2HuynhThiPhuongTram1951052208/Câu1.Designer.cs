
namespace Nhom2HuynhThiPhuongTram1951052208
{
    partial class Câu1
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
            this.lbNhapSoA = new System.Windows.Forms.Label();
            this.lbNhapSoB = new System.Windows.Forms.Label();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbNhapSoA
            // 
            this.lbNhapSoA.AutoSize = true;
            this.lbNhapSoA.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNhapSoA.Location = new System.Drawing.Point(122, 66);
            this.lbNhapSoA.Name = "lbNhapSoA";
            this.lbNhapSoA.Size = new System.Drawing.Size(122, 30);
            this.lbNhapSoA.TabIndex = 0;
            this.lbNhapSoA.Text = "Nhập số A:";
            // 
            // lbNhapSoB
            // 
            this.lbNhapSoB.AutoSize = true;
            this.lbNhapSoB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNhapSoB.Location = new System.Drawing.Point(122, 111);
            this.lbNhapSoB.Name = "lbNhapSoB";
            this.lbNhapSoB.Size = new System.Drawing.Size(120, 30);
            this.lbNhapSoB.TabIndex = 1;
            this.lbNhapSoB.Text = "Nhập số B:";
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbKetQua.Location = new System.Drawing.Point(136, 156);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(89, 30);
            this.lbKetQua.TabIndex = 2;
            this.lbKetQua.Text = "Kết quả";
            // 
            // txtSoA
            // 
            this.txtSoA.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSoA.Location = new System.Drawing.Point(257, 66);
            this.txtSoA.Multiline = true;
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(336, 30);
            this.txtSoA.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(257, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "So sánh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonTinh_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(442, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 56);
            this.button2.TabIndex = 7;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // txtSoB
            // 
            this.txtSoB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSoB.Location = new System.Drawing.Point(257, 111);
            this.txtSoB.Multiline = true;
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(336, 30);
            this.txtSoB.TabIndex = 8;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtKetQua.Location = new System.Drawing.Point(257, 156);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(336, 30);
            this.txtKetQua.TabIndex = 9;
            // 
            // Câu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 348);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.lbNhapSoB);
            this.Controls.Add(this.lbNhapSoA);
            this.Name = "Câu1";
            this.Text = "Câu1";
            this.Load += new System.EventHandler(this.Câu1cs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNhapSoA;
        private System.Windows.Forms.Label lbNhapSoB;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}