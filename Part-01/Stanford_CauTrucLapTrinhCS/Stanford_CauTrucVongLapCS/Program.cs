using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stanford_CauTrucVongLapCS
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            /*
            //Khai báo biến
            int i = 1;

            Console.WriteLine("Sử dụng vòng lặp while: ");

            while(i <= 100)//True
            {
                Console.WriteLine("I Love You " + i);
                i++;//Tăng i lên 1 đơn vị
            }

            Console.WriteLine("Sử dụng do while: ");

            do
            {
                Console.WriteLine("Giá trị của i là: " + i);
                i++;
            }
            while (i < 150);//True
           
            //Nhập số gồm 4 chữ số
            //Khai báo biến
            int so4ChuSo = 0;

            do
            {
                Console.Write("Nhập số gồm 4 chữ số = ");
                so4ChuSo = int.Parse(Console.ReadLine());
            }
            while (so4ChuSo > 9999 || so4ChuSo < 1000);
            
            Console.WriteLine("Số có 4 chữ số là: " + so4ChuSo);
           
            Console.WriteLine("Sử dụng vòng lặp for: ");

            for(i = 80; i <= 90; i+=2)
            {
                Console.WriteLine(i);
            }
             */
            //Bài 13: Viết chương trình tính tổng bình phương các số lẻ từ 1 tới N. N được nhập từ bàn phím.

            //Khai báo biến
            int N = 0, tongBinhPhuong = 0;

            Console.Write("Nhập số N = ");
            N = int.Parse(Console.ReadLine());

            //Sử dụng vòng lặp để tính toán
            for(int i = 1; i <=N; i+=2)
            {
                tongBinhPhuong += (i * i);
                //tongBinhPhuong = tongBinhPhuong + (i*i)
            }

            Console.WriteLine("Tổng bình phương các số lẻ là: " + tongBinhPhuong);
        }
    }
}
