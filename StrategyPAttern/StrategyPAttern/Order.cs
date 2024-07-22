using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPAttern
{
    internal class Order
    {
        private List<Product> productList = new List<Product>();
        private DiscountStrategy discountStrategy;

        public void AddProduct(Product product)
        {
            productList.Add(product);
        }

        public List<Product> GetProductList()
        {
            return productList;
        }

        public void SetDiscountStrategy(DiscountStrategy strategy)
        {
            this.discountStrategy = strategy;
        }

        public void CheckOut()
        {
            double total = 0;
            foreach (var product in productList)
            {
                total += product.unitPrice * product.quantity;
            }

            double discount = discountStrategy.CalculateDiscount(total);

            Console.WriteLine("Order details");
            foreach (var product in productList)
            {
                Console.WriteLine($"{product.name} {product.unitPrice} {product.quantity} {product.unitPrice * product.quantity}");
            }
            Console.WriteLine($"Amount: {total}");
            Console.WriteLine($"Discount: {discount}");
            Console.WriteLine($"Net: {total - discount}");
        }
    }
}
