using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个大于1的正整数：");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("该数的所有素数因子有：");
            for(int i = 2; i <= num;)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("{0} ", i);
                    num /= i;  //除掉其他一个因子，使得循环次数减少，提高效率。
                }
                else
                    i++;
            }
            Console.ReadKey();
        }
    }
}
