// See https://aka.ms/new-console-template for more information
using StrategyPattern.DiscountClasses;
using StrategyPAttern;



var order = new Order();
order.AddProduct(new Product("iPhone", 1_00_000, 1));
order.AddProduct(new Product("AirPods", 30_000, 2));
order.AddProduct(new Product("Macbook", 2_20_000, 1));
order.SetDiscountStrategy(new StandardDiscount());
order.CheckOut();

Console.WriteLine("\nApplying VIP Discount:");
order.SetDiscountStrategy(new VIPDiscount());
order.CheckOut();

Console.ReadLine();
