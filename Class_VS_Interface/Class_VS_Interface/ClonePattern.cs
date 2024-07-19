//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Class_VS_Interface
//{
//    internal class ClonePattern
//    {
//    }

//    class Point
//    {
//        public int x;
//        public int y;
//    }

//    abstract class Shape
//    {

//        public abstract void draw();
//        public abstract Shape clone();
//    }

//    class Line : Shape
//    {
//         Line() { 
        
//        }

//        public override void draw() {
//            Console.WriteLine("Line");
//        }

//        public override Shape clone()
//        {
//            return new Line();
//        }
//    }

//    class Rectangle : Shape
//    {
//        Rectangle()
//        {

//        }

//        public override void draw()
//        {
//            Console.WriteLine("Rectangle");
//        }

//        public override Shape clone()
//        {
//            return new Rectangle();
//        }
//    }

//    class Ellipse : Shape
//    {
//        Ellipse()
//        {

//        }

//        public override void draw()
//        {
//            Console.WriteLine("Ellipse");
//        }

//        public override Shape clone()
//        {
//            return new Ellipse();
//        }
//    }
//}
