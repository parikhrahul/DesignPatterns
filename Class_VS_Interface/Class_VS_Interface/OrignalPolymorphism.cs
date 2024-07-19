using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_VS_Interface
{
    public abstract class OrignalPolymorphism
    {
        public abstract void fly();
    }

    public class Superman : OrignalPolymorphism
    {
        public override void  fly()
        {
            Console.WriteLine("Superman is flying");
        }
    }

    public class Plane : OrignalPolymorphism
    {
        public override void fly()
        {
            Console.WriteLine("Runway ... take off");
        }
    }

    public class Mosquito : OrignalPolymorphism
    {
        public override void fly()
        {
            Console.WriteLine("bbbzzzZZZ");
        }
    }
}
