using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_VS_Interface
{
    public class MessagePassing
    {
        public string Name { get; set; }

        private Dictionary<string, Action<dynamic>> _messageMap = new();

        public MessagePassing(string name)
        {
            Name = name;
            _messageMap.Add(nameof(Eat), Eat);
            _messageMap.Add(nameof(Sleep), Sleep);

        }

        public void Message(string what, dynamic data = null)
        {
            if (!_messageMap.ContainsKey(what))
            {
                Console.Error.WriteLine($"{Name} doesn't understand \"{what}\"");
            }
            else
            {
                _messageMap[what](data);
            }
        }

        private void Eat(dynamic food)
        {
            Console.WriteLine(food);
        }

        private void Sleep(dynamic hours)
        {
            Console.WriteLine($"{Name} is sleeping for {hours}");
        }
    }
}
