using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Subject
    {
        private List<Observador> observadores = new List<Observador>();
        private int estado;

        public int getEstado()
        {
            return estado;
        }
        public void setEstado(int estado)
        {
            this.estado = estado;
            NotificarTodosObservadores();
        }

        public void Agregar(Observador observador)
        {
            observadores.Add(observador);
        }
        
        public void NotificarTodosObservadores()
        {
            foreach(Observador observador in observadores)
            {
                observador.actualizar();
            }
        }
    }
}
