using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class PesoARGObservador : Observador
    {
        private double valorCambio = 29.86;

        public PesoARGObservador(Subject sujeto)
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
