using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo
{
    class OrderItem
    {
        private string Name { get; set; }
        private int Number;
        private double Price { get; set; }

        public string GetName() {
            return this.Name;
        }
        public int GetNumber()
        {
            return this.Number;
        }
        public void SetNumber(int number) {
            if (number > 0) this.Number = number;
            else throw new Exception("输入错误！");
        }
        public double GetPrice()
        {
            return this.Price;
        }


        //无参构造
        public OrderItem()
        {
            this.Name = string.Empty;
            this.Number = 0;
            this.Price = 0;
        }

        //有参构造
        public OrderItem(string name, int number, double price)
        {
            this.Name = name;
            this.Number = number;
            this.Price = price;
        }

        //计算单个订单项总价
        public double GetTotalPrice()
        {
            return this.Number * this.Price;
        }
    }
}
