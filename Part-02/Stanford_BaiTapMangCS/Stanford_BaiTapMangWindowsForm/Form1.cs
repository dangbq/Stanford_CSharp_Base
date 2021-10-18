using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stanford_BaiTapMangWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Xử lý chuyển đổi từ số thập phân sang nhị phân
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChuyenDoi_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string strSoNhiPhan = "";
            int soThapPhan = 0, soDu = 0;
            //Khai báo 1 list để chứa các số dư
            List<string> lstSoDu = new List<string>();

            //Lấy thông tin từ trên giao diện
            if(!int.TryParse(txtSoThapPhan.Text, out soThapPhan))
            {
                MessageBox.Show("Bạn cần nhập số thập phân là kiểu số nguyên");
                txtSoThapPhan.Focus();
                return;
            } 
            
            //Xử lý chuyển đổi sang số nhị phân
            while(soThapPhan > 0)
            {
                soDu = soThapPhan % 2;
                soThapPhan = soThapPhan / 2;
                //Thêm vào danh sách
                lstSoDu.Add(soDu.ToString());
            }    

            //Duyệt theo chiều trên xuống dưới
            for(int i = lstSoDu.Count - 1; i>= 0; i--)
            {
                strSoNhiPhan += lstSoDu[i];
            }

            //Hiển thị số nhị phân
            txtSoNhiPhan.Text = strSoNhiPhan;
            txtSoNhiPhan.ReadOnly = true;

            //Cách 2: Chuyển về số nhị phân
            //Sử dụng hàm
            int soTP1 = int.Parse(txtSoThapPhan.Text);

            Console.WriteLine("So nhi phan: " + Convert.ToString(soTP1, 2));
        }
    }
}
