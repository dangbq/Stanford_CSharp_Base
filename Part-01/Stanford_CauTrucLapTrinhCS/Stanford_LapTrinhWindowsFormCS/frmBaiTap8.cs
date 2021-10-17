using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stanford_LapTrinhWindowsFormCS
{
    public partial class frmBaiTap8 : Form
    {
        public frmBaiTap8()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string kieu = "", ketQua = "";
            int giaTri = 0;

            if (!int.TryParse(txtGiaTri.Text, out giaTri))
            {
                MessageBox.Show("Bạn cần nhập giá trị là kiểu số");
                txtGiaTri.Focus();
                return;
            }

            kieu = cboKieu.Text;

            for(int i = 0; i <= giaTri; i++)
            {
                if (kieu == "Chẵn" && i % 2 == 0)
                {
                    ketQua += i + "-";
                }
                else
                {
                    if (kieu == "Lẻ" && i % 2 != 0)
                    {
                        ketQua += i + "-";
                    }
                }
            }
           

            //Cắt 1 kí tự ở cuối dòng
            ketQua = ketQua.Substring(0, ketQua.Length - 1);

            //Hiển thị kết quả
            txtKetQua.Text = ketQua;
        }
    }
}
