using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagerSystem
{

    public class Customer
    {
        public string ID { get; set; }
        public string Name { get; set; }


        public Customer(){

        }
        public Customer(string id, string name) {
            this.ID = id;
            this.Name = name;
        }

        public override bool Equals(object obj)
        {
            try
            {
                Customer customer = obj as Customer;
                return this.ID == customer.ID;
            }
            catch(InvalidCastException e) {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public override int GetHashCode()
        {
            var hashCode = 1479869798;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }
    }
}
