using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class PesoMXObservador : Observador
    {
        private double valorCambio = 19.07;

        public PesoMXObservador(Subject sujeto)
        {
            this.sujeto = sujeto;
            this.sujeto.Agregar(this);
        }
        public override void actualizar()
        {
            Console.WriteLine("PEN: " + sujeto.getEstado() * valorCambio);
        }
    }
}
