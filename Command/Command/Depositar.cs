using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Depositar : IOperacion
    {
        private Cuenta cuenta;
        private double monto;
        public Depositar(Cuenta cuenta, double monto)
        {
            this.cuenta = cuenta;
            this.monto = monto;
        }
        public void Execute()
        {
            this.cuenta.depositar(this.monto);
        }
    }
}
