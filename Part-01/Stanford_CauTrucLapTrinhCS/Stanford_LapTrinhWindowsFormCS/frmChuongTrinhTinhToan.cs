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
    public partial class frmChuongTrinhTinhToan : Form
    {
        public frmChuongTrinhTinhToan()
        {
            InitializeComponent();
        }

        private void btnTinhToan_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string strSoa = "", strSob = "", phepToan = "";

            double soa = 0, sob = 0, ketQua = 0;

            //Lấy thông tin từ trên giao diện
            strSoa = txtSoa.Text;
            strSob = txtSob.Text;
            phepToan = cboPhepToan.Text;

            //Nếu không phải là số thì đưa ra thông báo
            //Còn nếu đúng là dạng số thì gán giá trị số sau khi chuyển đổi cho biến soa
            if(!double.TryParse(strSoa, out soa))
            {
                MessageBox.Show("Bạn cần phải nhập số a là kiểu số");
                txtSoa.Focus();
                return;
            }

            if (!double.TryParse(strSob, out sob))
            {
                MessageBox.Show("Bạn cần phải nhập số b là kiểu số");
                txtSob.Focus();
                return;
            }

            //Sử dụng switch case để tính toán
            switch(phepToan)
            {
                case "Cộng": ketQua = soa + sob;
                    break;
                case "Trừ": ketQua = soa - sob;
                    break;
                case "Nhân": ketQua = soa * sob;
                    break;
                case "Chia":
                    if(sob != 0)
                    {
                        ketQua = soa / sob;
                    }    
                    else
                    {
                        MessageBox.Show("Bạn cần phải nhập số b khác 0");
                        txtSob.Focus();
                    }
                    break;
                default:
                    MessageBox.Show("Bạn cần phải chọn phép toán");
                    cboPhepToan.Focus();
                    break;
            }  //End switch

            //Hiển thị kết quả
            txtKetQua.Text = ketQua.ToString();
        }
    }
}
