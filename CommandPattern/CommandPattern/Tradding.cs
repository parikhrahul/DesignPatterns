using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class Tradding

    {
        public void Buy(String stock, int quantity)
        {
            Console.WriteLine($"Buying {quantity} shares of {stock} on BSE");
        }

        public void Sell(String stock, int quantity)
        {
            Console.WriteLine($"Selling {quantity} shares of {stock} on BSE");
        }
    }



}
