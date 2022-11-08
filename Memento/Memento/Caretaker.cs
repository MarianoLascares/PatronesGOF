using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Caretaker
    {
        private List<Memento> mementos = new List<Memento>();

        public void addMemento(Memento m)
        {
            mementos.Add(m);
        }
        public Memento GetMemento(int index)
        {
            return mementos[index];
        }
    }
}
