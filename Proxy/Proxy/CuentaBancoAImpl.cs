using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class CuentaBancoAImpl : ICuenta
    {
        public Cuenta depositarDinero(Cuenta cuenta, double monto)
        {
            double saldoActual = cuenta.SaldoInicial + monto;
            cuenta.SaldoInicial = saldoActual;
            Console.WriteLine("Saldo actual: " + cuenta.SaldoInicial);
            return cuenta;
        }

        public void mostrarSaldo(Cuenta cuenta)
        {
            Console.WriteLine("Saldo actual: " + cuenta.SaldoInicial);
        }

        public Cuenta retirarDinero(Cuenta cuenta, double monto)
        {
            double saldoActual = cuenta.SaldoInicial - monto;
            cuenta.SaldoInicial = saldoActual;
            Console.WriteLine("Saldo actual: " + cuenta.SaldoInicial);
            return cuenta;
        }
    }
}
