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
    public partial class frmBaiTap5 : Form
    {
        public frmBaiTap5()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Xử lý công việc khi chọn 1 thông tin trên cbo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboChonKieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Khai báo biến
            string kieu = "", kichThuoc = "", kieuNet = "", mienGiaTri = "";

            kieu = cboChonKieu.Text;

            switch(kieu)
            {
                case "byte": kichThuoc = "1 byte";
                    kieuNet = "Byte";
                    mienGiaTri = "Không dấu (0->255)";
                    break;
                case "short": kichThuoc = "2 byte";
                    kieuNet = "Int16";
                    mienGiaTri = "-2^15 => 2^15 - 1";
                    break;
                case "int":
                    kichThuoc = "4 byte";
                    kieuNet = "Int32";
                    mienGiaTri = "-2^31 => 2^31 - 1";
                    break;
                case "long":
                    kichThuoc = "8 byte";
                    kieuNet = "Int64";
                    mienGiaTri = "-2^63 => 2^63 - 1";
                    break;
            }

            //Hiển thị kết quả
            lblKichThuoc.Text = kichThuoc;
            lblKieu.Text = kieuNet;
            lblMoTa.Text = mienGiaTri;

        }

        /// <summary>
        /// Thực hiện công việc ngay khi form hiển thị
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBaiTap5_Load(object sender, EventArgs e)
        {
            //Gán thông tin về rỗng
            lblKichThuoc.Text = string.Empty;
            lblKieu.Text = string.Empty;
            lblMoTa.Text = string.Empty;
        }
    }
}
