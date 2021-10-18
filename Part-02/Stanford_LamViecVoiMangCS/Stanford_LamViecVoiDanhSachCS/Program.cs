using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stanford_LamViecVoiDanhSachCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Khai báo 1 danh sách chứa tên ngôn ngữ
            List<string> lstNgonNgu = new List<string>();

            Console.WriteLine("Số phần tử trong danh sách: {0}", lstNgonNgu.Count);
            //Thêm vào danh sách
            lstNgonNgu.Add("C#");
            Console.WriteLine("Số phần tử trong danh sách: {0}", lstNgonNgu.Count);
            lstNgonNgu.Add("Java");
            lstNgonNgu.Add("Xamarin");
            Console.WriteLine("Số phần tử trong danh sách: {0}", lstNgonNgu.Count);
            lstNgonNgu.Add("Python");
            Console.WriteLine("Số phần tử trong danh sách: {0}", lstNgonNgu.Count);

            //Chèn 1 phần tử vào vị trí 2
            lstNgonNgu.Insert(2, "Kotlin");

            //Xóa thông tin
            lstNgonNgu.Remove("Xamarin");

            //In danh sách
            Console.WriteLine("Các ngôn ngữ lập trình là: ");
            foreach(string ngonNgu in lstNgonNgu)
            {
                Console.WriteLine(ngonNgu);
            }    

            if(lstNgonNgu.Contains("Python"))//True
            {
                Console.WriteLine("Có ngôn ngữ Python");
            }

            //Khai báo 1 ds
            ArrayList arrThongTin = new ArrayList();

            //Thêm thông tin vào danh sách
            arrThongTin.Add("Stanford - Dạy lập trình");
            arrThongTin.Add(20);
            arrThongTin.Add(DateTime.Now);

            Console.WriteLine("Các phần tử của danh sách:");
            foreach(object giaTri in arrThongTin)
            {
                Console.WriteLine(giaTri);
            }

            //Làm việc với chuỗi
            string strThongTinA = "Stanforg";
            string strThongTinB = "Stanford";

            int ketQua = strThongTinA.CompareTo(strThongTinB);
            Console.WriteLine("Kết quả so sánh: " + ketQua);

            string ngayThang = string.Format("Hà nội, ngày {0} tháng {1} năm {2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            Console.WriteLine(ngayThang);

            string strData = "Stanford - Dạy kinh nghiệm lập trình";

            int idx = strData.IndexOf('t');
            Console.WriteLine("Vị trí đầu tiên của kí tự t là: " + idx);

            int ldx = strData.LastIndexOf('t');
            Console.WriteLine("Vị trí cuối của kí tự t là: " + ldx);

            string tenVietTat = strData.Substring(0, 9);

            Console.WriteLine("Tên viết tắt là: " + tenVietTat);
            Console.WriteLine("Thay t thành T: " + strData.Replace('t', 'T'));

            strData = "60;50;30;80";

            string[] arr = strData.Split(';');

            Console.WriteLine("Các chuỗi số lấy được từ việc chia chuỗi: ");

            foreach(string giaTri in arr)
            {
                Console.WriteLine(giaTri);
            }

            Console.WriteLine("Chữ hoa: " + tenVietTat.ToUpper());
            Console.WriteLine("Chữ thường: " + tenVietTat.ToLower());
            strData = "Stanford";

            /*for (int i = 1; i <= 1000; i++)
            {
                strData += i + "-";
            }
            */
            //Stanford
            //Stanford1-
            //Stanford1-2-
            StringBuilder builder = new StringBuilder("Stanford");

            for (int i = 1; i <= 1000; i++)
            {
                builder.Append(i + "-");
            }

            Console.WriteLine(builder.ToString());

            Console.ReadKey();
        }
    }
}
