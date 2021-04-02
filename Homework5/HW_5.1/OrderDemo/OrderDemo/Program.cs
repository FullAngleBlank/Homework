using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService os = new OrderService();
            bool flag = true;
            while (flag)
            {
                ShowMenu();
                string chosen = Console.ReadLine();
                switch (chosen)
                {
                    case "1": os.AddOrder(); break;
                    case "2": os.DelOrder(); break;
                    case "3": {
                            Console.WriteLine("输入1根据订单金额查询订单，输入2根据客户名查询订单");
                            int i = Convert.ToInt32(Console.ReadLine());
                            os.SearchOrder(i);break;
                        }
                    case "4": os.ShowOrder(); break;
                    case "5": os.order.Sort(); break;
                    case "6": flag = false; break;
                    default: Console.WriteLine("输入错误"); break;
                }
            }
        }

        static void ShowMenu() {
            Console.WriteLine("输入1增加订单");
            Console.WriteLine("输入2删除订单");
            Console.WriteLine("输入3查询订单");
            Console.WriteLine("输入4显示所有订单");
            Console.WriteLine("输入5根据订单号为订单排序");
            Console.WriteLine("输入6退出");
        }
    }
}
