using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stanford_BaiTapCauTrucCS_0610
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /*
            //Bài 2- P4
            //Khai báo biến
            double fa = 0, fb = 0, x = 0;

            Console.Write("Nhập giá trị x = ");

            x = double.Parse(Console.ReadLine());

            if(x > 0)
            {
                fa = 3 * x + Math.Sqrt(x);
            }    
            else
            {
                fa = Math.Exp(x) + 4;
            }

            Console.WriteLine("Kết quả câu 2a = {0:N3}", fa);

            if(x >= 1)
            {
                fb = Math.Sqrt(x * x + 1);
            }    
            else
            {
                if(x>-1 && x < 1)
                {
                    fb = 3 * x + 5;
                }
                else
                {
                    fb = Math.Pow(x, 2) + 2 * x - 1;
                }    
            }

            Console.WriteLine("Kết quả câu 2b = {0:N3}", fb);

            //Bài 3: Nhập vào tuổi cha và tuổi con hiện nay sao cho tuổi cha lớn hơn 2 lần tuổi con. Tìm xem bao nhiêu năm nữa tuổi cha sẽ bằng đúng 2 lần tuổi con(ví dụ 30 và 12, sau 6 năm nữa tuổi cha là 36 gấp đôi tuổi con là 18).

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

            soNam = tuoiCha - (2 * tuoiCon);

            tuoiCha += soNam;
            tuoiCon += soNam;
            Console.WriteLine("Số năm mà tuổi cha bằng 2 lần tuổi con là: " + soNam);
            Console.WriteLine("Tuổi cha = " + tuoiCha);
            Console.WriteLine("Tuổi con = " + tuoiCon);

            //Bài tập 4
            int N = 0;
            double S1 = 0, S2 = 0;

            Console.Write("Nhập dãy số có N = ");
            N = int.Parse(Console.ReadLine());

            //Duyệt vòng lặp để tính toán
            for(int i = 1; i <= N; i++)
            {
                S1 += i;

                S2 += i * i;
            }

            S1 = S1 / N;
            S2 = Math.Sqrt(S2);

            Console.WriteLine("Giá trị S1 = {0}", S1);
            Console.WriteLine("Giá trị của S2 = {0}", S2);
           

            //Bài 5: In ra màn hình các số có 2 chữ số sao cho tích của 2 chữ số này bằng 2 lần tổng của 2 chữ số đó(ví dụ số 36 có tích 3 * 6 = 18 gấp 2 lần tổng của nó là 3 + 6 = 9).

            //Khai báo biến
            int hangChuc = 0, donVi = 0, tong = 0, tich = 0;

            Console.WriteLine("Các số 2 chữ số mà có tích bằng 2 lần tổng 2 chữ số đó là: ");

            for(int i=10; i<=99; i++)
            {
                hangChuc = i / 10;
                donVi = i % 10;
                tong = hangChuc + donVi;
                tich = hangChuc * donVi;

                if(tich == 2*tong)
                {
                    Console.WriteLine(i);
                }    
            }
             */
            //Bài tập 6 - P4
            //Khai báo biến
            int n = 0;
            double S1 = 0, S2 = 0;

            do
            {
                n++;
                S1 += 1 / (2.0 * n - 1);
            }
            while (S1 < 2.101999);//true

            Console.WriteLine("Giá trị N lớn nhất để thỏa mãn là: {0}", (n - 1));

            n = 0;
            do
            {
                n++;
                S2 = Math.Exp(n) - 1999 * Math.Log10(n);
            }
            while (S2 < 2000);//true

            Console.WriteLine("Giá trị N lớn nhất để thỏa mãn là: {0}", (n - 1));

            //Dừng đến khi nhấn phím tiếp theo
            Console.ReadKey();
        }
    }
}
