using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta c = new Cuenta(1, "Mariano");

            ICuentaBancaria cuenta = new CuentaAhorro();
            ICuentaBancaria cuentaBlindada = new BlindajeDecorador(cuenta);

            cuentaBlindada.abrirCuenta(c);
            

            Console.ReadLine();
        }
    }
}
