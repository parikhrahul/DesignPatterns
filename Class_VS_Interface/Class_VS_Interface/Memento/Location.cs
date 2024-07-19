using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_VS_Interface.Memento
{
    public class Location
    {
        private static int locationSequence = 1;
        private int sequence = 0;
        private string city;

        public void MoveTo(string city)
        {
            this.city = city;
            this.sequence = Location.locationSequence++;
        }

        public void print()
        {
            System.Console.WriteLine($"{sequence}: {city}");
        }


        public LocationMemento SaveState()
        {
            return new LocationMemento(sequence, city);
        }

        public void DeleteState(LocationMemento memento)
        {
            this.sequence = memento.Sequence;
            this.city = memento.City;
        }
    }
    public class LocationMemento
    {
        public int Sequence { get; set; }

        public string City { get; set; }

        public LocationMemento(int sequence, string city)
        {
            Sequence = sequence;
            City = city;
        }
    }
}
