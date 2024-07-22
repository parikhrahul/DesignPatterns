// See https://aka.ms/new-console-template for more information

using CommandPattern;

var market = new Tradding();
market.Buy("Reliance", 100);
market.Sell("ACC", 1000);

Console.ReadLine();
