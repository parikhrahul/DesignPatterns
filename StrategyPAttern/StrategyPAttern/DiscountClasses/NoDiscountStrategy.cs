using StrategyPAttern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.DiscountClasses
{
    internal class NoDiscountStrategy : DiscountStrategy
    {
        public double CalculateDiscount(double total)
        {
            return 0;
        }
    }
}
