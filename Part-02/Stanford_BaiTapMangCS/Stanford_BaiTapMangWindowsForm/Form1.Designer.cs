﻿
namespace Stanford_BaiTapMangWindowsForm
{
    partial class Form1
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
            this.txtSoThapPhan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoNhiPhan = new System.Windows.Forms.TextBox();
            this.btnChuyenDoi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChuyenDoi);
            this.groupBox1.Controls.Add(this.txtSoNhiPhan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSoThapPhan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chuyển từ số thập phân sang nhị phân";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số thập phân:";
            // 
            // txtSoThapPhan
            // 
            this.txtSoThapPhan.Location = new System.Drawing.Point(129, 32);
            this.txtSoThapPhan.Name = "txtSoThapPhan";
            this.txtSoThapPhan.Size = new System.Drawing.Size(231, 22);
            this.txtSoThapPhan.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số nhị phân:";
            // 
            // txtSoNhiPhan
            // 
            this.txtSoNhiPhan.Location = new System.Drawing.Point(129, 75);
            this.txtSoNhiPhan.Name = "txtSoNhiPhan";
            this.txtSoNhiPhan.Size = new System.Drawing.Size(231, 22);
            this.txtSoNhiPhan.TabIndex = 3;
            // 
            // btnChuyenDoi
            // 
            this.btnChuyenDoi.Location = new System.Drawing.Point(262, 103);
            this.btnChuyenDoi.Name = "btnChuyenDoi";
            this.btnChuyenDoi.Size = new System.Drawing.Size(98, 28);
            this.btnChuyenDoi.TabIndex = 4;
            this.btnChuyenDoi.Text = "Chuyển đổi";
            this.btnChuyenDoi.UseVisualStyleBackColor = true;
            this.btnChuyenDoi.Click += new System.EventHandler(this.btnChuyenDoi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 201);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Chuyển đổi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChuyenDoi;
        private System.Windows.Forms.TextBox txtSoNhiPhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoThapPhan;
        private System.Windows.Forms.Label label1;
    }
}

