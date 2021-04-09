using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo
{
    [Serializable]
    public class Order : IComparable
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public double Money { get; set; }
        public string Date { get; set; }

        public List<OrderItem> orderItem = new List<OrderItem>();
        
        

        
        //无参构造
        public Order()
        {
            this.Id = 0;
            this.Customer = string.Empty;
            this.Money = 0;
            this.Date = string.Empty;

        }

        //有参构造
        public Order(int id, string customer, string date)
        {
            this.Id = id;
            this.Customer = customer;
            this.Date = date;
        }




        //重写CompareTo(),Equals(),GetHashCode()方法
        public int CompareTo(object obj)
        {
            Order a = obj as Order;
            return this.Id.CompareTo(a.Id);
        }

        public override bool Equals(object obj)
        {
            Order a = obj as Order;
            return this.Id == a.Id;
        }

        public override int GetHashCode()
        {
            return Convert.ToInt32(Id);
        }





        //对订单进行操作
        //添加订单项
        public void AddOrderItem(string name, int number, double price)   
        {
            OrderItem oi = new OrderItem(name, number, price);
            this.orderItem.Add(oi);
        }
        

        //删除订单项
        public void DelOrderItem() 
        {
            try
            {
                Console.WriteLine("请输入需要删除的订单明细序号：");
                int a = Convert.ToInt32(Console.ReadLine());
                this.orderItem.RemoveAt(a);
                Console.WriteLine("删除成功！");
                Console.WriteLine("-------------------------");
            }
            catch
            {
                Console.WriteLine("输入序号错误");
            }
        }



        //展示订单项
        public void ShowOrderItem()  
        {
            Console.WriteLine("序号 名称 数量 单价");
            foreach (OrderItem a in this.orderItem)
            {

                Console.WriteLine("-----------------------");
                Console.WriteLine("{0} {1} {2} {3}", this.orderItem.IndexOf(a),a.GetName() , a.GetNumber(), a.GetPrice());
            }
        }



        //计算所有订单总价
        public void GetAllPrice()
        {
            double i = 0;
            foreach (OrderItem a in this.orderItem)
            {
                i = i + a.GetTotalPrice();
            }
            this.Money = i;


        }
    }
}
