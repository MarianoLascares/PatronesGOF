using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class BlindajeDecorador : CuentaDecorador
    {
        public BlindajeDecorador(ICuentaBancaria cuentaDecorada) : base(cuentaDecorada)
        {
            
        }

        public void abricCuenta(Cuenta c)
        {
            cuentaDecorada.abrirCuenta(c);
            agregarBlindaje(c);
        }

        public void agregarBlindaje(Cuenta c)
        {
            Console.WriteLine("Se agregó blidaje a la cuenta del cliente " + c.getCliente());
        }
    }
}
