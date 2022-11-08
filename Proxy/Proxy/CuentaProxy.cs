using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proxy
{
    internal class CuentaProxy : ICuenta
    {
        private ICuenta cuentaReal;

        public CuentaProxy(ICuenta cuentaReal)
        {
            this.cuentaReal = cuentaReal;
        }

        public Cuenta depositarDinero(Cuenta cuenta, double monto)
        {
            Console.WriteLine("----Cuenta Proxy - Depositar Dinero----");
            if (cuentaReal == null)
            {
                cuentaReal = new CuentaBancoAImpl();
                return cuentaReal.depositarDinero(cuenta, monto);
            }
            else
            {
                return cuentaReal.depositarDinero(cuenta, monto);
            }
        }

        public void mostrarSaldo(Cuenta cuenta)
        {
            Console.WriteLine("----Cuenta Proxy - Mostra Saldo----");
            if (cuentaReal == null)
            {
                cuentaReal = new CuentaBancoAImpl();
                cuentaReal.mostrarSaldo(cuenta);
            }
            else
            {
                cuentaReal.mostrarSaldo(cuenta);
            }
        }

        public Cuenta retirarDinero(Cuenta cuenta, double monto)
        {
            Console.WriteLine("----Cuenta Proxy - Retirar Dinero----");
            if(cuentaReal == null)
            {
                cuentaReal = new CuentaBancoAImpl();
                return cuentaReal.retirarDinero(cuenta, monto);
            }
            else
            {
                return cuentaReal.retirarDinero(cuenta, monto);
            }
        }
    }
}
