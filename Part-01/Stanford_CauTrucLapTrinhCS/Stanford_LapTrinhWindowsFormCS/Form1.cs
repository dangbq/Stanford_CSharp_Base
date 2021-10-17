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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string tenDangNhap = "", matKhau = "";

            //Lấy thông tin từ trên giao diện
            tenDangNhap = txtTenDangNhap.Text.Trim();
            matKhau = txtMatKhau.Text;

            //Nếu không nhập tên đăng nhập
            if(tenDangNhap.Length == 0)
            {
                MessageBox.Show("Bạn cần phải nhập tên đăng nhập");
                //Focus con chuột vào ô txtTenDangNhap
                txtTenDangNhap.Focus();
                //Thoát ra không thực hiện công việc nữa
                return;
            }

            if (matKhau.Length == 0)
            {
                MessageBox.Show("Bạn cần phải nhập mật khẩu đăng nhập");
                //Focus con chuột vào ô txtMatKhau
                txtMatKhau.Focus();
                //Thoát ra không thực hiện công việc nữa
                return;
            }

            if(tenDangNhap.Equals("stanford") && matKhau.Equals("123"))
            {
                MessageBox.Show("Đăng nhập thành công");
            } 
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Bạn vui lòng kiểm tra lại thông tin");
            }    
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            //Đóng ứng dụng
            Application.Exit();
        }
    }
}
