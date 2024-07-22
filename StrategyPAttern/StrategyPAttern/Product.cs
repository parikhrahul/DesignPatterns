using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPAttern
{
    internal class Product
    {

        public string name;
        public double unitPrice;
        public double quantity;

        public Product(string name, double unitPrice, int quantity)
        {
            this.name = name;
            this.unitPrice = unitPrice;
            this.quantity = quantity;
        }
    }
}
