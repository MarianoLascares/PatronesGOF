using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Memento
    {
        private Juego estado;
        public Memento(Juego estado)
        {
            this.estado = estado;
        }
        public Juego getEstado()
        {
            return estado;
        }
    }
}
