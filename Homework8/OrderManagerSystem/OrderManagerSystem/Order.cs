using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagerSystem
{
    public class Order : IComparable<Order>
    {
        private List<OrderDetail> orderDetails;
        public int OrderID { get; set; }
        public Customer Customer { get; set; }
        
        public string CustomerID { get => (Customer != null) ? Customer.ID : ""; }
        public string CustomerName { get => (Customer != null) ? Customer.Name : ""; }

        public DateTime CreatTime { get; set; }

        public Order()
        {
            orderDetails = new List<OrderDetail>();
            CreatTime = DateTime.Now;
        }

        public Order(int orderID, Customer customer, List<OrderDetail> orderDetails) {
            this.OrderID = orderID;
            this.Customer = customer;
            this.orderDetails = (orderDetails == null)? new List<OrderDetail>(): orderDetails;
            this.CreatTime = DateTime.Now;
        }

        public List<OrderDetail> OrderDetails {
            get { return orderDetails; }
        }

        public double TotalPrice {
            get => orderDetails.Sum(item => item.GetTotalPrice);
        }

        public void AddItem(OrderDetail orderItem)
        {
            if (OrderDetails.Contains(orderItem))
                throw new ApplicationException($"添加错误：订单项{orderItem.GoodName} 已经存在!");
            OrderDetails.Add(orderItem);
        }

        public void RemoveDetail(OrderDetail orderItem)
        {
            OrderDetails.Remove(orderItem);
        }

        public override bool Equals(object obj)
        {
            Order order = obj as Order;
            return OrderID == order.OrderID;
        }

        public int CompareTo(Order other)
        {
            if (other == null) return 1;
            return this.OrderID.CompareTo(other.OrderID);
        }

        public override int GetHashCode()
        {
            var hashCode = 2124146530;
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderDetail>>.Default.GetHashCode(orderDetails);
            hashCode = hashCode * -1521134295 + OrderID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Customer>.Default.GetHashCode(Customer);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CustomerID);
            hashCode = hashCode * -1521134295 + CreatTime.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderDetail>>.Default.GetHashCode(OrderDetails);
            hashCode = hashCode * -1521134295 + TotalPrice.GetHashCode();
            return hashCode;
        }
    }
}
