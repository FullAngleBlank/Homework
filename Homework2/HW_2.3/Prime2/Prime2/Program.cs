using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.WriteLine("请输入筛选的范围：n~m");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            Sieve(ref n,ref m);
            Console.ReadKey();
        }

        static void Sieve(ref int n, ref int m)
        {
            int[] Is_Prime;
            Is_Prime = new int[10000];
            int i, j;
            for(i = 2; i <= m; i++)
            {
                Is_Prime[i] = 1;
            }
            Is_Prime[0] = Is_Prime[1] = 0;
            for(i = 2; i <= m; i++)
            {
                if (Is_Prime[i] == 1)
                {
                    if (i >= n && i <= m) ;
                    Console.WriteLine("{0}", i);
                }
                for (j = 2; j * i <= m; j++)
                    Is_Prime[j * i] = 0;
            }
        }
    }
}
