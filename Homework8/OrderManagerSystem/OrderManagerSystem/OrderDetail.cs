using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagerSystem
{
    public class OrderDetail
    {
        public uint Index { get; set; }
        public Goods GoodItem { get; set; }

        public string GoodName { get => GoodItem != null? GoodItem.Name:""; }
        public double Price { get => GoodItem != null ? GoodItem.Price : 0.0; }

        public int Quantity { get; set; }


        public OrderDetail() {}
        public OrderDetail(uint index, Goods gooditem, int quantity) {
            this.Index = index;
            this.GoodItem = gooditem;
            this.Quantity = quantity;
        }

        public double GetTotalPrice{
            get => GoodItem == null ? 0.0 : GoodItem.Price * Quantity;
        }

        public override bool Equals(object obj)
        {
            try
            {
                OrderDetail orderDetail = obj as OrderDetail;
                return this.GoodName == orderDetail.GoodName;
            }catch(InvalidCastException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public override int GetHashCode()
        {
            var hashCode = -634615977;
            hashCode = hashCode * -1521134295 + Index.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Goods>.Default.GetHashCode(GoodItem);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GoodName);
            hashCode = hashCode * -1521134295 + Price.GetHashCode();
            hashCode = hashCode * -1521134295 + Quantity.GetHashCode();
            hashCode = hashCode * -1521134295 + GetTotalPrice.GetHashCode();
            return hashCode;
        }
    }
}
