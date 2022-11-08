using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class SolObservador : Observador
    {
        private double valorCambio = 3.25;

        public SolObservador(Subject sujeto)
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
