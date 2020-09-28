using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHP
{
    // product abstraction
    public struct Product
    {
        public int id;
        public string name;
        public double price;

        public Product(int aID, string aName, double aPrice)
        {
            id = aID;
            name = aName;
            price = aPrice;
        }
    }
}
