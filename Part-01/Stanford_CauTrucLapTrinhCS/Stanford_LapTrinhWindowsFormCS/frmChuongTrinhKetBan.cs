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
    public partial class frmChuongTrinhKetBan : Form
    {
        public frmChuongTrinhKetBan()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Xử lý bài tập 3: Chương trình kết bạn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string hoTen = "", trangThai = "", ketQua = "";
            UInt16 tuoi = 0;
            int gioiTinh = 0;

            //Lấy thông tin từ trên giao diện
            hoTen = txtHoTen.Text;
            UInt16.TryParse(txtTuoi.Text, out tuoi);

            gioiTinh = cboGioiTinh.SelectedIndex;

            trangThai = cboTrangThai.Text;

            #region Kiểm tra nhập dữ liệu
            if(hoTen.Length == 0)
            {
                MessageBox.Show("Bạn cần phải nhập họ tên");
                txtHoTen.Focus();
                return;
            }  
            
            if(tuoi <= 0)
            {
                MessageBox.Show("Bạn cần phải nhập tuổi");
                txtTuoi.Focus();
                return;
            }    
            if(gioiTinh < 0)
            {
                MessageBox.Show("Bạn cần phải chọn giới tính");
                cboGioiTinh.Focus();
                return;
            } 
            
            if(trangThai.Length == 0)
            {
                MessageBox.Show("Bạn cần phải chọn trạng thái");
                cboTrangThai.Focus();
                return;
            }    
            #endregion

            //Xử công việc
            if (tuoi < 19)
            {
                ketQua = "Không được phép tham gia";
            }   
            else
            {
                if(trangThai == "Chưa có gia đình" || trangThai == "Ly hôn")
                {
                    //0: Nam
                    if(gioiTinh == 0 && tuoi >= 22)
                    {
                        ketQua = "Được phép kết bạn";
                    } 
                    else
                    {
                        //1: Nữ
                        if(gioiTinh == 1 && tuoi >= 19)
                        {
                            ketQua = "Được phép kết bạn";
                        } 
                        else
                        {
                            ketQua = "Không được phép tham gia";
                        }    
                    }    
                }  
                else
                {
                    ketQua = "Không được phép tham gia";
                }    
            }   //end

            //Hiển thị kết quả
            txtKetQua.Text = ketQua;
            txtKetQua.ReadOnly = true;
        }
    }
}
