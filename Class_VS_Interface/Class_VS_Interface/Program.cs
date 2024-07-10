using Class_VS_Interface;
using System;

//namespace Class_VS_Interface
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var eich = new Brendan();
//            var sanjay = new Sanjay();

//            eich.eat();
//            eich.sleep();
//            eich.love();
//            eich.run();
//            eich.writeCode();

//            sanjay.playMusic();
//            sanjay.writeCode();

//            Console.ReadLine();

//        }
//    }
//}

//ILDASM

Brendan eich = new Brendan();
Sanjay sanjay = new Sanjay();
Order placeOrder = new Order();
//MessagePassing _messagePassing = new("Anders");
//_messagePassing.Message("Eat", "Mengo");
//_messagePassing.Message("Sleep", "6 hours");

//eich.eat();
//eich.sleep();
//eich.love();
//eich.run();
//eich.writeCode();

//sanjay.playMusic();
//sanjay.writeCode();

var device = placeOrder.PlaceOrder("PC", 2, 32, 500, 14 );
Console.WriteLine(device?.GetInfo());

Console.ReadLine();

