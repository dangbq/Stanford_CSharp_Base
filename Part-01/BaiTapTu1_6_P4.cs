using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stanford_CauTrucLapTrinhCS_p2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Thiết lập hiển thị tiếng việt có dấu
            Console.OutputEncoding = Encoding.Unicode;
            /*
            //Ví dụ 1: Nhập vào tháng hiện thời kiểu số từ bàn phím rồi in ra dạng chuỗi
            int thang = 0;

            string strThang = "";


            Console.Write("Nhập tháng hiện tại là: ");

            thang = int.Parse(Console.ReadLine());

            //Sử dụng switch case
            switch(thang)
            {
                case 1: strThang = "Tháng một";
                    break;
                case 2:
                    strThang = "Tháng hai";
                    break;
                case 3:
                    strThang = "Tháng ba";
                    break;
                case 4:
                    strThang = "Tháng tư";
                    break;
                case 5:
                    strThang = "Tháng năm";
                    break;
                case 6:
                    strThang = "Tháng sáu";
                    break;
                case 7:
                    strThang = "Tháng bẩy";
                    break;
                case 8:
                    strThang = "Tháng tám";
                    break;
                case 9:
                    strThang = "Tháng chín";
                    break;
                case 10:
                    strThang = "Tháng mười";
                    break;
                case 11:
                    strThang = "Tháng mười một";
                    break;
                case 12:
                    strThang = "Tháng mười hai";
                    break;
                default:
                    strThang = "Không có tháng này";
                    break;
            }

            //Hiển thị kết quả
            Console.WriteLine("Tháng hiện tại là: " + strThang);
            

            Console.WriteLine("Sử dụng vòng lặp while: ");

            int i = 1;
            while(i < 100)
            {
                Console.WriteLine("I Love You " + i);
                i++;
            }

            Console.WriteLine("Sử dụng vòng lặp do while: ");
            do
            {
                Console.WriteLine("Giá trị của i = " + i);
                i++;
            }
            while (i <= 150);

            Console.WriteLine("Sử dụng vòng lặp for:");
            for(int j = 80; j <=90; j+=2)
            {
                Console.WriteLine(j);
            }
            
            //Bài tập 4 - P4
            //Khai báo biến
            int N = 0;
            double S1 = 0, S2 = 0;

            Console.Write("Nhập giá trị N = ");

            N = int.Parse(Console.ReadLine());

            //Sử dụng vòng lặp để tính toán
            for(int i = 1; i<= N; i++)
            {
                S1 += i;//S1 = S1 + i
                S2 += i * i;
            }

            S1 = S1 / N;
            S2 = Math.Sqrt(S2);

            Console.WriteLine("Giá trị của S1 = {0:N2}", S1);
            Console.WriteLine("Giá trị của S2 = {0:N2}", S2);
            
            //Bài 5: In ra màn hình các số có 2 chữ số sao cho tích của 2 chữ số này bằng 2 lần tổng của
            //2 chữ số đó(ví dụ số 36 có tích 3 * 6 = 18 gấp 2 lần tổng của nó là 3 + 6 = 9)

            //Khai báo biến
            int tong = 0, tich = 0, chuc = 0, donVi = 0;

            Console.WriteLine("Các số 2 chữ số có tích bằng 2 lần tổng là:");

            for(int i = 10; i <= 99; i++)
            {
                chuc = i / 10;
                donVi = i % 10;
                tong = chuc + donVi;
                tich = chuc * donVi;

                if(tich == 2*tong)
                {
                    Console.WriteLine(i);
                }
            }
            
            //Bài 3: Nhập vào tuổi cha và tuổi con hiện nay sao cho tuổi cha lớn hơn 2 lần tuổi con. Tìm xem bao nhiêu năm nữa tuổi cha sẽ bằng đúng 2 lần tuổi con(ví dụ 30 và 12, sau 6 năm
            //nữa tuổi cha là 36 gấp đôi tuổi con là 18)
            //Khai báo biến
            int tuoiCha = 0, tuoiCon = 0, soNam = 0;

            do
            {
                Console.Write("Nhập tuổi cha = ");
                tuoiCha = int.Parse(Console.ReadLine());
                Console.Write("Nhập tuổi con = ");
                tuoiCon = int.Parse(Console.ReadLine());
            }
            while (tuoiCha <= (2 * tuoiCon));

            soNam = tuoiCha - 2*tuoiCon;

            tuoiCha = tuoiCha + soNam;
            tuoiCon = tuoiCon + soNam;

            Console.WriteLine("Số năm tuổi cha bằng 2 lần tuổi con là: " + soNam);
            Console.WriteLine("Tuổi cha là: " + tuoiCha);
            Console.WriteLine("Tuổi con là: " + tuoiCon);
            

            //Khai báo biến
            double S1 = 0, S2 = 0;
            int N = 0;

            while(S1 < 2.101999)
            {
                N++;
                S1 += 1 / (2.0 * N - 1);
            }

            Console.WriteLine("Giá trị N thỏa mãn điều kiện là: " + (N - 1));

            do
            {
                N++;
                S2 = Math.Exp(N) - 1999 * Math.Log10(N);
            }
            while (S2 < 2000);

            Console.WriteLine("Giá trị N thỏa mãn điều kiện là: " + (N - 1));
            
            //Bài 1 - P4
            char kiTu;

            Console.Write("Nhập kí tự là: ");
            //Lấy kí tự đầu tiên trong mảng
            kiTu = Console.ReadLine().ToCharArray()[0];


            if((kiTu >= 65 && kiTu <= 90) || (kiTu >= 97 && kiTu <= 122))
            {
                Console.WriteLine("Dây là kí tự chữ");
            }
            else
            {
                Console.WriteLine("Không phải kí tự chữ");
            }*/

            double x = 0, fxa = 0, fxb = 0;

            Console.Write("Nhập giá trị x = ");

            x = double.Parse(Console.ReadLine());

            if(x > 0)
            {
                fxa = 3 * x + Math.Sqrt(x);
            }
            else
            {
                fxa = Math.Exp(x) + 4;
            }

            if(x >= 1)
            {
                fxb = Math.Sqrt(x * x + 1);
            }
            else
            {
                if(x >-1 && x < 1)
                {
                    fxb = 3 * x + 5;
                }
                else
                {
                    fxb = Math.Pow(x, 2) + 2 * x - 1;
                }
            }

            Console.WriteLine("Giá trị fxa = {0:N2}", fxa);
            Console.WriteLine("Giá trị fxb = {0:N2}", fxb);

            //Bài 2 - P3: Viết chương trình nhập vào 1 số nguyên, hiển thị số đó dưới hệ 8 và hệ 16.

            //Khai báo biến
            int soThapPhan = 0;
            Console.Write("Nhập số thập phân = ");
            soThapPhan = int.Parse(Console.ReadLine());

            Console.WriteLine("Hệ số hex là: " + soThapPhan.ToString("x"));

            Console.WriteLine("Hệ số hex là: " + Convert.ToString(soThapPhan, 16));
            Console.WriteLine("Hệ số octal là: " + Convert.ToString(soThapPhan, 8));
            //Dừng màn hình đến khi nhấn phím tiếp theo
            Console.ReadKey();
        }
    }
}
