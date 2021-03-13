using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a;
            a = new int[10];
            Console.WriteLine("请输入整数数组中的元素（十个）：");
            for(int i = 0; i<10; i++)
            {
                int input = int.Parse(Console.ReadLine());
                a[i] = input;
            }

            int max = Max_a(a);
            Console.WriteLine("该整数数组中元素的最大值为{0}", max);
            int min = Min_a(a);
            Console.WriteLine("该整数数组中元素的最小值为{0}", min);
            AllAndAverage(a);

            Console.ReadLine();

            
        }

        //求数组中的最大值
        static int Max_a(int[] a)
        {
            int max = a[0];
            for(int i = 1; i < 10; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
            
        }

        //求数组中的最小值
        static int Min_a(int[] a)
        {
            int min = a[0];
            for(int i = 1; i < 10; i++)
            {
                if(a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }

        static void AllAndAverage(int[] a)
        {
            int all = 0;
            double average;
            for (int i = 0; i < 10; i++)
            {
                all += a[i]; 
            }
            average = (double)all / 10;
            Console.WriteLine("该整数数组中元素的和为{0}", all);
            Console.WriteLine("该整数数组的平均值为{0}", average);

        }
    }
}