using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagerSystem
{
    public class Goods
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Goods() {}
        public Goods(string id, string name, double totalprice) {
            this.ID = id;
            this.Name = name;
            this.Price = totalprice;
        }

        public override bool Equals(object obj)
        {
            try
            {
                Goods goods = obj as Goods;
                return this.ID == goods.ID;
            }
            catch (InvalidCastException e) {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public override int GetHashCode()
        {
            var hashCode = 560300832;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Price.GetHashCode();
            return hashCode;
        }
    }
}
