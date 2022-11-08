using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Cuenta
    {
        private int idCuenta;
        private string usuario;
        private double saldoInicial;

        public Cuenta(int idCuenta, string usuario, double saldoInicial)
        {
            this.idCuenta = idCuenta;
            this.usuario = usuario;
            this.saldoInicial = saldoInicial;
        }

        public int IdCuenta { get => idCuenta; set => idCuenta = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public double SaldoInicial { get => saldoInicial; set => saldoInicial = value; }
    }
}
