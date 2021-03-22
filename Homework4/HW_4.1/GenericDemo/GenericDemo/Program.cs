using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> intList = new GenericList<int>();
            for (int i = 0; i < 9; i++) {
                intList.Add(i);
            }

            intList.MyForeach(x=>Console.WriteLine(x));

            // 最大值
            int max = int.MinValue;
            intList.MyForeach(x => max = x > max ? x : max);
            Console.WriteLine($"MAX: {max}");

            // 最小值
            int min = int.MaxValue;
            intList.MyForeach(x => min = x < min ? x : min);
            Console.WriteLine($"MIN: {min}");

            // 求和
            int sum = 0;
            intList.MyForeach(x => sum += x);
            Console.WriteLine($"SUM: {sum}");

            Console.ReadKey();
        }
        
    }
}
