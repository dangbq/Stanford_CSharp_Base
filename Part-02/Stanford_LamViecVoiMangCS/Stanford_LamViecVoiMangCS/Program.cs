using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stanford_LamViecVoiMangCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /*
            //Ví dụ 1: Khai báo 1 mảng số nguyên gồm 3 phần tử
            int[] a = new int[3];

            //Gán các giá trị cho các phần tử
            a[0] = 2;
            a[1] = 5;
            a[2] = 6;

            Console.WriteLine("Giá trị của phần tử 2 là: " + a[1]);
            Console.WriteLine("Giá trị của phần tử 3 là: " + a[2]);

            Console.WriteLine("Các phần tử của mảng là: ");
            for(int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "\t");
            }

            Console.WriteLine("");

            //Ví dụ 2: Khai báo 1 mảng số thực gồm n phần tử sau đó nhập thông tin từ bàn phím rồi in chúng ra màn hình
            //Khai báo biến
            int n = 0;

            Console.Write("Nhập mảng gồm n phần tử với n = ");
            n = int.Parse(Console.ReadLine());

            //Khai báo 1 biến mảng
            float[] a1 = new float[n];

            Console.WriteLine("Nhập các phần tử cho mảng: ");

            for(int i = 0; i < n; i++)
            {
                Console.Write("a1[" + i + "] = ");
                //Lấy nội dung từ bàn phím sau đó gán cho phần tử tương ứng với vị trí i
                a1[i] = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("Các phần tử của mảng {0} phần tử là: ", n);
            for(int i = 0; i < a1.Length; i++)
            {
                Console.Write(a1[i] + "\t");
            }
            */


            //Ví dụ 3: Khai báo 1 mảng số nguyên gồm 3 dòng và 2 cột
            /*
             * a00  a01
             * a10  a11
             * a20  a21*/
            /*
            //Khai báo biến
            int[,] a2 = new int[3, 2];
            //Gán giá trị cho dòng 1
            a2[0, 0] = 2;
            a2[0, 1] = 3;
            //Dòng 2
            a2[1, 0] = 5;
            a2[1, 1] = 6;
            //Dòng 3
            a2[2, 0] = 8;
            a2[2, 1] = 9;

            Console.WriteLine("Dòng 2 cột 1 là: " + a2[1, 0]);
            Console.WriteLine("Các phần tử của mảng 2 chiều 3x2: ");
            //Duyệt dòng
            for(int i = 0; i < a2.GetLength(0); i++)//GetLength(0) = 3
            {
                
                //Duyệt cột
                for(int j = 0; j < a2.GetLength(1); j++)//GetLength(1) = 2
                {
                    Console.Write(a2[i, j] + "\t");
                }

                //hết cột thì mới xuống dòng
                Console.WriteLine("");
            }
            */

            //Ví dụ 4: Sử dụng mảng jagged
            int[][] arrJag = new int[3][];

            Console.WriteLine("Số phần tử: " + arrJag.GetLength(0));

            //Gán từng phần tử
            arrJag[0] = new int[2] { 3, 4 };
            arrJag[1] = new int[3] { 5, 6, 7 };
            arrJag[2] = new int[4] { 8, 9, 0, 1 };

            Console.WriteLine("Các phần tử của mảng jagged: ");
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < arrJag[i].Length; j++)
                {
                    Console.Write(arrJag[i][j] + "\t");
                }
                Console.WriteLine("");
            }    
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
