using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_VS_Interface
{
    public class Human
    {
        //* Method defination
        public void eat() { Console.WriteLine("Chomp! Chomp!"); }
        public void sleep() { Console.WriteLine("zzzzZZZZZ"); }
        public void love() { Console.WriteLine("I love India"); }
    }

    public interface IDeveloper
    {
        // Method declaration
        void writeCode();
    }

    public interface IMusician
    {
        void playMusic();
    }

    public class Brendan : Human, IDeveloper
    {
        public void writeCode()
        {
            Console.WriteLine("Develop JavaScript Language");
        }

        public void run()
        {
            Console.WriteLine("Run run run!!!");
        }    
    }

    public class Sanjay : Human, IMusician, IDeveloper
    {
        public void writeCode() {

            Console.WriteLine("Develop core code of toll plaza application");
        }

        public void playMusic()
        {
            Console.WriteLine(" Sing Rag Malhar");
        }
    }

}
