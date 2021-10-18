using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stanford_BaiTapMangCS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thiết lập hiển thị tiếng việt
            Console.OutputEncoding = Encoding.Unicode;

            //Bài tập 1: Nhập vào dãy n số thực. Tính tổng dãy, trung bình dãy, tổng các số âm, dương và tổng các số ở vị trí chẵn, vị trí lẻ trong dãy.
            //Khai báo biến
            double tongDay = 0, trungBinh = 0, tongAm = 0, tongDuong = 0, tongChan = 0, tongLe = 0;

            int n = 0;

            Console.Write("Nhập mảng số thực gồm n phần tử với n = ");

            n = int.Parse(Console.ReadLine());

            //Khai báo mảng
            double[] arr = new double[n];

            Console.WriteLine("Nhập các phần tử cho mảng: ");

            for(int i=0; i < n; i++)
            {
                Console.Write("arr[" + i + "] = ");
                arr[i] = double.Parse(Console.ReadLine());
            }  
            
            //Tính toán
            for(int i= 0; i < arr.Length; i++)
            {
                tongDay += arr[i];
                if(arr[i] >= 0)
                {
                    tongDuong += arr[i];
                }
                else
                {
                    tongAm += arr[i];
                }

                if(i%2 == 0)//Nếu là vị trí chẵn
                {
                    tongChan += arr[i];
                }    
                else
                {
                    tongLe += arr[i];
                }    
            }

            trungBinh = tongDay / n;

            //In thông tin ra màn hình
            Console.WriteLine("Tổng dãy là: " + tongDay);
            Console.WriteLine("Trung bình dãy là: " + trungBinh);
            Console.WriteLine("Tổng dương là: " + tongDuong);
            Console.WriteLine("Tổng âm là: " + tongAm);
            Console.WriteLine("Tổng vị trí chẵn là: " + tongChan);
            Console.WriteLine("Tổng vị trí lẻ là: " + tongLe);

            //Bài tập 2: Tìm và chỉ ra vị trí xuất hiện đầu tiên của phần tử x trong dãy.
            //Khai báo biến
            double x = 0;

            Console.Write("Nhập giá trị x = ");
            x = double.Parse(Console.ReadLine());

            //Duyệt vòng lặp để tìm x
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == x)//Nếu có phần trong dãy bằng x
                {
                    Console.WriteLine("Vị trí đầu tiên của x trong dãy là: " + (i + 1));
                    break;
                }    
            }

            //Bài tập 3: Nhập vào dãy n số. Hãy in ra số lớn nhất, bé nhất của dãy
            double max = arr[0], min = arr[0];

            //Duyệt từng phần tử trong dãy
            for(int i=1; i < arr.Length; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }
                
                if(arr[i] < min)
                {
                    min = arr[i];
                }    
            }

            //In kết quả
            Console.WriteLine("Giá trị lớn nhất của dãy là: " + max);
            Console.WriteLine("Giá trị nhỏ nhất của dãy là: " + min);

            //Bài tập 4: Nhập vào dãy số. In ra dãy đã được sắp xếp tăng dần, giảm dần

            double temp = 0;
            //Sắp xếp tăng dần
            for(int i = 0; i < arr.Length-1; i++)
            {
                //Duyệt để so sánh
                for(int j= i + 1; j < arr.Length; j++)
                {
                    if(arr[j] < arr[i])//True
                    {
                        //Thực hiện hoán đổi
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }    
                }

                //In kết quả mỗi lần sắp xếp
                Console.WriteLine("Lần " + i);
                for (int k = 0; k < arr.Length; k++)
                {
                    Console.Write(arr[k] + "\t");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Dãy sắp xếp theo thứ tự tăng dần: ");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }

            Console.WriteLine("");

            //Bài 5: Viết chương trình nhập vào 1 mảng gồm N phần tử, với N được nhập từ bàn phím.
            //Tách mảng đã cho thành 2 mảng, 1 mảng chứa các số âm, 1 mảng chứa các số dương. In ra 3 mảng trên.

            //Khai báo 2 mảng
            double[] arrDuong = new double[n];
            double[] arrAm = new double[n];

            int duong = 0, am = 0;

            //Duyệt vòng lặp để phân loại
            for(int i = 0; i< arr.Length; i++)
            {
                if(arr[i] >= 0)
                {
                    arrDuong[duong] = arr[i];
                    duong++;
                }    
                else
                {
                    arrAm[am] = arr[i];
                    am++;
                }    
            }

            Console.WriteLine("Số lượng số dương: " + duong);
            Console.WriteLine("Các phần tử dương: ");
            for(int i = 0; i< duong; i++)
            {
                Console.WriteLine(arrDuong[i] + "\t");
            }

            Console.WriteLine("Số lượng số âm: " + am);
            Console.WriteLine("Các phần tử âm: ");
            for (int i = 0; i < am; i++)
            {
                Console.WriteLine(arrAm[i] + "\t");
            }
        }
    }
}
