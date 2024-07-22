using StrategyPAttern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.DiscountClasses
{
    internal class HighValueDiscount : DiscountStrategy
    {
        public double CalculateDiscount(double total)
        {
            if (total > 1000)
            {
                return total * 0.20;
            };

            return total * 0.10;
        }
    }
}
