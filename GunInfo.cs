using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    internal class GunInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public GunInfo(int id, string name, int price)
        {
            Id = id;
            Name = name;

            Price = Price;
        }
        public override string ToString()
        {
            return String.Format("Id {0)" +
                "Name {1}" +
                "Age {2}", Id, Name, Price);
        }
    }
}
