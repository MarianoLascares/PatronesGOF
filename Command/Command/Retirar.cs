using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Retirar : IOperacion
    {
        private Cuenta cuenta;
        private double monto;
        public Retirar(Cuenta cuenta, double monto)
        {
            this.cuenta = cuenta;
            this.monto = monto;
        }
        public void Execute()
        {
            this.cuenta.retirar(this.monto);
        }
    }
}
