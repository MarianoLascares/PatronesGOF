using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Juego
    {
        private String nombre;
        private int checkpoint;

        public int getCheckpoint()
        {
            return checkpoint;
        }
        public void setCheckpoint(int checkpoint)
        {
            this.checkpoint = checkpoint;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public String toString()
        {
            return $"Juego [nombre = {nombre}, checkpoint = {checkpoint}]";
        }
    }
}
