using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stanford_BaiTapCauTrucCS_0110
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Bài 9: Viết chương trình nhập vào 1 ký tự bất kỳ từ bàn phím, kiểm tra xem ký tự đó có nằm trong khoảng từ ‘a’ tới ‘z’ không.

            //Khai báo biến
            char kiTu;

            Console.Write("Nhập kí tự là: ");

            kiTu = Console.ReadLine().ToCharArray()[0];

            if(kiTu >= 97 && kiTu <= 122)
            {
                Console.WriteLine("Kí tự hoa của {0} là: {1}", kiTu, kiTu.ToString().ToUpper());
            }    
            else
            {
                Console.WriteLine("Không phải kí tự trong khoảng a-z");
            }

            Console.WriteLine("I Love You");

        }
    }
}
