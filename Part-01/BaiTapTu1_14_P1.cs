using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stanford_BaiTapCauTrucLTCS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thiết lập tiếng việt có dấu
            Console.OutputEncoding = Encoding.UTF8;
            /*
            //Bài	tập	1: Viết câu lệnh khai báo biến để lưu các giá trị sau:
            //− Tuổi của một người − Số lượng cây trong thành phố
            ushort tuoiNguoi = 20;
            Int64 soLuongCay = 10000;
            //− Độ dài cạnh một tam giác − Khoảng cách giữa các hành tinh
            float canhTamGiac = 12.546456f;
            double khoangCach = 10343464564.56765;
            //− Một chữ số − Nghiệm x của phương trình bậc 1
            char chuSo = '9';
            float nghiemX = 2.4564f;
            //− Một chữ cái − Biệt thức Δ của phương trình bậc 2
            char chuCai = 'A';
            double delta = 25.6678;

            //In thông tin
            Console.WriteLine("Tuổi của người là: " + tuoiNguoi);
            Console.WriteLine("Số lượng cây: " + soLuongCay);
            Console.WriteLine("Cạnh tam giác: {0:N2}", canhTamGiac);
            Console.WriteLine("Khoảng cách: {0:N2}", khoangCach);
            Console.WriteLine("Chữ số: {0}", chuSo);
            Console.WriteLine("Nghiệm x = {0:N2}", nghiemX);
            Console.WriteLine("Chữ cái: {0}", chuCai);
            Console.WriteLine("Delta = {0:N2}", delta);

            //Bài	tập	2: Viết câu lệnh nhập vào 4 giá trị lần lượt là số thực, nguyên, nguyên dài và kí
            //tự.In ra màn hình các giá trị này để kiểm tra
            //Khai báo biến
            float soThuc = 0;
            short soNguyen = 0;
            long nguyenDai = 0;
            char kiTu;

            Console.Write("Nhập số thực = ");

            soThuc = float.Parse(Console.ReadLine());

            Console.Write("Nhập số nguyên = ");
            soNguyen = short.Parse(Console.ReadLine());

            Console.Write("Nhập số nguyên dài = ");
            nguyenDai = long.Parse(Console.ReadLine());

            Console.Write("Nhập kí tự = ");
            //Đưa chuỗi về dạng mảng kí tự và lấy phần tử đầu tiên
            kiTu = Console.ReadLine().ToCharArray()[0];

            //In thông tin
            Console.WriteLine("Số thực là: {0:N2}", soThuc);
            Console.WriteLine("Số nguyên là: {0}", soNguyen);
            Console.WriteLine("Số nguyên dài là: {0}", nguyenDai);
            Console.WriteLine("Kí tự: " + kiTu);

            //Bài	tập	4: Viết chương trình nhập vào một kí tự. In ra kí tự đó và mã ascii của nó
            Console.WriteLine("Kí tự {0} có mã ascii là: {1}", kiTu, (int)kiTu);//Exception
            

            //Bài 6
            //Khai báo biến
            double cau6a = 0, cau6b = 0;

            cau6a = Math.Sqrt(3.0 + Math.Sqrt(3.0 + Math.Sqrt(3.0)));
            cau6b = 1 / (2.0 + 1 / (2.0 + 1 / 2.0));

            Console.WriteLine("Kết quả câu 6a = {0}", cau6a);
            Console.WriteLine("Kết quả câu 6b = {0}", cau6b);

            //Bài 7
            double a = 0, b = 0, c = 0, cau7a = 0, cau7b = 0, cau7c = 0, cau7d = 0;

            Console.Write("Nhập số a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập số b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập số c = ");
            c = Convert.ToDouble(Console.ReadLine());

            if(c != 0)
                cau7a = Math.Pow(a, 2) - 2 * b + (a * b) / c;

            if(a != 0)
                cau7b = (b * b - 4 * a * c) / (2 * a);

            cau7c = 3 * a - Math.Pow(b, 3) - 2 * Math.Sqrt(c);

            if(b != 0 && c != 0)
                cau7d = (a * a) / b - (4 * a) / (b * c) + 1;

            if(cau7d >= 0)
            {
                cau7d = Math.Sqrt(cau7d);
            }

            Console.WriteLine("Kết quả câu 7a = {0:N3}", cau7a);
            Console.WriteLine("Kết quả câu 7b = {0:N3}", cau7b);
            Console.WriteLine("Kết quả câu 7c = {0:N3}", cau7c);
            Console.WriteLine("Kết quả câu 7d = {0:N3}", cau7d);

            //Bài	tập	9: In ra trung bình cộng, trung bình nhân của 3 số được nhập vào từ bàn phím.
            double trungBinhCong = 0, trungBinhNhan = 0;

            trungBinhCong = (a + b + c) / 3;
            trungBinhNhan = (a * b * c);
            trungBinhNhan = Math.Pow(trungBinhNhan, 1 / 3.0);
            Console.WriteLine("Trung bình cộng là: " + trungBinhCong);
            Console.WriteLine("Trung bình nhân là: " + trungBinhNhan);

            //Bài tập 12: Tính diện tích và thể tích của hình cầu bán kính R theo công thức:
            //Khai báo 1 hằng số
            const double PI = 3.14;

            //Khai báo biến
            double R = 0, V = 0, S = 0;

            Console.Write("Nhập giá trị của bán kính R = ");

            R = Convert.ToDouble(Console.ReadLine());

            //Tính toán
            S = 4 * PI * R * R;
            V = (R * S) / 3;

            Console.WriteLine("Diện tích của S = {0:N2}", S);
            Console.WriteLine("Thể tích = {0:N2}", V);

            //Bài tập	13: Nhập vào 4 chữ số. In ra tổng của 4 chữ số này và chữ số hàng chục, hàng
            // đơn vị của tổng(ví dụ 4 chữ số 3, 1, 8, 5 có tổng là 17 và chữ số hàng chục là 1 và hàng đơn vị là 7, cần in ra 17, 1, 7)
            int so1 = 0, so2 = 0, so3 = 0, so4 = 0, tong = 0, chuc = 0, donVi = 0;

            Console.Write("Nhập số 1 = ");
            so1 = int.Parse(Console.ReadLine());
            Console.Write("Nhập số 2 = ");
            so2 = int.Parse(Console.ReadLine());
            Console.Write("Nhập số 3 = ");
            so3 = int.Parse(Console.ReadLine());
            Console.Write("Nhập số 4 = ");
            so4 = int.Parse(Console.ReadLine());

            tong = so1 + so2 + so3 + so4;
            chuc = tong / 10;
            donVi = tong % 10;

            Console.WriteLine("Tổng 4 số là: " + tong);
            Console.WriteLine("Hàng chục: " + chuc);
            Console.WriteLine("Hàng đơn vị: " + donVi);
            */
            //Bài	tập	14: Nhập vào một số nguyên (có 4 chữ số). In ra tổng của 4 chữ số này và chữ số đầu, chữ số cuối(ví dụ số 3185 có tổng các chữ số là 17, đầu và cuối là 3 và 5, kết quả in ra là: 17, 3, 5)
            //Khai báo biến
            int so4ChuSo = 0, nghin = 0, tram = 0, chuc = 0, donVi = 0, tong = 0, temp = 0;
            NhapLai:
            Console.Write("Nhập số 4 chữ số = ");
            so4ChuSo = int.Parse(Console.ReadLine());

            if(so4ChuSo >= 1000 && so4ChuSo <= 9999)
            {
                nghin = so4ChuSo / 1000;
                temp = so4ChuSo % 1000;
                tram = temp / 100;
                temp = temp % 100;
                chuc = temp / 10;
                donVi = temp % 10;

                tong = nghin + tram + chuc + donVi;
                Console.WriteLine("Hàng nghìn = {0}", nghin);
                Console.WriteLine("Hàng đơn vị = {0}", donVi);
                Console.WriteLine("Tổng các chữ số là: " + tong);
            }  
            else
            {
                Console.WriteLine("Bạn cần phải nhập số có 4 chữ số");
                goto NhapLai;
            }

            //Dừng màn hình đến khi nhấn phím tiếp theo
            Console.ReadKey();
        }
    }
}
