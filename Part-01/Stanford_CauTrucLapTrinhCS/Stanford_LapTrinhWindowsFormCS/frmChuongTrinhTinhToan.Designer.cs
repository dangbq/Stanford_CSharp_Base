
namespace Stanford_LapTrinhWindowsFormCS
{
    partial class frmChuongTrinhTinhToan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSob = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPhepToan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnTinhToan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTinhToan);
            this.groupBox1.Controls.Add(this.txtKetQua);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboPhepToan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSob);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSoa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin tính toán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số a:";
            // 
            // txtSoa
            // 
            this.txtSoa.Location = new System.Drawing.Point(105, 36);
            this.txtSoa.Name = "txtSoa";
            this.txtSoa.Size = new System.Drawing.Size(226, 22);
            this.txtSoa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số b:";
            // 
            // txtSob
            // 
            this.txtSob.Location = new System.Drawing.Point(105, 74);
            this.txtSob.Name = "txtSob";
            this.txtSob.Size = new System.Drawing.Size(226, 22);
            this.txtSob.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phép toán:";
            // 
            // cboPhepToan
            // 
            this.cboPhepToan.FormattingEnabled = true;
            this.cboPhepToan.Items.AddRange(new object[] {
            "Cộng",
            "Trừ",
            "Nhân",
            "Chia"});
            this.cboPhepToan.Location = new System.Drawing.Point(105, 113);
            this.cboPhepToan.Name = "cboPhepToan";
            this.cboPhepToan.Size = new System.Drawing.Size(121, 24);
            this.cboPhepToan.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kết quả:";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(105, 152);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(226, 22);
            this.txtKetQua.TabIndex = 7;
            // 
            // btnTinhToan
            // 
            this.btnTinhToan.Location = new System.Drawing.Point(246, 180);
            this.btnTinhToan.Name = "btnTinhToan";
            this.btnTinhToan.Size = new System.Drawing.Size(85, 32);
            this.btnTinhToan.TabIndex = 8;
            this.btnTinhToan.Text = "Tính toán";
            this.btnTinhToan.UseVisualStyleBackColor = true;
            this.btnTinhToan.Click += new System.EventHandler(this.btnTinhToan_Click);
            // 
            // frmChuongTrinhTinhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 298);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmChuongTrinhTinhToan";
            this.Text = "frmChuongTrinhTinhToan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTinhToan;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboPhepToan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoa;
        private System.Windows.Forms.Label label1;
    }
}