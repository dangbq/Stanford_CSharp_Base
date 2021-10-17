using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stanford_BaiTapCauTrucIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /*
            //Bài 3: Viết chương trình nhập vào số giây từ 0 tới 68399, đổi số giây này thành dạng
            //[giờ: phút:giây], mỗi thành phần là một số nguyên có 2 chữ số.

            //Khai báo biến
            int soGiay = 0, gio, phut, giay, temp = 0;
            NhapLai:
            Console.Write("Nhập vào số giây cần chuyển = ");

            soGiay = int.Parse(Console.ReadLine());

            if(soGiay > 68399)//True
            {
                Console.WriteLine("Bạn cần phải nhập số giây trong khoảng 0->68399");
                goto NhapLai;//Nhảy đến nhãn có tên NhapLai
            }

            //Chuyển sang giờ, phút, giây
            gio = soGiay / 3600;
            
            temp = soGiay% 3600;

            phut = temp / 60;

            giay = temp % 60;

            if(gio < 10)
            {
                Console.Write("0");
            }
            Console.Write(gio + ":");
            if (phut < 10)
            {
                Console.Write("0");
            }
            Console.Write(phut + ":");
            if (giay < 10)
            {
                Console.Write("0");
            }
            Console.WriteLine(giay);
           

            //Bài 2: Viết chương trình nhập vào 1 số nguyên, hiển thị số đó dưới hệ 8 và hệ 16
            //Khai báo biến
            int soNguyen = 0;

            Console.Write("Nhập số nguyên cần chuyển = ");

            soNguyen = int.Parse(Console.ReadLine());


            Console.WriteLine("Số dạng octal là: {0}", Convert.ToString(soNguyen, 8));

            Console.WriteLine("Số dạng hexal là: {0}", Convert.ToString(soNguyen, 16));
             */
            //Bài 4: Viết chương trình nhập vào 4 số nguyên, Hiển thị ra số lớn nhất và nhỏ nhất. Ví dụ: nhập vào 4 số 1,2,3,4 thì kết quả là
            //Số lớn nhất là: 4
            //Số nhỏ nhất là: 1
            int so1 = 0, so2 = 0, so3 = 0, so4 = 0, max = 0, min = 0;

            Console.Write("Nhập số 1 = ");
            so1 = int.Parse(Console.ReadLine());
            Console.Write("Nhập số 2 = ");
            so2 = int.Parse(Console.ReadLine());
            Console.Write("Nhập số 3 = ");
            so3 = int.Parse(Console.ReadLine());
            Console.Write("Nhập số 4 = ");
            so4 = int.Parse(Console.ReadLine());
            //Gán giá trị max, min ban đầu
            max = so1;
            min = so1;

            if(so2 > max)
            {
                max = so2;
            }  
            
            if(so3 > max)
            {
                max = so3;
            }   
            
            if(so4 > max)
            {
                max = so4;
            } 
            
            if(so2 < min)
            {
                min = so2;
            }  
            
            if(so3 < min)
            {
                min = so3;
            }  
            
            if(so4 < min)
            {
                min = so4;
            }

            Console.WriteLine("Giá trị lớn nhất là: {0}", max);
            Console.WriteLine("Giá trị nhỏ nhất là: {0}", min);
        }
    }
}
