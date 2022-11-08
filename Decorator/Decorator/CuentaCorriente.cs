using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class CuentaCorriente : ICuentaBancaria
    {
        public void abrirCuenta(Cuenta c)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Se abrió una cuenta de Corriente");
            Console.WriteLine("Cliente: " + c.getCliente());
        }
    }
}
