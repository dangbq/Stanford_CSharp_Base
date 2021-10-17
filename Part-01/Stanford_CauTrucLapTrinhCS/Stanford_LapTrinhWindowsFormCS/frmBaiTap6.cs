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
    public partial class frmBaiTap6 : Form
    {
        public frmBaiTap6()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Xử lý công việc sử dụng vòng lặp while
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXem_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string kieu = "", ketQua = "";
            int i = 0, giaTri = 0;

            if(!int.TryParse(txtGiaTri.Text, out giaTri))
            {
                MessageBox.Show("Bạn cần nhập giá trị là kiểu số");
                txtGiaTri.Focus();
                return;
            }

            kieu = cboKieu.Text;

            while(i <= giaTri)//true
            {
                if(kieu == "Chẵn" && i %2 == 0)
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

                i++;
            }

            //Cắt 1 kí tự ở cuối dòng
            ketQua = ketQua.Substring(0, ketQua.Length - 1);

            //Hiển thị kết quả
            txtKetQua.Text = ketQua;
        }
    }
}
