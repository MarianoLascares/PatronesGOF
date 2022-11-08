using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta c = new Cuenta(1, "Mariano", 100);
            
            ICuenta cuenta = new CuentaProxy(new CuentaBancoBImpl());
            cuenta.mostrarSaldo(c);
            c = cuenta.depositarDinero(c, 50);
            c = cuenta.retirarDinero(c, 20);
            cuenta.mostrarSaldo(c);
            Console.ReadKey();
        }
    }
}
