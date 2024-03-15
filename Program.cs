using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_03_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap vao so hang n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Loai tam giac");
            Console.WriteLine("tam giac vuong dung nhap vao so 1");
            Console.WriteLine("tam giac vuong nguoc nhap vao so 2");
            Console.WriteLine("tam giac vuong dung nhap vao so 3");
            int type = int.Parse(Console.ReadLine());
            if (type != 1 && type != 2 && type != 3 || n <= 0) Console.WriteLine("So khong hop le");
            else
            {
                switch (type)
                {
                    case 1:
                        for (int i = 1; i <= n; i++)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write("*");
                                if (j == i) Console.WriteLine();
                            }
                        }
                        break;
                    case 2:
                        for (int i = n; i > 0; i--)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write("*");
                                if (j == i) Console.WriteLine();
                            }
                        }
                        break;
                    case 3:
                        for (int i = 1; i <= n; i++)
                        {
                            for (int j = 1; j <= 2 * n - 1; j++)
                            {
                                if (j == 2 * n - 1 && i != n) Console.WriteLine(); //Xuong hang khi con tro den cuoi hang ngoai tru dong cuoi cung
                                else if (j == (n + 1) - i || j == (n - 1) + i) Console.Write("*");//Nhap * vao 2 canh ben                                
                                else if ((j - (n + 1 - i)) % 2 == 0 && n + 1 - i < j && j < n - 1 + i) Console.Write("*");//Kiem tra so j co lon hon chan lan so dau hang khong de nhap * vao canh day
                                else Console.Write(" ");
                            }
                        }

                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
