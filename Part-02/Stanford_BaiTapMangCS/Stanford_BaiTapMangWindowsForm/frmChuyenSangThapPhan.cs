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
    public partial class frmChuyenSangThapPhan : Form
    {
        public frmChuyenSangThapPhan()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Chuyển từ số nhị phân về thập phân
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChuyenDoi_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            int soThapPhan = 0;
            string strSoNhiPhan = "";

            //Lấy thông tin trên giao diện
            strSoNhiPhan = txtSoNhiPhan.Text;

            //Chuyển từ chuỗi về mảng kí tự
            char[] arr = strSoNhiPhan.ToCharArray();

            //Duyệt từng phần tử
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == '1')//Nếu hệ bằng 1
                {
                    soThapPhan += (int)Math.Pow(2, arr.Length - 1 - i);
                }    
            }

            //Hiển thị lên giao diện
            txtSoThapPhan.Text = "" + soThapPhan;
            txtSoThapPhan.ReadOnly = true;

            //Cách 2: Chuyển về số thập phân
            int soTP = Convert.ToInt16(strSoNhiPhan, 2);

            Console.WriteLine("So thap phan la: " + soThapPhan);
        }
    }
}
