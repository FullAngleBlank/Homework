using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OrderDemo
{
    //所有订单
    class OrderService   
        {
            public List<Order> order = new List<Order>();

            //展示订单
            public void ShowOrder()
            {

                foreach (Order o in this.order)
                {
                    Console.WriteLine("订单号 客户 日期 总金额");
                    Console.WriteLine("{0} {1} {2} {3}", o.Id, o.Customer, o.Date, o.Money);
                    o.ShowOrderItem();
                }
            }


            //增加订单
            public void AddOrder()          
            {
                try
                {
                    Console.WriteLine("请输入订单编号：");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("请输入客户名称：");
                    string customer = Console.ReadLine();
                    Console.WriteLine("请输入时间：");
                    string date = Console.ReadLine();
                    Order a = new Order(id, customer, date);
                    Console.WriteLine("输入订单项：");
                    bool judge = true;
                    bool same = false;
                    foreach (Order o in this.order)
                    {
                        if (o.Equals(a)) same = true;
                    }
                    if (same) Console.WriteLine("订单号重复");
                    else
                    {
                        while (judge && !same)
                        {
                            Console.WriteLine("请输入物品名称：");
                            string name = Console.ReadLine();
                            Console.WriteLine("请输入购买数量：");
                            int number = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("请输入单价：");
                            double price = Convert.ToDouble(Console.ReadLine());
                            a.AddOrderItem(name, number, price);
                            Console.WriteLine("是否继续添加订单项：(请输入 是 或者 否)");
                            string x = Console.ReadLine();
                        if (x == "否") judge = false;
                        else if (x == "是") continue;
                        else if (x != "否" && x != "是") throw new Exception();
                        }
                        order.Add(a);
                        a.GetAllPrice();
                        Console.WriteLine("建立成功");
                        Console.WriteLine("");
                    }
                }
                catch
                {
                    Console.WriteLine("输入错误");
                }

            }


            //删除订单
            public void DelOrder()           
            {
                try
                {
                    Console.WriteLine("输入订单号删除订单或相应明细：");
                    int id = Convert.ToInt32(Console.ReadLine());
                    int index = 0;
                    foreach (Order o in this.order)
                    {
                        if (o.Id == id) index = this.order.IndexOf(o);
                    }
                    this.order.RemoveAt(index); Console.WriteLine("删除成功");
                    Console.WriteLine("");
            }
                catch
                {
                    Console.WriteLine("输入错误");
                }

            }


            //查询订单
            public void SearchOrder(int i)  
            {
                try
                {
                    switch (i)
                    {
                        case 1:
                            int num;
                            num = Convert.ToInt32(Console.ReadLine());

                            var query1 = from s1 in order
                                         where num == s1.Money
                                         orderby s1.Money
                                         select s1;

                            List<Order> a1 = query1.ToList();

                            foreach (Order b1 in a1)
                            {
                                Console.WriteLine("订单号 客户 日期 总金额");
                                Console.WriteLine("");
                                Console.WriteLine("{0} {1} {2} {3}", b1.Id, b1.Customer, b1.Date, b1.Money);
                                b1.ShowOrderItem();
                            }
                            break;

                        case 2:
                            Console.WriteLine("输入客户名称：");
                            string name1 = Console.ReadLine();

                            var query2 = from s2 in order
                                         where s2.Customer == name1
                                         orderby s2.Money
                                         select s2;
                            List<Order> a2 = query2.ToList();

                            foreach (Order b2 in a2)
                            {
                                Console.WriteLine("订单号 客户 日期 总金额");
                                Console.WriteLine("");
                                Console.WriteLine("{0} {1} {2} {3}", b2.Id, b2.Customer, b2.Date, b2.Money);
                                b2.ShowOrderItem();
                            }
                            break;
                        default: Console.WriteLine("输入错误"); break;

                    }
                }
                catch
                {
                    Console.WriteLine("输入错误");
                }
            }
        }
 }