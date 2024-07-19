using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_VS_Interface.Memento
{
    public class LocationStack
    {
        private Stack<Object> _mementos = new Stack<Object>();

        public void SaveState(Object memento)
        {
            _mementos.Push(memento);
        }

        public Object DeleteState()
        {
           return  _mementos.Pop();
        }
    }
}
