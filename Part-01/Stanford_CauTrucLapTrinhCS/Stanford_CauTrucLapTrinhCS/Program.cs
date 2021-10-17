using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stanford_CauTrucLapTrinhCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /*
            //Ví dụ 1: Nhập vào chiều cao của Hoàng và Tài sau đó kiểm tra xem ai cao hơn.
            //Khai báo biến
            double hHoang = 0, hTai = 0;

            Console.Write("Nhập chiều cao của bạn Hoàng = ");

            hHoang = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập chiều cao của bạn Tài = ");

            hTai = Convert.ToDouble(Console.ReadLine());

            if(hHoang == hTai)//True
            {
                Console.WriteLine("Chiều cao của Hoàng và Tài là bằng nhau");
            } 
            else//False
            {
                if(hHoang > hTai)//True
                {
                    Console.WriteLine("Chiều cao của Hoàng cao hơn Tài");
                }   
                else//False
                {
                    Console.WriteLine("Chiều cao của Hoàng thấp hơn Tài");
                }    
            }
            */
            //Ví dụ 2: Nhập vào 2 số thực từ bàn phím sau đó tính thương của 2 số đó
            //Khai báo biến
            double a = 0, b = 0, thuong = 0;
            Console.Write("Nhập số a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Nhập số b = ");
            b = double.Parse(Console.ReadLine());

            if(b != 0)//True
            {
                thuong = a / b;
                Console.WriteLine("Thương của {0} và {1} là: {2}", a, b, thuong);
            }  
            else//False
            {
                Console.WriteLine("Bạn phải nhập số b khác 0");
            }    
        }
    }
}
