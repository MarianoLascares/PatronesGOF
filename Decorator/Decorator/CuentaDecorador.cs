using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class CuentaDecorador : ICuentaBancaria
    {
        protected ICuentaBancaria cuentaDecorada;

        public CuentaDecorador(ICuentaBancaria cuentaDecorada)
        {
            this.cuentaDecorada = cuentaDecorada;
        }

        public void abrirCuenta(Cuenta c)
        {
            this.cuentaDecorada.abrirCuenta(c);
        }
    }
}
