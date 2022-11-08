using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Invoker
    {
        private List<IOperacion> operaciones = new List<IOperacion>();

        public void recibirOperacion(IOperacion operacion)
        {
            this.operaciones.Add(operacion);
        }
        public void realizarOperaciones()
        {
            this.operaciones.ForEach(x => x.Execute());
            this.operaciones.Clear();
        }
    }
}
